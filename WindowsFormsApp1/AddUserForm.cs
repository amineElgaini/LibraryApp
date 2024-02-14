using LibraryBusinessLayer;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddUserForm : Form
    {

        public delegate void DataBackEventHandler(object sender);
        public event DataBackEventHandler DataBack;

        enum Mode { edit, add };
        Mode mode;

        int userId = -1;
        clsUsers User;


        public AddUserForm(int id = -1)
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
                User = clsUsers.FindUserById(userId);

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


            if (User.Save())
            {
                if (mode == Mode.add)
                {
                    DataBack?.Invoke(this);
                }
                else
                {
                    DataBack?.Invoke(this);
                }
            }

            this.Close();

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


    }
}
