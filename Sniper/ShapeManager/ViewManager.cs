using Sniper.Event;
using Sniper.Shape;
using Sniper.ToolState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sniper.ShapeManager
{
    class ViewManager : IShapeManager, IMouseEvent
    {
        public List<IShape> ShapeList
        {
            get;
            private set;
        }

        public IDraggableShape DraggableShape
        {
            get;
            set;
        }
        private ClickMoveEventArgs clickMoveEventArgs = null;

        public Tool ToolState { get; set; }

        public ViewManager()
        {
            ShapeList = new List<IShape>();
            DraggableShape = null;
            ToolState = new SelectTool(this);
        }

        public void Paint(Control control, PaintEventArgs e)
        {
            foreach (IShape shape in ShapeList)
            {
                shape.Draw(e.Graphics);
            }
            if (DraggableShape != null)
            {
                DraggableShape.Draw(e.Graphics);
            }
        }



        public void MouseDown(Control control, MouseEventArgs e)
        {
            DraggableShape = new DragRectangle();
            DraggableShape.DragManipulater.MouseDown(e);
            clickMoveEventArgs = new ClickMoveEventArgs(e.Location);
            control.Refresh();
        }

        public void MouseMove(Control control, MouseEventArgs e)
        {

            if (DraggableShape != null)
            {
                clickMoveEventArgs.HalfwayPoint = e.Location;
                DraggableShape.DragManipulater.Drag(clickMoveEventArgs);
                control.Refresh();
            }
        }

        public void MouseUp(Control control, MouseEventArgs e)
        {
            if (DraggableShape != null)
            {
                DraggableShape.DragManipulater.MouseUp(e);
                ShapeList.Add(new LineShape(DraggableShape));
                DraggableShape = null;
            }
            control.Refresh();
        }
    }
}
