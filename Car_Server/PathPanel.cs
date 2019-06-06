using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PathPanel
{
    public partial class PathPanel : UserControl
    {

        private  Graphics VisibleGraphics,unvisibleGraphics;        
        private Bitmap SaveImage;
        private bool showgrid,trackpath,showaxis;
        private int CHeight, CWidth;
        private int penwidth=8;
        private List<Obstacle> Obstacles = new List<Obstacle>();
        private Obstacle CurrentObst = new Obstacle();
        private GraphicsPath GP = new GraphicsPath();
        private bool OperationFlag = false;
        private Point LastPoint = new Point();


        public bool ShowGrid
        {
            get
            {
                return showgrid;
            }
            set
            {
                showgrid = value;
                this.Invalidate();
            }
        }

        public bool ShowAxis
        {
            get
            {
                return showaxis;
            }
            set
            {
                showaxis = value;
                this.Invalidate();
            }
        }

        public bool TrackPath
        {
            get
            {
                return trackpath;
            }
            set
            {
                trackpath = value;
                this.Invalidate();
            }
        }        

        private DrawingType operationtype;

        public DrawingType OperationType
        {
            get
            {
                return operationtype;
            }
            set
            {
                operationtype = value;
            }
        }

        public enum DrawingType
        {
            select,Blocks,FreeHand
        }

        public int PenWidth
        {
            get
            {
                return penwidth;
            }
            set
            {
                if (penwidth > 1)
                    penwidth = value;
            }
        }



        public PathPanel()
        {
            InitializeComponent();
        }

        private void PathPanel_Load(object sender, EventArgs e)
        {            
            VisibleGraphics = this.CreateGraphics();
            CWidth = this.Size.Width;
            CHeight = this.Size.Height;
            SaveImage = new Bitmap(CWidth, CHeight);
            unvisibleGraphics = Graphics.FromImage(SaveImage); 
            
        }

        public void Save(string Location)
        {
            if (Location.Split('.')[1].ToLower() == "bmp")
                SaveImage.Save(Location, System.Drawing.Imaging.ImageFormat.Bmp);
            if (Location.Split('.')[1].ToLower() == "jpeg")
                SaveImage.Save(Location, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void PathPanel_Paint(object sender, PaintEventArgs e)
        {
            if (showgrid)
                DrawGrid();
            if (operationtype == DrawingType.FreeHand)
            {                
                foreach (Obstacle Obs in Obstacles)
                {
                    Pen P = new Pen(Obs.ObjColor);
                    P.Width = Obs.PenWidth;
                    VisibleGraphics.DrawPath(P, Obs.Points);
                }                
            }
            
            
        }

        private void PathPanel_Resize(object sender, EventArgs e)
        {            
            CWidth = this.Size.Width;
            CHeight = this.Size.Height;
        }

        private void DrawGrid()
        {
            int XStep = CWidth / 12;
            int YStep = CHeight / 12;
            Pen P=new Pen(Color.Gray);
            for (int i = 0; i < 12; i++)
            {
                VisibleGraphics.DrawLine(P, XStep * i, 0, XStep * i, CHeight);
                VisibleGraphics.DrawLine(P, 0, YStep*i, CWidth, YStep*i);
            }
        }

        private void PathPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CurrentObst = new Obstacle();
                CurrentObst.Points = new GraphicsPath();
                CurrentObst.ObjColor = ForeColor;
                CurrentObst.PenWidth = penwidth;
                Obstacles.Add(CurrentObst);
                FirstOp = true;
                OperationFlag = true;
            }
        }

        private void PathPanel_MouseUp(object sender, MouseEventArgs e)
        {
            OperationFlag = false;
            switch (operationtype)
            {
                case DrawingType.FreeHand: break;
            }
            
        }

        bool FirstOp = true;
        private void PathPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(OperationFlag)
                switch (OperationType)
                {
                    case DrawingType.FreeHand:
                        if (FirstOp)
                        {
                            LastPoint = new Point(e.X, e.Y);
                            FirstOp = false;
                        }                        
                        Obstacles[Obstacles.Count-1].Points.AddCurve(new Point[] { LastPoint, new Point(e.X, e.Y) }, 0.7f);
                        LastPoint = new Point(e.X, e.Y);
                        this.Invalidate();
                        break;
                    case DrawingType.Blocks: 
                        break;
                    case DrawingType.select: 
                        break;
                }
        }

        private void PathPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          
        }

        public string TempName = "";
        private void PathPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (Obstacle Obs in Obstacles)
                {
                    if (Obs.Intersect(e.Location))
                    {
                        if (Obs.Name != "")
                        {
                            toolTip1.Active = true;
                            toolTip1.ToolTipTitle = "Object Name :";
                            toolTip1.Show(Obs.Name, this);
                        }
                        else
                        {
                            ObstacleInfo OI = new ObstacleInfo();
                            OI.StartPosition = FormStartPosition.CenterScreen;
                            OI.PathPanelRef = this;
                            OI.ShowDialog();
                            Obs.Name = TempName;
                            TempName = "";
                        }
                        break;
                    }
                }
            }
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {

        }

        private void PathPanel_MouseHover(object sender, EventArgs e)
        {
            
            
        }
    }
}
