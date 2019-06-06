using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Microsoft.Win32;
using System.IO;

namespace Car_Server
{
    public partial class Users : Form
    {
        
        public Users()
        {
            InitializeComponent();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            if (MainForm.CurrentUser.UserName != "")
            {
                MainForm.StatusMSG = MainForm.CurrentUser.FullName + " must log out before continue.";
                MainForm.SEL.LBEvents.Items.Add(MainForm.CurrentUser.FullName + " must log out before continue.  " + DateTime.Now.ToString());
                this.Close();
                return;
            }
            Control_User USer=Control_User.Get(UserNameTXT.Text, PasswordTXT.Text);
            if (USer==null)
            {
                MainForm.SEL.LBEvents.Items.Add(UserNameTXT.Text + " failed while log in.  " + DateTime.Now.ToString());
                MainForm.StatusMSG = UserNameTXT.Text + " failed while log in.  ";
                Resultlbl.Text = "Failed";
                Resultlbl.ForeColor = Color.Red;
            }
            else 
            {
                MainForm.SEL.LBEvents.Items.Add(USer.FullName + " has just sign in.  " + DateTime.Now.ToString());
                MainForm.StatusMSG = USer.FullName + " has just sign in.  ";
                Resultlbl.Text = "Success";
                Resultlbl.ForeColor = Color.LightGreen;
                MainForm.CurrentUser.UserName = USer.UserName;
                MainForm.CurrentUser.Password = USer.Password;
                MainForm.CurrentUser.FullName = USer.FullName;
                pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox2.BackgroundImage = USer.UserImage;
                timer1.Start();                
            }
        } 
       

        private void Users_Load(object sender, EventArgs e)
        {
            
        }

        bool flag = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                timer1.Stop();
                this.Close();
            }
            else
                flag = true;
        }
    }
}
