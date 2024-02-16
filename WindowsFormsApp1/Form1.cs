using ClassLibrary1;
using LibraryBusinessLayer;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool isChanged = false;

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
        
        private void _ReloadBorrowing()
        {

            dataGridViewBorrowing.DataSource = clsBorrow.FetchBorrowing();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _ReloadUsers();
            _ReloadBooks();
            _ReloadBorrowing();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUser = new AddUserForm();
            addUser.DataBack += isChangedToTrue;
            addUser.ShowDialog();

            if (isChanged)
            {
                MessageBox.Show("User Is Added Successfully");
                _ReloadUsers();
                isChanged = false;
            }
            else
            {
                MessageBox.Show("No User Is Added");
            }

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserForm addUser = new AddUserForm((int)dataGridViewUsers.CurrentRow.Cells[0].Value);

            addUser.DataBack += isChangedToTrue;
            addUser.ShowDialog();

            if (isChanged)
            {
                MessageBox.Show("User Is Updated Successfully");
                _ReloadUsers();
                isChanged = false;
            }
            else
            {
                MessageBox.Show("User Is Not Updated");
            }

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            //clsBooks.AddBook().ToString();

            AddBookForm addBook = new AddBookForm();
            addBook.DataBack += isChangedToTrue;
            addBook.ShowDialog();

            if (isChanged)
            {
                MessageBox.Show("Book Is Added Successfully");
                _ReloadBooks();
                isChanged = false;
            }
            else
            {
                MessageBox.Show("Book Is Not Added");
            }
        }

        private void isChangedToTrue(object sender)
        {
            this.isChanged = true;
        }

        private void detailInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo((int)dataGridViewUsers.CurrentRow.Cells[0].Value);
            userInfo.ShowDialog();
        }

        private void tabUsers_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are You Sure?", "Make Sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                &&
                clsUsers.DeleteUser((int)dataGridViewUsers.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("User Is Deleted");
                _ReloadUsers();
            }
            else
            {
                MessageBox.Show("User Is Not Deleted");

            }
        }

        private void tabBooks_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are You Sure?", "Make Sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK) && clsBooks.DeleteBook((int)dataGridViewBooks.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Book Is Deleted");
                _ReloadBooks();
            }
            else
            {
                MessageBox.Show("Book Is Not Deleted");
            }
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm((int)dataGridViewBooks.CurrentRow.Cells[0].Value);
            borrowForm.Show();
            _ReloadBooks();
            _ReloadBorrowing();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void buttonUserSearch_Click(object sender, EventArgs e)
        {
            string search = comboBoxUserSearch.Text.ToString();
            string value = textBoxUserSearch.Text.ToString();

            if (search == "All")
            {
                _ReloadUsers();
            }
            else if (search == "Name")
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    dataGridViewUsers.DataSource = clsUsers.FindUsersByName(value);
                } else
                {
                    MessageBox.Show("Field Can't Be Empty");
                }
            } else if (search == "Id")
            {
                if (int.TryParse(value, out int id)) {
                    dataGridViewUsers.DataSource = clsUsers.FindUsersById(id);
                } else
                {
                    MessageBox.Show("Field Should Be A Number");
                }
            }
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Did He Paid?", "Make Sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK))
            {
                if (clsBorrow.Pay((int)dataGridViewBorrowing.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("The Payment Received Successfully");
                }
            }
        }

        private void tabBorrowing_Click(object sender, EventArgs e)
        {

        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Did He Really Returned The Book?", "Make Sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK))
            {
                if (clsBorrow.Return((int)dataGridViewBorrowing.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("The Returnement Received Successfully");
                }
            }
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
