using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PathPanel
{
    public partial class ObstacleInfo : Form
    {
        public PathPanel. PathPanelRef;

        public ObstacleInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            PathPanelRef.TempName = TXTName.Text;
            this.Close();
        }
    }
}
