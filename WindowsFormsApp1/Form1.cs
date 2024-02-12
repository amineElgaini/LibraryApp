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

        private void _ReloadUsers()
        {

            dataGridViewUsers.DataSource = clsUsers.GetAllUsers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _ReloadUsers();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form addUser = new Form2();
            addUser.ShowDialog();
            _ReloadUsers();
        }

        private void tabUsers_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addUser = new Form2((int)dataGridViewUsers.CurrentRow.Cells[0].Value);
            addUser.ShowDialog();
            _ReloadUsers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
