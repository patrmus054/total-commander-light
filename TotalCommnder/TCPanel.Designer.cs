namespace TotalCommnder
{
    partial class TCPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TCPanel));
            this.tvPath = new System.Windows.Forms.TextBox();
            this.cbDirveList = new System.Windows.Forms.ComboBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tvPath
            // 
            this.tvPath.Location = new System.Drawing.Point(21, 60);
            this.tvPath.Name = "tvPath";
            this.tvPath.Size = new System.Drawing.Size(401, 22);
            this.tvPath.TabIndex = 0;
            this.tvPath.TextChanged += new System.EventHandler(this.TvPath_TextChanged);
            // 
            // cbDirveList
            // 
            this.cbDirveList.FormattingEnabled = true;
            this.cbDirveList.Location = new System.Drawing.Point(21, 30);
            this.cbDirveList.Name = "cbDirveList";
            this.cbDirveList.Size = new System.Drawing.Size(121, 24);
            this.cbDirveList.TabIndex = 1;
            this.cbDirveList.SelectedIndexChanged += new System.EventHandler(this.CbDirveList_SelectedIndexChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(21, 90);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(401, 356);
            this.listBox.TabIndex = 3;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // TCPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.cbDirveList);
            this.Controls.Add(this.tvPath);
            this.Name = "TCPanel";
            this.Size = new System.Drawing.Size(436, 465);
            this.Load += new System.EventHandler(this.TCPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tvPath;
        private System.Windows.Forms.ComboBox cbDirveList;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
