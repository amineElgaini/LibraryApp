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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.ctrUserSearch1 = new WindowsFormsApp1.ctrUserSearch();
            this.textBoxNumberOfDays = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Location = new System.Drawing.Point(328, 286);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrow.TabIndex = 18;
            this.buttonBorrow.Text = "Borrow";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // ctrUserSearch1
            // 
            this.ctrUserSearch1.Location = new System.Drawing.Point(1, 0);
            this.ctrUserSearch1.Name = "ctrUserSearch1";
            this.ctrUserSearch1.Size = new System.Drawing.Size(480, 280);
            this.ctrUserSearch1.TabIndex = 0;
            this.ctrUserSearch1.OnUserSelected += new System.Action<int>(this.ctrUserSearch1_OnUserSelected_1);
            // 
            // textBoxNumberOfDays
            // 
            this.textBoxNumberOfDays.Location = new System.Drawing.Point(23, 286);
            this.textBoxNumberOfDays.Name = "textBoxNumberOfDays";
            this.textBoxNumberOfDays.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfDays.TabIndex = 19;
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 511);
            this.Controls.Add(this.textBoxNumberOfDays);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.ctrUserSearch1);
            this.Name = "BorrowForm";
            this.Text = "BorrowFrom";
            this.Load += new System.EventHandler(this.BorrowFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private ctrUserSearch ctrUserSearch1;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.TextBox textBoxNumberOfDays;
    }
}