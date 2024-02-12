using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryBusinessLayer;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = clsUsers.GetAllUsers();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form addUser = new Form2();
            addUser.ShowDialog();
        }

        private void tabUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
