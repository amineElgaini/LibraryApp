using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using LibraryBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool UserIsAdded = false;
        bool UserIsUpdated = false;
        
        bool BookIsAdded = false;
        bool BookIsUpdated = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void _ReloadUsers()
        {

            dataGridViewUsers.DataSource = clsUsers.GetAllUsers();
        }

        private void _ReloadBooks()
        {

            dataGridViewBooks.DataSource = clsBooks.FetchBooks();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _ReloadUsers();
            _ReloadBooks();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUser = new AddUserForm();
            addUser.DataBack += ChangeUserToAdded;
            addUser.ShowDialog();

            if (UserIsAdded)
            {
                MessageBox.Show("User Is Added Successfully");
                UserIsAdded = false;
            } else
            {
                MessageBox.Show("No User Is Added");
            }

            _ReloadUsers();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserForm addUser = new AddUserForm((int)dataGridViewUsers.CurrentRow.Cells[0].Value);

            addUser.DataBack += ChangeUserToUpdated;
            addUser.ShowDialog();

            if (UserIsUpdated)
            {
                MessageBox.Show("User Is Updated Successfully");
                UserIsUpdated = false;
            }
            else
            {
                MessageBox.Show("User Is Not Updated");
            }

            _ReloadUsers();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            //clsBooks.AddBook().ToString();

            AddBookForm addBook = new AddBookForm();
            addBook.DataBack += ChangeBookToAdded;
            addBook.ShowDialog();

            if (BookIsAdded)
            {
                MessageBox.Show("Book Is Added Successfully");
                BookIsAdded = false;
            }
            else
            {
                MessageBox.Show("Book Is Not Added");
            }
        }

        private void ChangeUserToAdded(object sender)
        {
            this.UserIsAdded = true;
        }

        private void ChangeUserToUpdated(object sender)
        {
            this.UserIsUpdated = true;
        }
        private void ChangeBookToAdded(object sender)
        {
            this.BookIsAdded = true;
        }

        private void ChangeBookToUpdated(object sender)
        {
            this.BookIsUpdated = true;
        }

        private void detailInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabUsers_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are You Sure?", "Make Sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK) && clsUsers.DeleteUser((int)dataGridViewUsers.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("User Is Deleted");

            } else
            {
                MessageBox.Show("User Is Not Deleted");

            }
        }

        private void tabBooks_Click(object sender, EventArgs e)
        {

        }
    }
}
