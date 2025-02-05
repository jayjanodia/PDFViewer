using Patagames.Pdf.Enums;
using Patagames.Pdf.Net;
using Patagames.Pdf.Net.Controls.WinForms;
using System;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Threading;
using static Patagames.Pdf.Net.PdfSearch;

namespace PDF_Viewer
{
    public partial class PDFViewer : Form
    {
        private int dpi = 400; // Set the DPI for higher quality
        private int currentPageIndex = 0;
        private int currentCharIndex = 0;
        private int previousPageIndex = -1;
        private int previousCharIndex = -1;
        private int previousCharsCount = 0;
        private string currentWord = "";
        private bool isDarkMode = true;
        private CancellationTokenSource cancellationTokenSource;

        List<Control> shadowControls = new List<Control>();
        Bitmap? shadowBmp = null;

        public PDFViewer()
        {
            InitializeComponent();
            shadowControls.Add(btnCloseBookmarks);

            pdfViewer1.ContextMenuStrip = contextMenuStrip1;
            pdfViewer1.MouseWheel += PDFViewer_MouseWheel;
            toolTip1.SetToolTip(this.btnOpenFindTbl, "Find works by pressing Ctrl + F as well!");
            ApplyDarkTheme();
            btnDarkMode.Text = pdfViewer1.BackColor == Color.DarkGray ? "Light Mode" : "Dark Mode";
            this.Refresh();
        }

        private void btnOpenPDF_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pdfViewer1.LoadDocument(openFileDialog.FileName);
                }
            }
        }

        private void btnCloseBookmarks_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed)
            {
                splitContainer1.Panel1Collapsed = false;
                btnCloseBookmarks.Text = "Close Bookmarks Tab";
            }
            else
            {
                splitContainer1.Panel1Collapsed = true;
                btnCloseBookmarks.Text = "Show Bookmarks Tab";
            }
        }

        private void PDFViewer_MouseWheel(object? sender, MouseEventArgs e)
        {
            // Prevent the default scroll behavior
            ((HandledMouseEventArgs)e).Handled = true;
            pdfViewer1.SizeMode = SizeModes.Zoom;

            const float minZoom = 0.5f;
            const float maxZoom = 3.0f;
            // Check if Ctrl key is pressed
            if (Control.ModifierKeys == Keys.Control)
            {
                Console.WriteLine("Before: ", pdfViewer1.Zoom);
                if (e.Delta > 0 && pdfViewer1.Zoom < maxZoom)
                {
                    // Zoom In
                    pdfViewer1.Zoom = Math.Min(pdfViewer1.Zoom + 0.125f, maxZoom);
                }
                else if (e.Delta < 0 && pdfViewer1.Zoom > minZoom)
                {
                    // Zoom Out
                    pdfViewer1.Zoom = Math.Max(pdfViewer1.Zoom - 0.125f, minZoom);
                }
                pdfViewer1.Refresh();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyImageAsType(RenderFlags.FPDF_LCD_TEXT);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, ev) =>
            {
                var page = pdfViewer1.Document.Pages[pdfViewer1.CurrentIndex];
                int width = (int)(page.Width * dpi / 72);
                int height = (int)(page.Height * dpi / 72);

                using (var bitmap = new Bitmap(width, height))
                {
                    using (var graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.Clear(Color.White);
                        page.Render(graphics, 0, 0, width, height, PageRotate.Normal, Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT);
                    }
                    ev.Graphics?.DrawImage(bitmap, ev.MarginBounds);
                }
            };
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument,
                AllowSomePages = true,
                ShowHelp = true,
                UseEXDialog = true // use extended dialog
            };
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Access printer settings
                PrinterSettings printerSettings = printDialog.PrinterSettings;
                PageSettings pageSettings = printDialog.PrinterSettings.DefaultPageSettings;

                // Example: Set color printing option
                if (printerSettings.SupportsColor)
                {
                    pageSettings.Color = true; // Set to false for black-and-white
                }
                printDocument.Print();
            }
        }

        private void copyAsGrayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyImageAsType(RenderFlags.FPDF_GRAYSCALE);
        }

        private void CopyImageAsType(RenderFlags flag)
        {
            // Copy current page as image
            PdfPage page = pdfViewer1.Document.Pages[pdfViewer1.CurrentIndex];
            int width = (int)(page.Width * dpi / 72);
            int height = (int)(page.Height * dpi / 72);
            using (var bitmap = new Bitmap(width, height))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(Color.White);
                    page.Render(graphics, 0, 0, width, height, PageRotate.Normal, flag);
                }
                Clipboard.SetImage(bitmap);
            }
        }

        private void PDFViewer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                tblFindText.Visible = true;
                txtFind.Focus();
                txtFind.SelectAll();
            }
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFind.Text))
            {
                MessageBox.Show("Kindly enter a value to search for!", "No text entered in search bar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnFind.Text = "Find";
                return;
            }
            if (pdfViewer1.Document == null)
            {
                MessageBox.Show("Please open up a PDF file to search for a word in it.", "No file opened!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnFind.Text = "Find";
                return;
            }

            string txtSearch = txtFind.Text;
            if (currentWord != txtSearch)
            {
                currentWord = txtSearch;
                pdfViewer1.RemoveHighlightFromText();
                pdfViewer1.Invalidate();
            }
            if (!string.IsNullOrEmpty(txtSearch))
            {
                bool reset = btnFind.Text == "Find";
                currentPageIndex = pdfViewer1.CurrentIndex;
                cancellationTokenSource = new CancellationTokenSource();
                await FindText(txtSearch, reset, true, cancellationTokenSource.Token);
                if (cancellationTokenSource.Token.IsCancellationRequested) return;
                btnFind.Text = "Find Next";
                btnFindPrev.Visible = true;
            }
        }

        private async Task FindText(string txtSearch, bool reset, bool forward, CancellationToken cancellationToken)
        {
            bool found = false;
            FindFlags findFlags = chkMatchCase.Checked ? FindFlags.MatchCase : FindFlags.None;

            tblProgressBar.Visible = true;
            prgSearch.Minimum = 0;
            prgSearch.Maximum = pdfViewer1.Document.Pages.Count;
            prgSearch.Value = currentPageIndex;

            int startPage = forward ? (reset ? 0 : currentPageIndex) : currentPageIndex;
            int endPage = forward ? pdfViewer1.Document.Pages.Count : -1;
            int step = forward ? 1 : -1;

            // Highlight the current occurence in orange
            for (int i = startPage; i != endPage; i += step)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    tblProgressBar.Visible = false;
                    MessageBox.Show("Search Cancelled.");
                    return;
                }

                var page = pdfViewer1.Document.Pages[i];
                PdfFind foundText;
                if (i == currentPageIndex)
                {
                    foundText = await Task.Run(() => page.Text.Find(txtSearch, findFlags, reset ? 0 : currentCharIndex));
                }
                else
                {
                    foundText = await Task.Run(() => page.Text.Find(txtSearch, findFlags, 0));
                }

                if (foundText != null)
                {
                    do
                    {
                        if (previousPageIndex != -1 && previousCharIndex != -1)
                        {
                            pdfViewer1.HighlightText(previousPageIndex, previousCharIndex, previousCharsCount, Color.Yellow);
                        }
                        // PdfTextInfo txtInfo = foundText.FoundText;
                        pdfViewer1.CurrentIndex = i;
                        pdfViewer1.ScrollToChar(foundText.CharIndex);
                        pdfViewer1.HighlightText(i, foundText.CharIndex, foundText.CharsCount, Color.Orange);
                        pdfViewer1.Invalidate();
                        currentPageIndex = i;
                        currentCharIndex = foundText.CharIndex + foundText.CharsCount;

                        previousPageIndex = i;
                        previousCharIndex = foundText.CharIndex;
                        previousCharsCount = foundText.CharsCount;

                        found = true;
                    } while (await Task.Run(() => foundText.FindNext()));
                }
                if (found)
                    break;

                // Update the progress bar
                prgSearch.Value = i + 1;
            }
            // Hide the progress bar when done
            tblProgressBar.Visible = false;

            if (!found)
            {
                MessageBox.Show("Text not found!");
                btnFind.Text = "Find"; // Reset button text if not found
            }
        }

        private void btnCloseFind_Click(object sender, EventArgs e)
        {
            tblFindText.Visible = false;
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFind_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnCloseFind_Click(sender, e);
            }
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;

            if (isDarkMode)
            {
                ApplyDarkTheme();
                btnDarkMode.Text = "Light Mode";
            }
            else
            {
                ApplyLightTheme();
                btnDarkMode.Text = "Dark Mode";
            }
        }

        private void ApplyDarkTheme()
        {
            Color purple = Color.FromArgb(255, 109, 40, 210);
            this.BackColor = Color.FromArgb(45, 45, 48);
            tableLayoutPanel1.BackColor = Color.FromArgb(33, 33, 33);
            btnCloseBookmarks.ForeColor = Color.Lavender;
            btnCloseBookmarks.BackColor = purple;
            txtFind.ForeColor = Color.Lavender;
            txtFind.BackColor = purple;
            btnFind.ForeColor = Color.Lavender;
            btnFind.BackColor = purple;
            btnFindPrev.ForeColor = Color.Lavender;
            btnFindPrev.BackColor = purple;
            btnOpenFindTbl.ForeColor = Color.Lavender;
            btnOpenFindTbl.BackColor = purple;
            btnCloseFind.ForeColor = Color.Lavender;
            btnCloseFind.BackColor = purple;
            btnCancelSearch.ForeColor = Color.Lavender;
            btnCancelSearch.BackColor = purple;
            chkMatchCase.ForeColor = Color.Lavender;
            btnOpenPDF.ForeColor = Color.Lavender;
            btnOpenPDF.BackColor = purple;
            btnDarkMode.ForeColor = Color.Lavender;
            btnDarkMode.BackColor = purple;
            btnDarkMode.FlatStyle = FlatStyle.Flat;
            btnDarkMode.FlatAppearance.BorderColor = Color.FromArgb(100, 5, 5, 5);
            btnDarkMode.FlatAppearance.BorderSize = 1;
            bookmarksViewer1.ForeColor = Color.White;
            bookmarksViewer1.BackColor = Color.FromArgb(30, 30, 30);
            pdfViewer1.BackColor = Color.DarkGray;
        }

        private void ApplyLightTheme()
        {
            Color purple = Color.FromArgb(255, 109, 40, 210);
            this.BackColor = purple;
            tableLayoutPanel1.BackColor = purple;
            btnCloseBookmarks.ForeColor = purple;
            btnCloseBookmarks.BackColor = Color.Lavender;
            btnOpenFindTbl.ForeColor = purple;
            btnOpenFindTbl.BackColor = Color.Lavender;
            btnDarkMode.ForeColor = purple;
            btnDarkMode.BackColor = Color.Lavender;
            btnCloseFind.ForeColor = purple;
            btnCloseFind.BackColor = Color.Lavender;
            btnFind.BackColor = Color.Lavender;
            btnFind.ForeColor = purple;
            btnOpenPDF.ForeColor = purple;
            btnOpenPDF.BackColor = Color.Lavender;
            txtFind.BackColor = Color.Lavender;
            txtFind.ForeColor = purple;
            bookmarksViewer1.BackColor = Color.Lavender;
            bookmarksViewer1.ForeColor = purple;
            pdfViewer1.BackColor = Color.DarkGray;
        }

        private void btnOpenFindTbl_Click(object sender, EventArgs e)
        {
            tblFindText.Visible = true;
            txtFind.Focus();
            txtFind.SelectAll();
        }

        public void PDFViewer_Paint(object sender, PaintEventArgs e)
        {
            if (shadowBmp == null || shadowBmp.Size != this.Size)
            {
                shadowBmp?.Dispose();
                shadowBmp = new Bitmap(this.Width, this.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            }
            foreach (Control control in shadowControls)
            {
                using (GraphicsPath gp = new GraphicsPath())
                {
                    gp.AddRectangle(new Rectangle(control.Location.X, control.Location.Y, control.Size.Width, control.Size.Height));
                    DrawShadowSmooth(gp, 100, 60, shadowBmp);
                }
                e.Graphics.DrawImage(shadowBmp, new Point(0, 0));
            }
        }
        private static void DrawShadowSmooth(GraphicsPath gp, int intensity, int radius, Bitmap dest)
        {
            using (Graphics g = Graphics.FromImage(dest))
            {
                g.Clear(Color.Transparent);
            }
        }

        private void btnFitToScreen_Click(object sender, EventArgs e)
        {
            pdfViewer1.SizeMode = SizeModes.FitToWidth;
        }

        private async void btnFindPrev_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFind.Text))
            {
                MessageBox.Show("Kindly enter a value to search for!", "No text entered in search bar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pdfViewer1.Document == null)
            {
                MessageBox.Show("Please open up a PDF file to search for a word in it.", "No file opened!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string txtSearch = txtFind.Text;
            if (currentWord != txtSearch)
            {
                currentWord = txtSearch;
                pdfViewer1.RemoveHighlightFromText();
                pdfViewer1.Invalidate();
            }
            if (!string.IsNullOrEmpty(txtSearch))
            {
                bool reset = btnFind.Text == "Find";
                currentPageIndex = pdfViewer1.CurrentIndex;
                cancellationTokenSource = new CancellationTokenSource();
                await FindText(txtSearch, reset, false, cancellationTokenSource.Token);
            }
        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
        }
    }
}
