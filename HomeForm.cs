using MR_PDF_Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MR_Split_and_Merge_PDF
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            var f1 = new MainForm();
            f1.ShowDialog(this);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            var f1 = new SplitForm();
            f1.ShowDialog(this);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/maurorilla/MR Split and Merge PDF");
            Process.Start(sInfo);
        }
    }
}
