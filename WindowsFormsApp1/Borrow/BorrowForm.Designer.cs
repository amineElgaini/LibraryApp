namespace WindowsFormsApp1
{
    partial class BorrowForm
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
            this.ctrUserSearch1 = new WindowsFormsApp1.ctrUserSearch();
            this.SuspendLayout();
            // 
            // ctrUserSearch1
            // 
            this.ctrUserSearch1.Location = new System.Drawing.Point(12, 12);
            this.ctrUserSearch1.Name = "ctrUserSearch1";
            this.ctrUserSearch1.Size = new System.Drawing.Size(502, 314);
            this.ctrUserSearch1.TabIndex = 0;
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrUserSearch1);
            this.Name = "BorrowForm";
            this.Text = "BorrowFrom";
            this.Load += new System.EventHandler(this.BorrowFrom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrUserSearch ctrUserSearch1;
    }
}