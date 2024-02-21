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
            this.textBoxNumberOfDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrUserSearch1 = new WindowsFormsApp1.ctrUserSearch();
            this.SuspendLayout();
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Location = new System.Drawing.Point(229, 262);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrow.TabIndex = 18;
            this.buttonBorrow.Text = "Borrow";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // textBoxNumberOfDays
            // 
            this.textBoxNumberOfDays.Location = new System.Drawing.Point(113, 263);
            this.textBoxNumberOfDays.Name = "textBoxNumberOfDays";
            this.textBoxNumberOfDays.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfDays.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Number Of Days";
            // 
            // ctrUserSearch1
            // 
            this.ctrUserSearch1.Location = new System.Drawing.Point(1, 0);
            this.ctrUserSearch1.Name = "ctrUserSearch1";
            this.ctrUserSearch1.Size = new System.Drawing.Size(431, 257);
            this.ctrUserSearch1.TabIndex = 0;
            this.ctrUserSearch1.OnUserSelected += new System.Action<int>(this.ctrUserSearch1_OnUserSelected_1);
            this.ctrUserSearch1.Load += new System.EventHandler(this.ctrUserSearch1_Load);
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 300);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}