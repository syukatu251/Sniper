using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniper.Shape
{
    class LineShape : ILine, IHittable
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

        public Pen Pen { get; set; }

        public LineShape(IHasStartEndPoint dragLine)
        {
            StartPoint = dragLine.StartPoint;
            EndPoint = dragLine.EndPoint;
            Pen = Pens.Black;
        }

        public void Draw(Graphics g)
        {
            g.DrawLine(Pen, StartPoint, EndPoint);
        }

        public bool HitTest(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
