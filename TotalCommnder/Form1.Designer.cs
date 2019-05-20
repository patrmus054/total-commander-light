namespace TotalCommnder
{
    partial class Form1
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btCopy = new System.Windows.Forms.Button();
            this.btMove = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btNewFolder = new System.Windows.Forms.Button();
            this.tcPanel2 = new TotalCommnder.TCPanel();
            this.tcPanel1 = new TotalCommnder.TCPanel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btCopy
            // 
            this.btCopy.Location = new System.Drawing.Point(12, 477);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(218, 43);
            this.btCopy.TabIndex = 2;
            this.btCopy.Text = "Kopiuj";
            this.btCopy.UseVisualStyleBackColor = true;
            this.btCopy.Click += new System.EventHandler(this.BtCopy_Click);
            // 
            // btMove
            // 
            this.btMove.Location = new System.Drawing.Point(236, 476);
            this.btMove.Name = "btMove";
            this.btMove.Size = new System.Drawing.Size(212, 43);
            this.btMove.TabIndex = 3;
            this.btMove.Text = "Przenieś";
            this.btMove.UseVisualStyleBackColor = true;
            this.btMove.Click += new System.EventHandler(this.BtMove_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(454, 476);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(222, 43);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Usuń";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // btNewFolder
            // 
            this.btNewFolder.Location = new System.Drawing.Point(682, 477);
            this.btNewFolder.Name = "btNewFolder";
            this.btNewFolder.Size = new System.Drawing.Size(208, 43);
            this.btNewFolder.TabIndex = 5;
            this.btNewFolder.Text = "Nowy Folder";
            this.btNewFolder.UseVisualStyleBackColor = true;
            this.btNewFolder.Click += new System.EventHandler(this.BtNewFolder_Click);
            // 
            // tcPanel2
            // 
            this.tcPanel2.CurrentPath = "";
            this.tcPanel2.Drives = null;
            this.tcPanel2.Location = new System.Drawing.Point(454, 12);
            this.tcPanel2.Name = "tcPanel2";
            this.tcPanel2.Size = new System.Drawing.Size(436, 458);
            this.tcPanel2.TabIndex = 1;
            // 
            // tcPanel1
            // 
            this.tcPanel1.CurrentPath = "";
            this.tcPanel1.Drives = null;
            this.tcPanel1.Location = new System.Drawing.Point(12, 12);
            this.tcPanel1.Name = "tcPanel1";
            this.tcPanel1.Size = new System.Drawing.Size(436, 458);
            this.tcPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(902, 532);
            this.Controls.Add(this.btNewFolder);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btMove);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.tcPanel2);
            this.Controls.Add(this.tcPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private TCPanel tcPanel1;
        private TCPanel tcPanel2;
        private System.Windows.Forms.Button btNewFolder;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btMove;
        private System.Windows.Forms.Button btCopy;
    }
}

