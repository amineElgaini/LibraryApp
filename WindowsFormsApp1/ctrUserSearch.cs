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
    public partial class ctrUserSearch : UserControl
    {
        public event Action<int> OnUserSelected;
        protected virtual void UserSelected(int UserId)

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

        }

        private void textBoxSearchValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
