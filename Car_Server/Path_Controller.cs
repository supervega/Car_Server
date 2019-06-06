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
    public partial class Path_Controller : Form
    {

        public Path_Controller()
        {
            InitializeComponent();
        }

        private void Path_Controller_Load(object sender, EventArgs e)
        {     
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Path_Controller_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMBackColor_Click(object sender, EventArgs e)
        {
            if (MainColorDialog.ShowDialog() == DialogResult.OK)
            {
                pathPanel1.BackColor = MainColorDialog.Color;
            }
        }

        private void BtnMForeColor_Click(object sender, EventArgs e)
        {
            if (MainColorDialog.ShowDialog() == DialogResult.OK)
            {
                pathPanel1.ForeColor = MainColorDialog.Color;
            }
        }

        private void BtnPColor_Click(object sender, EventArgs e)
        {
            if (MainColorDialog.ShowDialog() == DialogResult.OK)
            {
                pathPanel1.PathColor = MainColorDialog.Color;
            }
        }

      
        private void RBSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (RBSelect.Checked)
                pathPanel1.OperationType = PathPanel.PathPanel.DrawingType.select;
        }

        private void RBDrawBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (RBDrawBlock.Checked)
                pathPanel1.OperationType = PathPanel.PathPanel.DrawingType.Blocks;
        }

        private void RBFreeHand_CheckedChanged(object sender, EventArgs e)
        {
            if (RBFreeHand.Checked)
                pathPanel1.OperationType = PathPanel.PathPanel.DrawingType.FreeHand;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "Jpeg Images(*.jpeg)|*.jpeg|Bitmap images(*.bmp)|*.bmp";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                pathPanel1.Save(SFD.FileName);
            }
        }

        private void NUDPenWidth_ValueChanged(object sender, EventArgs e)
        {
            pathPanel1.PenWidth = (int)NUDPenWidth.Value;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            pathPanel1.Clear();
        }

       

    }
}
