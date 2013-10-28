using Sniper.Event;
using Sniper.Manipulater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sniper.Shape
{
    interface IDraggableShape : IShape, IHasStartEndPoint
    {
        IDragManipulater DragManipulater { get; }
    }
}
