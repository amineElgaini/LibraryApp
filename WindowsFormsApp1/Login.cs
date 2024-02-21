using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public delegate void DataBackEventHandler(object sender, bool isLoged);
        public event DataBackEventHandler DataBack;

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            int id = clsLogin.Login(userName, password);
            if (id > 0)
            {
                DataBack?.Invoke(this, true);
                string path = @"C:\Users\Amine ELGAINI\Desktop\login\login.txt";

                if (File.Exists(path))
                {
                    string createText = id.ToString() + Environment.NewLine;
                    File.WriteAllText(path, createText);
                }
                this.Close();
            }
            else
            {
                DataBack?.Invoke(this, false);
                this.Close();
            }
        }
    }
}
