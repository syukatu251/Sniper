using Sniper.Event;
using Sniper.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sniper.Manipulater
{
    class ResizeManipulater : IDragManipulater
    {
        IHasStartEndPoint manipulatee;
        public ResizeManipulater(IHasStartEndPoint manipulatee)
        {
            this.manipulatee = manipulatee;
        }
        public void MouseDown(MouseEventArgs e)
        {
            manipulatee.StartPoint = e.Location;
            manipulatee.EndPoint = e.Location;
        }

        public void Drag(ClickMoveEventArgs e)
        {
            manipulatee.EndPoint = e.HalfwayPoint;
        }

        public void MouseUp(MouseEventArgs e)
        {
            manipulatee.EndPoint = e.Location;
        }
    }
}
