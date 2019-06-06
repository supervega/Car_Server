using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.IO;
using System.Data.SqlClient;

namespace Car_Server
{
    public class Control_User
    {       
        private string username;
        private string password;
        private string fullname;
        private Image userimage;
        private string imagefile;

        public string UserName
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string FullName
        {
            get
            {
                return fullname;
            }
            set
            {
                fullname = value;
            }
        }

        public Image UserImage
        {
            get
            {
                return userimage;
            }
            set
            {
                userimage = value;
            }
        }

        public string ImageFile
        {
            get
            {
                return imagefile;
            }
            set
            {
                imagefile = value;
            }
        }

        public Control_User()
        {
            UserName = "";
            Password = "";
            FullName = "";
            ImageFile = "";
        }

        public static bool Add(Control_User Usr)        
        {
            bool result = false;
            try
            {
                DBConnection.Conn.Open();
                SqlCommand cmd = new SqlCommand("insert into UsersInfo values(@UserName,@Password,@FullName,@UserImage)",DBConnection.Conn);
                SqlParameter UserNameParam = new SqlParameter("@UserName", Usr.UserName);
                SqlParameter PasswordParam = new SqlParameter("@Password", Usr.Password);
                SqlParameter FullNameParam = new SqlParameter("@FullName", Usr.FullName);
                SqlParameter ImageParam = new SqlParameter();
                ImageParam.ParameterName= "@UserImage";                                
                if (Usr.ImageFile != "")
                {
                    Bitmap data = new Bitmap(Usr.ImageFile);
                    MemoryStream stream = new MemoryStream();
                    data.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    ImageParam.Value = stream.ToArray();
                }
                else
                    ImageParam.Value = new byte[2];                 
                cmd.Parameters.Add(UserNameParam);
                cmd.Parameters.Add(PasswordParam);
                cmd.Parameters.Add(FullNameParam);
                cmd.Parameters.Add(ImageParam);
                cmd.ExecuteNonQuery();
                result = true;
                MainForm.SEL.LBEvents.Items.Add(Usr.FullName + " is now in the user list.  " + DateTime.Now.ToString());
                MainForm.StatusMSG = Usr.FullName + " is now in the user list.  ";
            }
            catch (Exception ex)
            {
                MainForm.SEL.LBEvents.Items.Add("Couldn't add user. (" + ex.Message + ")  " + DateTime.Now.ToString());
                MainForm.StatusMSG = "Couldn't add user. (" + ex.Message + ")";
            }
            finally
            {
                DBConnection.Conn.Close();
            }
            return result;
        }

        public static bool Delete(string UserName,string Password)
        {
            bool result = false;
            try
            {
                DBConnection.Conn.Open();
                SqlCommand cmd = new SqlCommand("delete from UsersInfo where username=@UserName and Password=@Password", DBConnection.Conn);
                SqlParameter UserNameParam = new SqlParameter("@UserName", UserName);
                SqlParameter PasswordParam = new SqlParameter("@Password",Password);                
                cmd.Parameters.Add(UserNameParam);
                cmd.Parameters.Add(PasswordParam);                
                cmd.ExecuteNonQuery();
                result = true;
                MainForm.SEL.LBEvents.Items.Add(UserName + " has been deleted from user list.  " + DateTime.Now.ToString());
                MainForm.StatusMSG = UserName + " has been deleted from user list.  ";                
            }
            catch (Exception ex)
            {
                MainForm.SEL.LBEvents.Items.Add("Couldn't delete user. (" + ex.Message + ")  " + DateTime.Now.ToString());
                MainForm.StatusMSG = "Couldn't delete user. (" + ex.Message + ")";
            }
            finally
            {
                DBConnection.Conn.Close();
            }
            return result;
        }

        public static Control_User Get(string UserName, string Password)
        {
            Control_User result = null;
            SqlDataReader rdr = null;
            try
            {

                DBConnection.Conn.Open();
                SqlCommand cmd = new SqlCommand("select * from UsersInfo where UserName=@UserName and Password=@Password", DBConnection.Conn);
                SqlParameter UserNameParam = new SqlParameter("@UserName", UserName);
                SqlParameter PasswordParam = new SqlParameter("@Password", Password);
                cmd.Parameters.Add(UserNameParam);
                cmd.Parameters.Add(PasswordParam);   
                rdr=cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result = new Control_User();
                    result.UserName= rdr["UserName"].ToString();
                    result.Password = rdr["Password"].ToString();
                    result.FullName = rdr["Fullname"].ToString();
                    rdr.Close();
                    try
                    {
                        result.UserImage = Image.FromStream(RetrieveImage(result.UserName));
                        break;
                    }
                    catch (Exception ex)
                    { }
                }                
            }
            catch (Exception ex)
            {
                MainForm.SEL.LBEvents.Items.Add("Couldn't get user's info. (" + ex.Message + ")  " + DateTime.Now.ToString());
                MainForm.StatusMSG = "Couldn't get user's info. (" + ex.Message + ")";
            }
            finally
            {
                if (rdr != null)
                    rdr.Close();
                DBConnection.Conn.Close();
            }
            return result;
        }

        public static MemoryStream RetrieveImage(string UserName)
        {
            byte check = 123;
            MemoryStream returnedValue = new MemoryStream(check);
            try
                {
                    SqlCommand cmd = new SqlCommand("Select Image from UsersInfo where UserName=@UserName", DBConnection.Conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@UserName";
                    param.Value = UserName;
                    cmd.Parameters.Add(param);
                    byte[] content = (byte[])cmd.ExecuteScalar();
                    MemoryStream stream = new MemoryStream(content);
                    returnedValue = stream;
                }
                catch (Exception ex)
                {

                    MainForm.SEL.LBEvents.Items.Add("Couldn't retrieve user's image. (" + ex.Message + ")  " + DateTime.Now.ToString());
                    MainForm.StatusMSG = "Couldn't retrieve user's image. (" + ex.Message + ")";
                }            
            return returnedValue;
        }

        public static List<Control_User> GetUsers()
        {
            List<Control_User> result = null;
            SqlDataReader rdr = null;
            try
            {
                DBConnection.Conn.Open();
                SqlCommand cmd = new SqlCommand("select * from UsersInfo", DBConnection.Conn);
                rdr = cmd.ExecuteReader();
                result = new List<Control_User>();
                while (rdr.Read())
                {
                    Control_User CU = new Control_User();
                    CU.UserName = rdr["UserName"].ToString();
                    CU.Password = rdr["Password"].ToString();
                    CU.FullName = rdr["FullName"].ToString();
                    result.Add(CU);
                }
                rdr.Close();
                for (int i = 0; i < result.Count; i++)
                {
                    result[i].UserImage = Image.FromStream(RetrieveImage(result[i].UserName));
                }
            }
            catch (Exception ex)
            {
                MainForm.SEL.LBEvents.Items.Add("Couldn't get users info. (" + ex.Message + ")  " + DateTime.Now.ToString());
                MainForm.StatusMSG = "Couldn't get users info. (" + ex.Message + ")";
            }
            finally
            {
                if (rdr != null)
                    rdr.Close();
                DBConnection.Conn.Close();
            }
            return result;
        }

    }
}
