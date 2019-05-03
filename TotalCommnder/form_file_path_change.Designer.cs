namespace TotalCommnder
{
    partial class form_file_path_change
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
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCommit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDestination
            // 
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(12, 30);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(419, 24);
            this.cbDestination.TabIndex = 0;
            this.cbDestination.SelectedIndexChanged += new System.EventHandler(this.CbDestination_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Move to";
            // 
            // btCommit
            // 
            this.btCommit.Location = new System.Drawing.Point(356, 61);
            this.btCommit.Name = "btCommit";
            this.btCommit.Size = new System.Drawing.Size(75, 23);
            this.btCommit.TabIndex = 2;
            this.btCommit.Text = "Commit";
            this.btCommit.UseVisualStyleBackColor = true;
            // 
            // form_file_path_change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 108);
            this.Controls.Add(this.btCommit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDestination);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_file_path_change";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCommit;
    }
}