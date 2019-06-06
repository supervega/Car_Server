using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace Car_Server
{
    public partial class SystemInitializer : Form
    {
        public SystemInitializer()
        {
            InitializeComponent();
        }

        private void BtnTestConnection_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source="+TXTHostName.Text+"\\"+DBServerNameTXT.Text+";Initial Catalog="+DBNameTXT.Text+";integrated security=false;user id="+DBUserNameTXT.Text+";password="+DBPasswordTXT.Text);
            try
            {
                conn.Open();
                PBResult.BackgroundImage = imageList1.Images[1];
            }
            catch (Exception ex)
            {
                PBResult.BackgroundImage = imageList1.Images[0];
            }
            finally
            {
                if(conn!=null)
                    conn.Close();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.CreateSubKey("SOFTWARE\\SUPERVEGA");
                if (rk.GetValue("SUPERVEGA_DBusr") == null)
                {
                    rk.SetValue("SUPERVEGA_DBusr", DBUserNameTXT.Text);
                    rk.SetValue("SUPERVEGA_DBpwd", DBPasswordTXT.Text);
                    rk.SetValue("SUPERVEGA_DBname", DBNameTXT.Text);
                    rk.SetValue("SUPERVEGA_DBserver", DBServerNameTXT.Text);
                    rk.SetValue("SUPERVEGA_Network", TXTHostName.Text);
                }
                DBConnection.HostName = TXTHostName.Text;
                DBConnection.DBServerName = DBServerNameTXT.Text;
                DBConnection.DBUserName = DBUserNameTXT.Text;
                DBConnection.DBPassword = DBPasswordTXT.Text;
                DBConnection.DBName = DBNameTXT.Text;
                rk.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
