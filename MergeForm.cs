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
    public partial class MergeForm : Form
    {
        public MergeForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (FileList.Items.Count == 0)
            {
                MessageBox.Show("Add PDF to generate the pdf file.", "MR Split and Merge PDF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var SFD = new SaveFileDialog();
            SFD.FileName = $"PDF_{DateTime.Now:dd_MM_yyyy_HHmmss}.pdf";
            SFD.Filter = "File PDF|*.PDF";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                var myPath = Path.GetTempPath() + "\\MR Split and Merge PDF\\";
                if (!Directory.Exists(myPath)) Directory.CreateDirectory(myPath);
                //Creo una cartella
                myPath = $"{myPath}{DateTime.Now.ToString("yyyyMMddHHmmss")}\\";
                if (!Directory.Exists(myPath)) Directory.CreateDirectory(myPath);

                //Copio i file e li ridimensione
                var i = 1;
                var MyList = new List<string>();
                foreach (ListViewItem l1 in FileList.Items)
                {
                    var CurrentFile = l1.Text;
                    /* var NewFile = myPath + "Pag_" + i + Path.GetExtension(CurrentFile);
                     File.Copy(CurrentFile, NewFile);
                     var NewFilePDF = NewFile + ".pdf";
                     ConvertJPG2PDF(NewFile, NewFilePDF);
                     File.Delete(NewFile);*/
                    i++;
                    MyList.Add(CurrentFile);
                }

                MergeFiles(SFD.FileName, MyList.ToArray());
                if (ckFolder.Checked) Process.Start(Path.GetDirectoryName(SFD.FileName));
            }
        }

        public static void MergeFiles(string outputfile, string[] sourceFiles)
        {

            try
            {
                int f = 0;
                PdfReader myReader = new PdfReader(sourceFiles[f]);
                int n = myReader.NumberOfPages;
                Document myDoc = new Document(myReader.GetPageSizeWithRotation(1));
                PdfWriter myWriter = PdfWriter.GetInstance(myDoc, new FileStream(outputfile, FileMode.Create));
                myDoc.Open();
                PdfContentByte cb = myWriter.DirectContent;
                PdfImportedPage page;
                int rotation;
                while (f < sourceFiles.Length)
                {
                    int i = 0;
                    while (i < n)
                    {
                        i++;
                        myDoc.SetPageSize(myReader.GetPageSizeWithRotation(i));
                        myDoc.NewPage();
                        page = myWriter.GetImportedPage(myReader, i);
                        rotation = myReader.GetPageRotation(i);
                        if (rotation == 90 || rotation == 270)
                        {
                            cb.AddTemplate(page, 0, -1f, 1f, 0, 0, myReader.GetPageSizeWithRotation(i).Height);
                        }
                        else
                        {
                            cb.AddTemplate(page, 1f, 0, 0, 1f, 0, 0);
                        }
                    }
                    f++;
                    if (f < sourceFiles.Length)
                    {
                        myReader = new PdfReader(sourceFiles[f]);
                        n = myReader.NumberOfPages;
                    }
                }
                myDoc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR MergeFiles : " + ex.Message, "MR Split and Merge PDF", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public static int CountPageNo(string strFileName)
        {
            PdfReader reader = new PdfReader(strFileName);
            return reader.NumberOfPages;
        }


        public static string GetAppPath()
        {
            return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }
       
        private void btnAddPDF_Click(object sender, EventArgs e)
        {
            var OfD = new OpenFileDialog();
            OfD.Filter = "Images (*.pdf)|*.pdf";
            OfD.Multiselect = true;
            OfD.Title = "MR Split and Merge PDF - Select PDF to Merge";
            if (OfD.ShowDialog(this) == DialogResult.OK)
            {
                foreach (var f1 in OfD.FileNames)
                {
                    FileList.Items.Add(f1);
                }
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            //FileList
            if (FileList.SelectedItems.Count > 0)
            {
                if (FileList.SelectedItems[0].Index > 0)
                {
                    var i = FileList.SelectedItems[0].Index;
                    var FF = FileList.Items[i - 1].Text;
                    var F2 = FileList.Items[i].Text;

                    FileList.Items[i - 1].Text = F2;
                    FileList.Items[i].Text = FF;

                    FileList.SelectedItems.Clear();
                    FileList.Items[i - 1].Focused = true;
                    FileList.Items[i - 1].Selected = true;
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            //FileList
            if (FileList.SelectedItems.Count > 0)
            {
                var i = FileList.SelectedItems[0].Index;
                if (i < FileList.Items.Count - 1)
                {

                    var FF = FileList.Items[i + 1].Text;
                    var F2 = FileList.Items[i].Text;

                    FileList.Items[i + 1].Text = F2;
                    FileList.Items[i].Text = FF;

                    FileList.SelectedItems.Clear();
                    FileList.Items[i + 1].Focused = true;
                    FileList.Items[i + 1].Selected = true;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (FileList.SelectedItems.Count > 0)
            {
                FileList.Items.RemoveAt(FileList.SelectedItems[0].Index);
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void FileList_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            FileList.Items.Clear();
        }
    }
}
