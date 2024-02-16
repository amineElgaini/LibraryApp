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
        public int userId;
        public int bookId;
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
            userId = obj;
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(clsBorrow.Borrow(userId, bookId, ));
        }
    }
}
