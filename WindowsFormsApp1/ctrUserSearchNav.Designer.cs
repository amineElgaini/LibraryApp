namespace WindowsFormsApp1
{
    partial class ctrUserSearchNav
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
            this.buttonUserSearch = new System.Windows.Forms.Button();
            this.textBoxUserSearch = new System.Windows.Forms.TextBox();
            this.comboBoxUserSearch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonUserSearch
            // 
            this.buttonUserSearch.Location = new System.Drawing.Point(256, 22);
            this.buttonUserSearch.Name = "buttonUserSearch";
            this.buttonUserSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonUserSearch.TabIndex = 14;
            this.buttonUserSearch.Text = "Search";
            this.buttonUserSearch.UseVisualStyleBackColor = true;
            this.buttonUserSearch.Click += new System.EventHandler(this.buttonUserSearch_Click);
            // 
            // textBoxUserSearch
            // 
            this.textBoxUserSearch.Location = new System.Drawing.Point(150, 23);
            this.textBoxUserSearch.Name = "textBoxUserSearch";
            this.textBoxUserSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserSearch.TabIndex = 13;
            // 
            // comboBoxUserSearch
            // 
            this.comboBoxUserSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserSearch.FormattingEnabled = true;
            this.comboBoxUserSearch.Items.AddRange(new object[] {
            "All",
            "Id",
            "Name"});
            this.comboBoxUserSearch.Location = new System.Drawing.Point(12, 23);
            this.comboBoxUserSearch.Name = "comboBoxUserSearch";
            this.comboBoxUserSearch.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUserSearch.TabIndex = 12;
            // 
            // ctrUserSearchNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUserSearch);
            this.Controls.Add(this.textBoxUserSearch);
            this.Controls.Add(this.comboBoxUserSearch);
            this.Name = "ctrUserSearchNav";
            this.Size = new System.Drawing.Size(347, 66);
            this.Load += new System.EventHandler(this.ctrUserSearchNav_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUserSearch;
        private System.Windows.Forms.TextBox textBoxUserSearch;
        private System.Windows.Forms.ComboBox comboBoxUserSearch;
    }
}
