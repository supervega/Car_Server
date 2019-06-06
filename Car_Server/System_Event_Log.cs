using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Car_Server
{
    public partial class System_Event_Log : Form
    {
        public System_Event_Log()
        {
            InitializeComponent();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD=new SaveFileDialog();
            SFD.Filter = "(*.log)|*.txt";
            if(SFD.ShowDialog()==DialogResult.OK)
            {
                SaveLog(SFD.FileName);
            }
            
        }

        public void SaveLog(string FileLocation)
        {
            FileStream FS = new FileStream(FileLocation, FileMode.Create, FileAccess.Write);
            StreamWriter write = new StreamWriter(FS);
            for (int i = 0; i < LBEvents.Items.Count; i++)
            {
                write.WriteLine(LBEvents.Items[i].ToString());
            }
            write.Close();
            FS.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LBEvents.Items.Clear();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
