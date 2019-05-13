namespace TotalCommnder
{
    partial class form_copy_item
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
            this.cbSourceFormCopy = new System.Windows.Forms.ComboBox();
            this.btCommitFormCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSourceFormCopy
            // 
            this.cbSourceFormCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbSourceFormCopy.FormattingEnabled = true;
            this.cbSourceFormCopy.Location = new System.Drawing.Point(44, 57);
            this.cbSourceFormCopy.Name = "cbSourceFormCopy";
            this.cbSourceFormCopy.Size = new System.Drawing.Size(453, 33);
            this.cbSourceFormCopy.TabIndex = 0;
            // 
            // btCommitFormCopy
            // 
            this.btCommitFormCopy.BackColor = System.Drawing.Color.DimGray;
            this.btCommitFormCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btCommitFormCopy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCommitFormCopy.Location = new System.Drawing.Point(389, 116);
            this.btCommitFormCopy.Name = "btCommitFormCopy";
            this.btCommitFormCopy.Size = new System.Drawing.Size(108, 56);
            this.btCommitFormCopy.TabIndex = 1;
            this.btCommitFormCopy.Text = "Commit";
            this.btCommitFormCopy.UseVisualStyleBackColor = false;
            this.btCommitFormCopy.Click += new System.EventHandler(this.bt_commit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(68, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pick source to copy";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // form_copy_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(542, 203);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCommitFormCopy);
            this.Controls.Add(this.cbSourceFormCopy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(560, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(518, 213);
            this.Name = "form_copy_item";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "form_copy_item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSourceFormCopy;
        private System.Windows.Forms.Button btCommitFormCopy;
        private System.Windows.Forms.Label label1;
    }
}