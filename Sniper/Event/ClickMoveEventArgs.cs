using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniper.Event
{
    class ClickMoveEventArgs : EventArgs
    {
        public Point StartPoint { get; private set; }
        public Point HalfwayPoint { get; set; }
        public Point EndPoint { get; set; }
        public Point Differece
        {
            get
            {
                int x = EndPoint.X - HalfwayPoint.X;
                int y = EndPoint.Y - HalfwayPoint.Y;
                return new Point(x, y);
            }
        }
        public ClickMoveEventArgs(Point startPoint)
        {
            StartPoint = startPoint;
            HalfwayPoint = startPoint;
            EndPoint = startPoint;
        }
    }
}
