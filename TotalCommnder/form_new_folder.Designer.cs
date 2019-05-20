namespace TotalCommnder
{
    partial class form_new_folder
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
            this.tbNewFolderName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDestinationPath = new System.Windows.Forms.ComboBox();
            this.btCommitFormNewFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNewFolderName
            // 
            this.tbNewFolderName.Location = new System.Drawing.Point(12, 54);
            this.tbNewFolderName.Name = "tbNewFolderName";
            this.tbNewFolderName.Size = new System.Drawing.Size(458, 22);
            this.tbNewFolderName.TabIndex = 0;
            this.tbNewFolderName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base Path:";
            // 
            // cbDestinationPath
            // 
            this.cbDestinationPath.FormattingEnabled = true;
            this.cbDestinationPath.Location = new System.Drawing.Point(12, 134);
            this.cbDestinationPath.Name = "cbDestinationPath";
            this.cbDestinationPath.Size = new System.Drawing.Size(458, 24);
            this.cbDestinationPath.TabIndex = 3;
            // 
            // btCommitFormNewFolder
            // 
            this.btCommitFormNewFolder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btCommitFormNewFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btCommitFormNewFolder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCommitFormNewFolder.Location = new System.Drawing.Point(365, 178);
            this.btCommitFormNewFolder.Name = "btCommitFormNewFolder";
            this.btCommitFormNewFolder.Size = new System.Drawing.Size(105, 63);
            this.btCommitFormNewFolder.TabIndex = 5;
            this.btCommitFormNewFolder.Text = "Commit";
            this.btCommitFormNewFolder.UseVisualStyleBackColor = false;
            this.btCommitFormNewFolder.Click += new System.EventHandler(this.Button2_Click);
            // 
            // form_new_folder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.btCommitFormNewFolder);
            this.Controls.Add(this.cbDestinationPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNewFolderName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_new_folder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewFolderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDestinationPath;
        private System.Windows.Forms.Button btCommitFormNewFolder;
    }
}