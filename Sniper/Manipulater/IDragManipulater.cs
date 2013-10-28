using Sniper.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sniper.Manipulater
{
    interface IDragManipulater
    {
        void MouseDown(MouseEventArgs e);
        void Drag(ClickMoveEventArgs e);
        void MouseUp(MouseEventArgs e);
    }
}
