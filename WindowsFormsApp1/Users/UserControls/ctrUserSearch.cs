using LibraryBusinessLayer;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ctrUserSearch : UserControl
    {
        public event Action<int> OnUserSelected;
        protected virtual void UserSelected(int UserId)
        {
            Action<int> handler = OnUserSelected;
            if (handler != null)
            {
                handler(UserId);
            }
        }

        public ctrUserSearch()
        {
            InitializeComponent();
        }

        private void ctrUserSearch_Load(object sender, EventArgs e)
        {

        }

        private void ctrUserSearchNav1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OnUserSelected != null && int.TryParse(textBoxSearchValue.Text, out int value))
            {
                if (ctrUserInfo1.LoadUserInfo(value))
                    UserSelected(value);
            }
        }

        private void textBoxSearchValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ctrUserInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
