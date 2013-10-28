using Sniper.Manipulater;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniper.Shape
{
    class DragLine : ILine, IDraggableShape
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

        public Pen Pen
        {
            get;
            set;
        }

        private ResizeManipulater resizer;

        public IDragManipulater DragManipulater
        {
            get 
            {
                return resizer;
            }
        }

        public DragLine()
        {
            resizer = new ResizeManipulater(this);
            Pen = Pens.Black;
        }

        public void Draw(Graphics g)
        {
            g.DrawLine(Pen, StartPoint, EndPoint);
        }




    }
}
