namespace WindowsFormsApp1
{
    partial class ctrUserSearch
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
            this.ctrUserInfo1 = new WindowsFormsApp1.ctrUserInfo();
            this.ctrUserSearchNav1 = new WindowsFormsApp1.ctrUserSearchNav();
            this.SuspendLayout();
            // 
            // ctrUserInfo1
            // 
            this.ctrUserInfo1.Location = new System.Drawing.Point(3, 75);
            this.ctrUserInfo1.Name = "ctrUserInfo1";
            this.ctrUserInfo1.Size = new System.Drawing.Size(445, 209);
            this.ctrUserInfo1.TabIndex = 12;
            this.ctrUserInfo1.Load += new System.EventHandler(this.ctrUserInfo1_Load);
            // 
            // ctrUserSearchNav1
            // 
            this.ctrUserSearchNav1.Location = new System.Drawing.Point(3, 3);
            this.ctrUserSearchNav1.Name = "ctrUserSearchNav1";
            this.ctrUserSearchNav1.Size = new System.Drawing.Size(347, 66);
            this.ctrUserSearchNav1.TabIndex = 13;
            this.ctrUserSearchNav1.Load += new System.EventHandler(this.ctrUserSearchNav1_Load);
            // 
            // ctrUserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrUserSearchNav1);
            this.Controls.Add(this.ctrUserInfo1);
            this.Name = "ctrUserSearch";
            this.Size = new System.Drawing.Size(435, 276);
            this.Load += new System.EventHandler(this.ctrUserSearch_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ctrUserInfo ctrUserInfo1;
        private ctrUserSearchNav ctrUserSearchNav1;
    }
}
