using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Car_Server
{
    public partial class test : Form
    {
        public Graphics G;

        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            webBrowser1.ScrollBarsEnabled = false;
            webBrowser2.ScrollBarsEnabled = false;
            webBrowser1.Navigate(Application.StartupPath + "\\LeftCamera.html");
            webBrowser2.Navigate(Application.StartupPath + "\\RightCamera.html");
        }
    }
}
