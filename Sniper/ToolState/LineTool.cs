using Sniper.Event;
using Sniper.Shape;
using Sniper.ShapeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sniper.ToolState
{
    class LineTool : Tool, IMouseEvent
    {
        public LineTool(IShapeManager manager)
            : base(manager)
        {
        }
        public void MouseDown(Control control, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void MouseMove(Control control, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void MouseUp(Control control, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void DoEndDrag(IDraggableShape draggableShape)
        {
            ShapeManager.ShapeList.Add(new LineShape(draggableShape));
        }
    }
}
