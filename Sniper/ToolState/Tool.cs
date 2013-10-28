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
    abstract class Tool
    {
        protected IShapeManager ShapeManager {get; private set;}
        protected ClickMoveEventArgs ClickMoveEventArgs { get; private set; }
        public Tool(IShapeManager manager)
        {
            ShapeManager = manager;
        }

        protected void StartDrag(Control control, MouseEventArgs e)
        {
            ShapeManager.DraggableShape = new DragRectangle();
            ShapeManager.DraggableShape.DragManipulater.MouseDown(e);
            ClickMoveEventArgs = new ClickMoveEventArgs(e.Location);
            control.Refresh();
        }

        protected void Drag(Control control, MouseEventArgs e)
        {
            if (ShapeManager.DraggableShape != null)
            {
                ClickMoveEventArgs.HalfwayPoint = e.Location;
                ShapeManager.DraggableShape.DragManipulater.Drag(ClickMoveEventArgs);
                control.Refresh();
            }
        }

        protected void EndDrag(Control control, MouseEventArgs e)
        {
            if (ShapeManager.DraggableShape != null)
            {
                ShapeManager.DraggableShape.DragManipulater.MouseUp(e);
                DoEndDrag(ShapeManager.DraggableShape);
                ShapeManager.DraggableShape = null;
            }
            control.Refresh();
        }

        protected abstract void DoEndDrag(IDraggableShape draggableShape);
    }
}
