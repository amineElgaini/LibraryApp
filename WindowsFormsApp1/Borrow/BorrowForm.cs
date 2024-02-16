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
        public BorrowForm(int bookId)
        {
            InitializeComponent();
            this.bookId = bookId;
        }

        private void BorrowFrom_Load(object sender, EventArgs e)
        {
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
            if (int.TryParse(textBoxNumberOfDays.Text, out int days))
            {
                DateTime StartDate = DateTime.Now;
                DateTime DueDate = StartDate.AddDays(days);
                if (userId == -1)
                    MessageBox.Show("User Not Found");

                if (bookId == -1)
                    MessageBox.Show("Book Not Found");

                if (!clsBorrow.IsAvailable(bookId))
                    MessageBox.Show("Book Is Not Available");

                if (clsBorrow.Borrow(userId, bookId, StartDate, DueDate))
                    MessageBox.Show("The User Did Borrow The Book");
                else
                    MessageBox.Show("The User Didn't Borrow The Book");
            }
        }
    }
}
