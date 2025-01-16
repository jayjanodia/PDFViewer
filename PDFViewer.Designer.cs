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
            btnOpenPDF = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            splitContainer1 = new SplitContainer();
            bookmarksViewer1 = new Patagames.Pdf.Net.Controls.WinForms.BookmarksViewer(components);
            pdfViewer1 = new Patagames.Pdf.Net.Controls.WinForms.PdfViewer();
            btnCloseBookmarks = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpenPDF
            // 
            btnOpenPDF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenPDF.AutoSize = true;
            btnOpenPDF.Location = new Point(713, 3);
            btnOpenPDF.Name = "btnOpenPDF";
            btnOpenPDF.Size = new Size(84, 25);
            btnOpenPDF.TabIndex = 0;
            btnOpenPDF.Text = "Add PDF File";
            btnOpenPDF.UseVisualStyleBackColor = true;
            btnOpenPDF.Click += btnOpenPDF_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnOpenPDF, 1, 0);
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 1);
            tableLayoutPanel1.Controls.Add(btnCloseBookmarks, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            tableLayoutPanel1.SetColumnSpan(splitContainer1, 2);
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 34);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(bookmarksViewer1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pdfViewer1);
            splitContainer1.Size = new Size(794, 413);
            splitContainer1.SplitterDistance = 264;
            splitContainer1.TabIndex = 1;
            // 
            // bookmarksViewer1
            // 
            bookmarksViewer1.Dock = DockStyle.Fill;
            bookmarksViewer1.Location = new Point(0, 0);
            bookmarksViewer1.Name = "bookmarksViewer1";
            bookmarksViewer1.PdfViewer = pdfViewer1;
            bookmarksViewer1.Size = new Size(264, 413);
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
            pdfViewer1.Size = new Size(526, 413);
            pdfViewer1.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.FitToWidth;
            pdfViewer1.TabIndex = 0;
            pdfViewer1.TextSelectColor = Color.FromArgb(70, 70, 130, 180);
            pdfViewer1.TilesCount = 2;
            pdfViewer1.UseProgressiveRender = true;
            pdfViewer1.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical;
            pdfViewer1.Zoom = 1F;
            // 
            // btnCloseBookmarks
            // 
            btnCloseBookmarks.AutoSize = true;
            btnCloseBookmarks.Location = new Point(3, 3);
            btnCloseBookmarks.Name = "btnCloseBookmarks";
            btnCloseBookmarks.Size = new Size(128, 25);
            btnCloseBookmarks.TabIndex = 2;
            btnCloseBookmarks.Text = "Close Bookmarks tab";
            btnCloseBookmarks.UseVisualStyleBackColor = true;
            btnCloseBookmarks.Click += btnCloseBookmarks_Click;
            // 
            // PDFViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "PDFViewer";
            Text = "PDF Viewer";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenPDF;
        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer1;
        private Patagames.Pdf.Net.Controls.WinForms.BookmarksViewer bookmarksViewer1;
        private Patagames.Pdf.Net.Controls.WinForms.PdfViewer pdfViewer1;
        private Button btnCloseBookmarks;
    }
}
