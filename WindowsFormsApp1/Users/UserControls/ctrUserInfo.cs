using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryBusinessLayer;


namespace WindowsFormsApp1
{
    public partial class ctrUserInfo : UserControl
    {

        public ctrUserInfo()
        {
            InitializeComponent();
        }

        private void ctrUserInfo_Load(object sender, EventArgs e)
        {

        }

        public bool LoadUserInfo(int id)
        {
            clsUsers user = clsUsers.GetUserByID(id);
            if (user != null)
            {
                labelUserId.Text = user.UserId.ToString();
                labelName.Text = user.Name;
                labelLibraryCardNumber.Text = user.LibraryCardNumber;
                pictureBoxUserImage.ImageLocation = user.Image;
                return true;
            } else
            {
                MessageBox.Show("User Is Not Found");
            }
            return false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
