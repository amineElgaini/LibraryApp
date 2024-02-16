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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrUserInfo1
            // 
            this.ctrUserInfo1.Location = new System.Drawing.Point(0, 67);
            this.ctrUserInfo1.Name = "ctrUserInfo1";
            this.ctrUserInfo1.Size = new System.Drawing.Size(445, 209);
            this.ctrUserInfo1.TabIndex = 12;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(155, 36);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSearchValue
            // 
            this.textBoxSearchValue.Location = new System.Drawing.Point(49, 36);
            this.textBoxSearchValue.Name = "textBoxSearchValue";
            this.textBoxSearchValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchValue.TabIndex = 14;
            this.textBoxSearchValue.TextChanged += new System.EventHandler(this.textBoxSearchValue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID:";
            // 
            // ctrUserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearchValue);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.ctrUserInfo1);
            this.Name = "ctrUserSearch";
            this.Size = new System.Drawing.Size(480, 280);
            this.Load += new System.EventHandler(this.ctrUserSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ctrUserInfo ctrUserInfo1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchValue;
        private System.Windows.Forms.Label label1;
    }
}
