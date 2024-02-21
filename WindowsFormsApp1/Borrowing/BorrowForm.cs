using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BorrowForm : Form
    {
        public int userId = -1;
        public int bookId = -1;
        private BorrowForm()
        {

        }
        public BorrowForm(int bookId)
        {
            InitializeComponent();
            this.bookId = bookId;
        }

        private void BorrowFrom_Load(object sender, EventArgs e)
        {
            if (!clsBorrow.IsAvailable(bookId))
            {
                this.Close();
                MessageBox.Show("Book Is Not Available");
            }

        }

        private void ctrUserSearch1_OnUserSelected(int obj)
        {

        }

        private void ctrUserSearch1_OnUserSelected_1(int obj)
        {
            this.userId = obj;
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            if (userId == -1) { 
                MessageBox.Show("User Not Found");
            }else if (!int.TryParse(textBoxNumberOfDays.Text, out int days)) { 
                MessageBox.Show("Please Enter A Valide Number For Borrowing Days");
            } else
            {
                DateTime StartDate = DateTime.Now;
                DateTime DueDate = StartDate.AddDays(days);

                if (clsBorrow.Borrow(userId, bookId, StartDate, DueDate))
                    MessageBox.Show("The User Did Borrow The Book");
                else
                    MessageBox.Show("The User Didn't Borrow The Book");
                this.Close();
            }
        }

        private void ctrUserSearch1_Load(object sender, EventArgs e)
        {

        }
    }
}
