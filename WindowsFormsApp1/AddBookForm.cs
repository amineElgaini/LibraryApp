using ClassLibrary1;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddBookForm : Form
    {
        public delegate void DataBackEventHandler(object sender);
        public event DataBackEventHandler DataBack;

        public AddBookForm()
        {
            InitializeComponent();
        }

        clsBooks Book = new clsBooks();

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book.ISBN = textBoxISBN.Text;
            Book.AdditionalDetails = textBoxDetails.Text;
            Book.PublicationDate = dateTimePickerBirthDate.Value;
            Book.Title = textBoxTitle.Text;
            Book.Genre = textBoxGenre.Text;
            Book.Copies = (int)numericUpDownCopies.Value;

            if (pictureBoxBookImage.ImageLocation == null)
                Book.Image = "";
            else
                Book.Image = pictureBoxBookImage.ImageLocation;

            if (Book.Save())
            {
                DataBack?.Invoke(this);
            }
            this.Close();
        }

        private void pictureBoxBookImage_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelAddImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;

                pictureBoxBookImage.ImageLocation = selectedFilePath;
                linkLabelRemoveImage.Visible = true;
                //pictureBoxUserImage.Load(selectedFilePath);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void linkLabelRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBoxBookImage.ImageLocation = null;
            linkLabelRemoveImage.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
