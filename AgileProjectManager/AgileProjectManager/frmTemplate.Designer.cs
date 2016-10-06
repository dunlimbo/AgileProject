namespace AgileProjectManager
{
    partial class frmTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemplate));
            this.stWindowInfo = new System.Windows.Forms.StatusStrip();
            this.statlblLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.statlblUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.stWindowInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // stWindowInfo
            // 
            this.stWindowInfo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stWindowInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statlblLogin,
            this.statlblUsername});
            this.stWindowInfo.Location = new System.Drawing.Point(0, 547);
            this.stWindowInfo.Name = "stWindowInfo";
            this.stWindowInfo.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.stWindowInfo.Size = new System.Drawing.Size(1256, 22);
            this.stWindowInfo.TabIndex = 0;
            this.stWindowInfo.Text = "statusStrip1";
            // 
            // statlblLogin
            // 
            this.statlblLogin.Name = "statlblLogin";
            this.statlblLogin.Size = new System.Drawing.Size(84, 17);
            this.statlblLogin.Text = "Current User:";
            // 
            // statlblUsername
            // 
            this.statlblUsername.Name = "statlblUsername";
            this.statlblUsername.Size = new System.Drawing.Size(0, 17);
            // 
            // frmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 569);
            this.Controls.Add(this.stWindowInfo);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTemplate";
            this.Text = "Waterfall Systems: Project Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.stWindowInfo.ResumeLayout(false);
            this.stWindowInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stWindowInfo;
        private System.Windows.Forms.ToolStripStatusLabel statlblLogin;
        private System.Windows.Forms.ToolStripStatusLabel statlblUsername;
    }
}

