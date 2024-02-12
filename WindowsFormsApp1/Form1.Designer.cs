namespace WindowsFormsApp1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.tabBorrowing = new System.Windows.Forms.TabPage();
            this.dataGridViewBorrowing = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.tabBorrowing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowing)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Controls.Add(this.tabBooks);
            this.tabControl1.Controls.Add(this.tabBorrowing);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.btnAddUser);
            this.tabUsers.Controls.Add(this.dataGridViewUsers);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(792, 424);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            this.tabUsers.Click += new System.EventHandler(this.tabUsers_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToOrderColumns = true;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewUsers.Location = new System.Drawing.Point(3, 91);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(786, 330);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.dataGridViewBooks);
            this.tabBooks.Location = new System.Drawing.Point(4, 22);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(792, 424);
            this.tabBooks.TabIndex = 1;
            this.tabBooks.Text = "Books";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AllowUserToOrderColumns = true;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewBooks.Location = new System.Drawing.Point(3, 91);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.Size = new System.Drawing.Size(786, 330);
            this.dataGridViewBooks.TabIndex = 1;
            // 
            // tabBorrowing
            // 
            this.tabBorrowing.Controls.Add(this.dataGridViewBorrowing);
            this.tabBorrowing.Location = new System.Drawing.Point(4, 22);
            this.tabBorrowing.Name = "tabBorrowing";
            this.tabBorrowing.Size = new System.Drawing.Size(792, 424);
            this.tabBorrowing.TabIndex = 2;
            this.tabBorrowing.Text = "Borrowing";
            this.tabBorrowing.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBorrowing
            // 
            this.dataGridViewBorrowing.AllowUserToAddRows = false;
            this.dataGridViewBorrowing.AllowUserToDeleteRows = false;
            this.dataGridViewBorrowing.AllowUserToOrderColumns = true;
            this.dataGridViewBorrowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrowing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewBorrowing.Location = new System.Drawing.Point(0, 94);
            this.dataGridViewBorrowing.Name = "dataGridViewBorrowing";
            this.dataGridViewBorrowing.ReadOnly = true;
            this.dataGridViewBorrowing.Size = new System.Drawing.Size(792, 330);
            this.dataGridViewBorrowing.TabIndex = 2;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(8, 48);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(99, 37);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.tabBorrowing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.TabPage tabBorrowing;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.DataGridView dataGridViewBorrowing;
        private System.Windows.Forms.Button btnAddUser;
    }
}

