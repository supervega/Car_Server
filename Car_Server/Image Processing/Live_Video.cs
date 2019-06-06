using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Image_Processing_Unit;
using System.Net;
using System.IO;
using System.Threading;

namespace Car_Server
{
    public partial class Live_Video : Form
    {
        public Live_Video()
        {
            InitializeComponent();           
        }

        private void Live_Video_Load(object sender, EventArgs e)
        {
            MainForm.InvisiblePreview.Show();        
            timer1.Start();
        }

      

        private void Live_Video_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void Live_Video_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ScreenCapture SC = new ScreenCapture();
            PBLeftCamera.Image = SC.CaptureWindow(MainForm.InvisiblePreview.webBrowser1.Handle);
            SC = new ScreenCapture();
            PBRightCamera.Image = SC.CaptureWindow(MainForm.InvisiblePreview.webBrowser2.Handle);
        }       
      
       
  /*
      public Bitmap CaptureControl(Control control)
  
      {
  
          Bitmap controlBmp;
  
          using (Graphics g1 = control.CreateGraphics())
  
          {
  
              controlBmp = new Bitmap(control.Width, control.Height, g1);
  
              using (Graphics g2 = Graphics.FromImage(controlBmp))
  
              {
  
                  IntPtr dc1 = g1.GetHdc();
  
                  IntPtr dc2 = g2.GetHdc();
  
                  BitBlt(dc2, 0, 0, control.Width, control.Height, dc1, 0, 0, 13369376);
  
                  g1.ReleaseHdc(dc1);
  
                  g2.ReleaseHdc(dc2);
  
             }
  
          }
  
       
  
          return controlBmp;
  
      } 
   */
          
    }

}
