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

        public void LoadUserInfo(int id)
        {
            clsUsers user = clsUsers.GetUserByID(id);
            if (user != null)
            {
                labelUserId.Text = user.UserId.ToString();
                labelName.Text = user.Name;
                pictureBoxUserImage.ImageLocation = user.Image;

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }
    }
}
