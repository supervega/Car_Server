using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace PathPanel
{
    public class Obstacle
    {

        private GraphicsPath points;
        private string name="";
        private Color objColor;
        private int penWidth;

        public Obstacle()
        { }

        public GraphicsPath Points
        {
            get
            {
                return points;
            }
            set
            {
                points = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Color ObjColor
        {
            get
            {
                return objColor;
            }
            set
            {
                objColor = value;
            }
        }

        public int PenWidth
        {
            get
            {
                return penWidth;
            }
            set
            {
                penWidth = value;
            }
        }

        public bool Intersect(Point Dest)
        {
            for (int i = 0; i < points.PathPoints.Length; i++)
            {
                int dist = (int)Math.Sqrt(Math.Pow(Convert.ToDouble(Dest.X - points.PathPoints[i].X), 2) + Math.Pow(Convert.ToDouble(Dest.Y - points.PathPoints[i].Y), 2));
                if (dist <= penWidth / 2)
                   return true;                
            }
            return false;
        }

    }
}
