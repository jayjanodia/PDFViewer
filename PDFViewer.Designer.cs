namespace PDF_Viewer
{
    partial class PDFViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            splitContainer1 = new SplitContainer();
            bookmarksViewer1 = new Patagames.Pdf.Net.Controls.WinForms.BookmarksViewer(components);
            pdfViewer1 = new Patagames.Pdf.Net.Controls.WinForms.PdfViewer();
            btnCloseBookmarks = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnOpenPDF = new Button();
            btnDarkMode = new Button();
            btnOpenFindTbl = new Button();
            btnFitToScreen = new Button();
            tblFindText = new TableLayoutPanel();
            chkMatchCase = new CheckBox();
            btnFind = new Button();
            txtFind = new TextBox();
            btnCloseFind = new Button();
            tblProgressBar = new TableLayoutPanel();
            lblPleaseWait = new Label();
            prgSearch = new ProgressBar();
            contextMenuStrip1 = new ContextMenuStrip(components);
            copyToolStripMenuItem = new ToolStripMenuItem();
            copyAsGrayScaleToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tblFindText.SuspendLayout();
            tblProgressBar.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.MistyRose;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 2);
            tableLayoutPanel1.Controls.Add(btnCloseBookmarks, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel1.Controls.Add(tblFindText, 1, 1);
            tableLayoutPanel1.Controls.Add(tblProgressBar, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 665);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            tableLayoutPanel1.SetColumnSpan(splitContainer1, 2);
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 106);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(bookmarksViewer1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pdfViewer1);
            splitContainer1.Size = new Size(794, 556);
            splitContainer1.SplitterDistance = 264;
            splitContainer1.TabIndex = 1;
            // 
            // bookmarksViewer1
            // 
            bookmarksViewer1.BackColor = Color.Lavender;
            bookmarksViewer1.Dock = DockStyle.Fill;
            bookmarksViewer1.Location = new Point(0, 0);
            bookmarksViewer1.Name = "bookmarksViewer1";
            bookmarksViewer1.PdfViewer = pdfViewer1;
            bookmarksViewer1.Size = new Size(264, 556);
            bookmarksViewer1.TabIndex = 0;
            // 
            // pdfViewer1
            // 
            pdfViewer1.BackColor = SystemColors.ControlDark;
            pdfViewer1.CurrentIndex = -1;
            pdfViewer1.CurrentPageHighlightColor = Color.FromArgb(170, 70, 130, 180);
            pdfViewer1.Dock = DockStyle.Fill;
            pdfViewer1.Document = null;
            pdfViewer1.FormHighlightColor = Color.Transparent;
            pdfViewer1.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY;
            pdfViewer1.LoadingIconText = "Loading...";
            pdfViewer1.Location = new Point(0, 0);
            pdfViewer1.Margin = new Padding(4, 3, 4, 3);
            pdfViewer1.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.Default;
            pdfViewer1.Name = "pdfViewer1";
            pdfViewer1.OptimizedLoadThreshold = 1000;
            pdfViewer1.Padding = new Padding(12, 12, 12, 12);
            pdfViewer1.PageAlign = ContentAlignment.MiddleCenter;
            pdfViewer1.PageAutoDispose = true;
            pdfViewer1.PageBackColor = Color.White;
            pdfViewer1.PageBorderColor = Color.Black;
            pdfViewer1.PageMargin = new Padding(10);
            pdfViewer1.PageSeparatorColor = Color.Gray;
            pdfViewer1.RenderFlags = Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT | Patagames.Pdf.Enums.RenderFlags.FPDF_NO_CATCH;
            pdfViewer1.ShowCurrentPageHighlight = true;
            pdfViewer1.ShowLoadingIcon = true;
            pdfViewer1.ShowPageSeparator = true;
            pdfViewer1.Size = new Size(526, 556);
            pdfViewer1.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.Zoom;
            pdfViewer1.TabIndex = 0;
            pdfViewer1.TextSelectColor = Color.FromArgb(70, 70, 130, 180);
            pdfViewer1.TilesCount = 2;
            pdfViewer1.UseProgressiveRender = true;
            pdfViewer1.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical;
            pdfViewer1.Zoom = 1F;
            // 
            // btnCloseBookmarks
            // 
            btnCloseBookmarks.Anchor = AnchorStyles.Left;
            btnCloseBookmarks.AutoSize = true;
            btnCloseBookmarks.BackColor = Color.Lavender;
            btnCloseBookmarks.FlatAppearance.BorderSize = 0;
            btnCloseBookmarks.FlatStyle = FlatStyle.Flat;
            btnCloseBookmarks.ForeColor = Color.Black;
            btnCloseBookmarks.Location = new Point(3, 7);
            btnCloseBookmarks.Name = "btnCloseBookmarks";
            btnCloseBookmarks.Size = new Size(128, 25);
            btnCloseBookmarks.TabIndex = 2;
            btnCloseBookmarks.Text = "Close Bookmarks tab";
            btnCloseBookmarks.UseVisualStyleBackColor = false;
            btnCloseBookmarks.Click += btnCloseBookmarks_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btnOpenPDF);
            flowLayoutPanel1.Controls.Add(btnDarkMode);
            flowLayoutPanel1.Controls.Add(btnOpenFindTbl);
            flowLayoutPanel1.Controls.Add(btnFitToScreen);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(403, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(394, 33);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.TabStop = true;
            // 
            // btnOpenPDF
            // 
            btnOpenPDF.Anchor = AnchorStyles.None;
            btnOpenPDF.AutoSize = true;
            btnOpenPDF.BackColor = Color.Lavender;
            btnOpenPDF.FlatStyle = FlatStyle.Flat;
            btnOpenPDF.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenPDF.Location = new Point(297, 3);
            btnOpenPDF.Name = "btnOpenPDF";
            btnOpenPDF.Size = new Size(94, 27);
            btnOpenPDF.TabIndex = 1;
            btnOpenPDF.Text = "Add PDF File";
            btnOpenPDF.UseVisualStyleBackColor = false;
            btnOpenPDF.Click += btnOpenPDF_Click;
            // 
            // btnDarkMode
            // 
            btnDarkMode.AutoSize = true;
            btnDarkMode.BackColor = Color.Lavender;
            btnDarkMode.FlatStyle = FlatStyle.Flat;
            btnDarkMode.Location = new Point(214, 3);
            btnDarkMode.Name = "btnDarkMode";
            btnDarkMode.Size = new Size(77, 27);
            btnDarkMode.TabIndex = 2;
            btnDarkMode.Text = "Dark Mode";
            btnDarkMode.UseVisualStyleBackColor = false;
            btnDarkMode.Click += btnDarkMode_Click;
            // 
            // btnOpenFindTbl
            // 
            btnOpenFindTbl.AutoSize = true;
            btnOpenFindTbl.BackColor = Color.Lavender;
            btnOpenFindTbl.FlatAppearance.BorderColor = Color.Lavender;
            btnOpenFindTbl.FlatStyle = FlatStyle.Flat;
            btnOpenFindTbl.Location = new Point(133, 3);
            btnOpenFindTbl.Name = "btnOpenFindTbl";
            btnOpenFindTbl.Size = new Size(75, 27);
            btnOpenFindTbl.TabIndex = 3;
            btnOpenFindTbl.Text = "Find";
            btnOpenFindTbl.UseVisualStyleBackColor = false;
            btnOpenFindTbl.Click += btnOpenFindTbl_Click;
            // 
            // btnFitToScreen
            // 
            btnFitToScreen.AutoSize = true;
            btnFitToScreen.BackColor = Color.Lavender;
            btnFitToScreen.FlatStyle = FlatStyle.Flat;
            btnFitToScreen.Location = new Point(42, 3);
            btnFitToScreen.Name = "btnFitToScreen";
            btnFitToScreen.Size = new Size(85, 27);
            btnFitToScreen.TabIndex = 4;
            btnFitToScreen.Text = "Fit To Screen";
            btnFitToScreen.UseVisualStyleBackColor = false;
            btnFitToScreen.Click += btnFitToScreen_Click;
            // 
            // tblFindText
            // 
            tblFindText.AutoSize = true;
            tblFindText.ColumnCount = 3;
            tblFindText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblFindText.ColumnStyles.Add(new ColumnStyle());
            tblFindText.ColumnStyles.Add(new ColumnStyle());
            tblFindText.Controls.Add(chkMatchCase, 0, 1);
            tblFindText.Controls.Add(btnFind, 1, 0);
            tblFindText.Controls.Add(txtFind, 0, 0);
            tblFindText.Controls.Add(btnCloseFind, 2, 0);
            tblFindText.Dock = DockStyle.Right;
            tblFindText.Location = new Point(519, 42);
            tblFindText.Name = "tblFindText";
            tblFindText.RowCount = 2;
            tblFindText.RowStyles.Add(new RowStyle());
            tblFindText.RowStyles.Add(new RowStyle());
            tblFindText.Size = new Size(278, 58);
            tblFindText.TabIndex = 6;
            tblFindText.Visible = false;
            // 
            // chkMatchCase
            // 
            chkMatchCase.AutoSize = true;
            chkMatchCase.Location = new Point(3, 36);
            chkMatchCase.Name = "chkMatchCase";
            chkMatchCase.Size = new Size(88, 19);
            chkMatchCase.TabIndex = 4;
            chkMatchCase.Text = "Match Case";
            chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            btnFind.Anchor = AnchorStyles.Top;
            btnFind.AutoSize = true;
            btnFind.BackColor = Color.Lavender;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Location = new Point(159, 3);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(55, 27);
            btnFind.TabIndex = 2;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // txtFind
            // 
            txtFind.Anchor = AnchorStyles.Top;
            txtFind.BackColor = Color.Lavender;
            txtFind.Location = new Point(3, 3);
            txtFind.Name = "txtFind";
            txtFind.PlaceholderText = "Search...";
            txtFind.Size = new Size(150, 23);
            txtFind.TabIndex = 3;
            txtFind.KeyDown += txtFind_KeyDown;
            // 
            // btnCloseFind
            // 
            btnCloseFind.Anchor = AnchorStyles.Top;
            btnCloseFind.AutoSize = true;
            btnCloseFind.BackColor = Color.Lavender;
            btnCloseFind.FlatStyle = FlatStyle.Flat;
            btnCloseFind.Location = new Point(220, 3);
            btnCloseFind.Name = "btnCloseFind";
            btnCloseFind.Size = new Size(55, 27);
            btnCloseFind.TabIndex = 5;
            btnCloseFind.Text = "Close";
            btnCloseFind.UseVisualStyleBackColor = false;
            btnCloseFind.Click += btnCloseFind_Click;
            // 
            // tblProgressBar
            // 
            tblProgressBar.AutoSize = true;
            tblProgressBar.ColumnCount = 1;
            tblProgressBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblProgressBar.Controls.Add(lblPleaseWait, 0, 0);
            tblProgressBar.Controls.Add(prgSearch, 0, 1);
            tblProgressBar.Location = new Point(3, 42);
            tblProgressBar.Name = "tblProgressBar";
            tblProgressBar.RowCount = 2;
            tblProgressBar.RowStyles.Add(new RowStyle());
            tblProgressBar.RowStyles.Add(new RowStyle());
            tblProgressBar.Size = new Size(222, 44);
            tblProgressBar.TabIndex = 7;
            tblProgressBar.Visible = false;
            // 
            // lblPleaseWait
            // 
            lblPleaseWait.AutoSize = true;
            lblPleaseWait.BackColor = Color.MediumSlateBlue;
            lblPleaseWait.Location = new Point(3, 0);
            lblPleaseWait.Name = "lblPleaseWait";
            lblPleaseWait.Size = new Size(216, 15);
            lblPleaseWait.TabIndex = 0;
            lblPleaseWait.Text = "Kindly wait for the search to complete...";
            // 
            // prgSearch
            // 
            prgSearch.BackColor = Color.MediumPurple;
            prgSearch.Dock = DockStyle.Fill;
            prgSearch.Location = new Point(3, 18);
            prgSearch.Name = "prgSearch";
            prgSearch.Size = new Size(216, 23);
            prgSearch.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { copyToolStripMenuItem, copyAsGrayScaleToolStripMenuItem, printToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(171, 70);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(170, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // copyAsGrayScaleToolStripMenuItem
            // 
            copyAsGrayScaleToolStripMenuItem.Name = "copyAsGrayScaleToolStripMenuItem";
            copyAsGrayScaleToolStripMenuItem.Size = new Size(170, 22);
            copyAsGrayScaleToolStripMenuItem.Text = "Copy as GrayScale";
            copyAsGrayScaleToolStripMenuItem.Click += copyAsGrayScaleToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(170, 22);
            printToolStripMenuItem.Text = "Print";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Shortcut: Ctrl + F";
            // 
            // PDFViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 665);
            Controls.Add(tableLayoutPanel1);
            KeyPreview = true;
            Name = "PDFViewer";
            Text = "PDF Viewer";
            KeyDown += PDFViewer_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tblFindText.ResumeLayout(false);
            tblFindText.PerformLayout();
            tblProgressBar.ResumeLayout(false);
            tblProgressBar.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer1;
        private Patagames.Pdf.Net.Controls.WinForms.BookmarksViewer bookmarksViewer1;
        private Patagames.Pdf.Net.Controls.WinForms.PdfViewer pdfViewer1;
        private Button btnCloseBookmarks;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem copyAsGrayScaleToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnOpenPDF;
        private TableLayoutPanel tblFindText;
        private CheckBox chkMatchCase;
        private Button btnFind;
        private TextBox txtFind;
        private Button btnCloseFind;
        private Button btnDarkMode;
        private TableLayoutPanel tblProgressBar;
        private Label lblPleaseWait;
        private ProgressBar prgSearch;
        private Button btnOpenFindTbl;
        private ToolTip toolTip1;
        private Button btnFitToScreen;
    }
}
