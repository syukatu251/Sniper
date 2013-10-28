using Sniper.Manipulater;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniper.Shape
{
    class DragRectangle : IRectangle, IDraggableShape
    {
        public Point StartPoint
        {
            get;
            set;
        }

        public Point EndPoint
        {
            get;
            set;
        }

        public Point Location
        {
            get
            {
                int x = Math.Min(StartPoint.X, EndPoint.X);
                int y = Math.Min(StartPoint.Y, EndPoint.Y);
                return new Point(x, y);
            }
        }

        public Size Size
        {
            get
            {
                int width = Math.Abs(EndPoint.X - StartPoint.X);
                int height = Math.Abs(EndPoint.Y - StartPoint.Y);
                return new Size(width, height);
            }
        }

        public Rectangle Bound
        {
            get 
            {
                return new Rectangle(Location, Size);
            }
        }

        public Pen Pen
        {
            get;
            set;
        }

        public Brush Brush
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        private ResizeManipulater resizer;

        public IDragManipulater DragManipulater
        {
            get 
            {
                return resizer;
            }
        }

        public DragRectangle()
        {
            resizer = new ResizeManipulater(this);
            Pen = Pens.Black;
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(Pen, Bound);
        }


    }
}
