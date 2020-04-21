namespace MR_PDF_Tools
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAddJPG = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.FileList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.ckFolder = new System.Windows.Forms.CheckBox();
            this.btnJpgToPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddJPG
            // 
            this.btnAddJPG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddJPG.Location = new System.Drawing.Point(8, 446);
            this.btnAddJPG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddJPG.Name = "btnAddJPG";
            this.btnAddJPG.Size = new System.Drawing.Size(112, 39);
            this.btnAddJPG.TabIndex = 3;
            this.btnAddJPG.Text = "Add PDF";
            this.btnAddJPG.UseVisualStyleBackColor = true;
            this.btnAddJPG.Click += new System.EventHandler(this.btnAddPDF_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveUp.Location = new System.Drawing.Point(772, 9);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(43, 39);
            this.btnMoveUp.TabIndex = 5;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Location = new System.Drawing.Point(772, 395);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(43, 39);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "Mode Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(140, 446);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 39);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove From List";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // FileList
            // 
            this.FileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.FileList.FullRowSelect = true;
            this.FileList.GridLines = true;
            this.FileList.HideSelection = false;
            this.FileList.Location = new System.Drawing.Point(8, 7);
            this.FileList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FileList.MultiSelect = false;
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(760, 429);
            this.FileList.TabIndex = 12;
            this.FileList.UseCompatibleStateImageBehavior = false;
            this.FileList.View = System.Windows.Forms.View.Details;
            this.FileList.SelectedIndexChanged += new System.EventHandler(this.FileList_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FileName";
            this.columnHeader1.Width = 944;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveAll.Location = new System.Drawing.Point(287, 446);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(112, 39);
            this.btnRemoveAll.TabIndex = 13;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // ckFolder
            // 
            this.ckFolder.AutoSize = true;
            this.ckFolder.Checked = true;
            this.ckFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckFolder.Location = new System.Drawing.Point(459, 446);
            this.ckFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckFolder.Name = "ckFolder";
            this.ckFolder.Size = new System.Drawing.Size(136, 17);
            this.ckFolder.TabIndex = 15;
            this.ckFolder.Text = "Open Folder after Save";
            this.ckFolder.UseVisualStyleBackColor = true;
            // 
            // btnJpgToPDF
            // 
            this.btnJpgToPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJpgToPDF.Image = global::MR_Split_and_Merge_PDF.Properties.Resources.PDF_Save_24_x24;
            this.btnJpgToPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJpgToPDF.Location = new System.Drawing.Point(614, 446);
            this.btnJpgToPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnJpgToPDF.Name = "btnJpgToPDF";
            this.btnJpgToPDF.Size = new System.Drawing.Size(154, 39);
            this.btnJpgToPDF.TabIndex = 0;
            this.btnJpgToPDF.Text = "Merge and Create PDF";
            this.btnJpgToPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJpgToPDF.UseVisualStyleBackColor = true;
            this.btnJpgToPDF.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 497);
            this.Controls.Add(this.ckFolder);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnAddJPG);
            this.Controls.Add(this.btnJpgToPDF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(840, 535);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge PDF ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJpgToPDF;
        private System.Windows.Forms.Button btnAddJPG;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListView FileList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.CheckBox ckFolder;
    }
}