using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Car_Server
{
    public partial class AddUsers : Form
    {
        public AddUsers()
        {
            InitializeComponent();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PasswordTXT.Text == "")
            {
                errorProvider1.SetError(PasswordTXT, "Please Enter Password.");
                return;
            }
            if (PasswordTXT.Text != ConfirmPasswordTXT.Text)
            {
                errorProvider1.SetError(PasswordTXT, "Please Confirm Password.");
                return;
            }

            Control_User CU = new Control_User();
            CU.UserName = UserNameTXT.Text;
            CU.Password = PasswordTXT.Text;
            CU.FullName = AgentNameTXT.Text;
            if(PictureBrowser.FileName!="")
                CU.UserImage = Image.FromFile(PictureBrowser.FileName);
            CU.ImageFile = PictureBrowser.FileName;
            
            if (Control_User.Add(CU))
            {
                ConfirmPictureBox.Image = imageList1.Images[0];
                UserNameTXT.Text = "";
                PasswordTXT.Text = "";
                AgentNameTXT.Text = "";
                ConfirmPasswordTXT.Text = "";
                LoadUsers();
            }
            else
                ConfirmPictureBox.Image = imageList1.Images[1];
        }

        private void AgentPhotoPB_Click(object sender, EventArgs e)
        {
            if (PictureBrowser.ShowDialog() == DialogResult.OK)
            {
                AgentPhotoPB.BackgroundImage = Image.FromFile(PictureBrowser.FileName);
                
            }
        }

        private void AddUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
            PictureBrowser = new OpenFileDialog();
        }

        private void LoadUsers()
        {
            DGVUsers.Rows.Clear();
            foreach (Control_User CU in Control_User.GetUsers())
            {
                DGVUsers.Rows.Add(CU.UserName, CU.Password, CU.FullName, CU.UserImage);
            }
        }

        private void usersTableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserNameTXT_TextChanged(object sender, EventArgs e)
        {
                     
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            if (RemovePasswordTXT.Text == "")
            {
                errorProvider1.SetError(RemovePasswordTXT, "Please Enter Password.");
                return;
            }
            if (Control_User.Delete(UserName.Text, RemovePasswordTXT.Text))
            {
                ConfirmRemovePB.Image = imageList1.Images[0];
                LoadUsers();
            }
            else
                ConfirmRemovePB.Image = imageList1.Images[1];
        }

        private void ConfirmPasswordTXT_Leave(object sender, EventArgs e)
        {
            if (ConfirmPasswordTXT.Text != PasswordTXT.Text)
                errorProvider1.SetError(ConfirmPasswordTXT, "Please Confirm Password.");
        }

        private void DeleteInfoGB_Enter(object sender, EventArgs e)
        {

        }

        private void DGVUsers_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGVUsers.SelectedRows)
	        {
                UserNameTXT.Text=row.Cells[0].Value.ToString();
                RemovePasswordTXT.Text = row.Cells[1].Value.ToString();
	        }
        }
    }
}
