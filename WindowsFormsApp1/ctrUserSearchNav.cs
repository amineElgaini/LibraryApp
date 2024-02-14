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
    public partial class ctrUserSearchNav : UserControl
    {
        public delegate void DataBackEventHandler(object sender);
        public event DataBackEventHandler DataBack;

        public string comboBoxUserSearchValue;
         public string textBoxUserSearchValue;

        public ctrUserSearchNav()
        {
            InitializeComponent();
        }

        private void ctrUserSearchNav_Load(object sender, EventArgs e)
        {

        }

        private void buttonUserSearch_Click(object sender, EventArgs e)
        {
            this.comboBoxUserSearchValue = comboBoxUserSearch.Text.ToString();
            this.textBoxUserSearchValue = textBoxUserSearch.Text.ToString();
        }
    }
}
