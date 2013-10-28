using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sniper.Event
{
    interface IMouseEvent
    {
        void MouseDown(Control control, MouseEventArgs e);

        void MouseMove(Control control, MouseEventArgs e);

        void MouseUp(Control control, MouseEventArgs e);
    }
}
