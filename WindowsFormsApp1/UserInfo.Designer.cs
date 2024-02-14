namespace WindowsFormsApp1
{
    partial class UserInfo
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ctrUserInfo1 = new WindowsFormsApp1.CtrlUserInfo();
            this.SuspendLayout();
            // 
            // ctrUserInfo1
            // 
            this.ctrUserInfo1.Location = new System.Drawing.Point(12, 90);
            this.ctrUserInfo1.Name = "ctrUserInfo1";
            this.ctrUserInfo1.Size = new System.Drawing.Size(253, 164);
            this.ctrUserInfo1.TabIndex = 0;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrUserInfo1);
            this.Name = "UserInfo";
            this.Text = "UserInfo";
            this.Load += new System.EventHandler(this.UserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CtrlUserInfo ctrUserInfo1;
    }
}