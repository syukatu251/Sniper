using Sniper.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniper.ShapeManager
{
    interface IShapeManager
    {
        List<IShape> ShapeList { get; }
        IDraggableShape DraggableShape { get; set; }
    }
}
