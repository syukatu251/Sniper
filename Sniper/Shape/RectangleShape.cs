using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniper.Shape
{
    class RectangleShape : IRectangle, IHittable
    {
        public Point Location { get; set; }
        public Size Size { get; set; }
        public Rectangle Bound
        {
            get 
            {
                return new Rectangle(Location, Size);
            }
            set
            {
                Location = value.Location;
                Size = value.Size;
            }
        }

        public Pen Pen
        {
            get;
            set;
        }

        public Brush Brush
        {
            get;
            set;
        }

        public void Draw(Graphics g)
        {
            if (Brush != null)
            {
                g.FillRectangle(Brush, Bound);
            }
            if (Pen != null)
            {
                g.DrawRectangle(Pen, Bound);
            }
        }

        public bool HitTest(Point point)
        {
            return false;
        }



    }
}
