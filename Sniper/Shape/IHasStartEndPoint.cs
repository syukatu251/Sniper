using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniper.Shape
{
    interface IHasStartEndPoint
    {
        Point StartPoint { get; set; }
        Point EndPoint { get; set; }
    }
}
