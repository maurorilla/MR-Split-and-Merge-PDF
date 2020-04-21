using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MR_Split_and_Merge_PDF
{
    public partial class SplitForm : Form
    {
        bool cancelNow = false;

        public SplitForm()
        {
            InitializeComponent();
        }

        private void btnSelectPDF_Click(object sender, EventArgs e)
        {
            var OfD = new OpenFileDialog();
            OfD.Filter = "Images (*.pdf)|*.pdf";
            OfD.Multiselect = false;
            OfD.Title = "MR Split and Merge PDF - Select PDF to SPLIT";
            if (OfD.ShowDialog(this) == DialogResult.OK)
            {
                txtFile.Text = OfD.FileName;
                GetPages(txtFile.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txtFile.Text) == false)
            {
                MessageBox.Show("Error File", "MR Split and Merge PDF",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            var SFD = new FolderBrowserDialog();
            SFD.SelectedPath = Path.GetDirectoryName(txtFile.Text);
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                Split_Now(txtFile.Text, SFD.SelectedPath);
                Process.Start(Path.GetDirectoryName(SFD.SelectedPath));
            }
        }

         void GetPages(string myPDF)
        {
            lblPages.Text = "Pages : ";
            try
            {
                PdfReader reader = new PdfReader(myPDF);

                FileInfo file = new FileInfo(myPDF);
                string pdfFileName = file.Name.Substring(0, file.Name.LastIndexOf(".")) + "-";
                lblPages.Text = "Pages : " + reader.NumberOfPages;
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR Splitting File  :" + ex.Message);
            }
        }

         void Split_Now(string myPDF, string outputPath)
        {
            try
            {
                btnSelectPDF.Enabled = false;
                button1.Enabled = false;
                btnCancel.Enabled = true;
                int interval = 1;
                int pageNameSuffix = 0;
                cancelNow = false;
                // Intialize a new PdfReader instance with the contents of the source Pdf file:  
                PdfReader reader = new PdfReader(myPDF);

                FileInfo file = new FileInfo(myPDF);
                string pdfFileName = file.Name.Substring(0, file.Name.LastIndexOf(".")) + "-";

                pBar.Maximum = reader.NumberOfPages;
                for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber += interval)
                {
                    lblPages.Text = $"Splitting {pageNumber} / {pBar.Maximum} ";
                    pageNameSuffix++;
                    pBar.Value = pageNameSuffix;
                    string newPdfFileName = pdfFileName + pageNameSuffix;
                    SplitAndSavePages(myPDF, outputPath, pageNumber, interval, newPdfFileName);
                    Application.DoEvents();
                    Application.DoEvents();
                    if (cancelNow == true)
                    {
                        lblPages.Text = $"Splitting {pageNumber} / {pBar.Maximum} ... cancelled";
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR Splitting File  :" + ex.Message);
            }
            btnSelectPDF.Enabled = true;
            button1.Enabled = true;
            btnCancel.Enabled = false;
        }


         private void SplitAndSavePages(string pdfFilePath, string outputPath, int startPage, int interval, string pdfFileName)
        {
            using (PdfReader reader = new PdfReader(pdfFilePath))
            {
                Document document = new Document();
                PdfCopy copy = new PdfCopy(document, new FileStream(outputPath + "\\" + pdfFileName + ".pdf", FileMode.Create));
                document.Open();

                for (int pagenumber = startPage; pagenumber < (startPage + interval); pagenumber++)
                {
                    if (reader.NumberOfPages >= pagenumber)
                    {
                        copy.AddPage(copy.GetImportedPage(reader, pagenumber));
                    }
                    else
                    {
                        break;
                    }

                }

                document.Close();
            }
        }

        private void lblPages_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelNow = true;
        }
    }
}
