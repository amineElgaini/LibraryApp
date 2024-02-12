using LibraryBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        enum Mode {edit, add};
        Mode mode;

        int userId = -1;
        clsUsers User;

        public Form2(int id = -1)
        {
            InitializeComponent();

            if (id == -1)
            {
                mode = Mode.add;
                return;
            }

            mode = Mode.edit;
            userId = id;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (mode == Mode.add)
                User = new clsUsers();
            else
            {
                clsUsers User = clsUsers.FindUserById(userId);

                if (User == null)
                {
                    this.Close();
                    return;
                }

                textBoxName.Text = User.Name;
                textBoxEmail.Text = User.Email;
                pictureBoxUserImage.ImageLocation = User.Image;
                dateTimePickerBirthDate.Value = User.BirthDate;
            }

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User.Name = textBoxName.Text;
            User.Email = textBoxEmail.Text;
            if (pictureBoxUserImage.ImageLocation == null)
                User.Image = "";
            else
                User.Image = pictureBoxUserImage.ImageLocation;

            User.BirthDate = dateTimePickerBirthDate.Value;

            MessageBox.Show(User.BirthDate.ToString());

            if (User.Save()) {
                MessageBox.Show("User Added Successful");
            } else
            {
                MessageBox.Show("User Is Not Added Successful");
            }
            this.Close();
        }

        private void pictureBoxUserImage_Click(object sender, EventArgs e)
        {
        }

        private void linkLabelRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBoxUserImage.ImageLocation = null;
            linkLabelRemoveImage.Visible = false;
        }

        private void linkLabelAddImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;

                pictureBoxUserImage.ImageLocation = selectedFilePath;
                linkLabelRemoveImage.Visible = true;
                //pictureBoxUserImage.Load(selectedFilePath);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
       
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
