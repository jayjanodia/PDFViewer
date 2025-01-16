namespace PDF_Viewer
{
    public partial class PDFViewer : Form
    {
        public PDFViewer()
        {
            InitializeComponent();
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
            splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
        }
    }
}
