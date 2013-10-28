using Sniper.ShapeManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sniper
{
    public partial class MainForm : Form
    {
        private ViewManager viewManager = new ViewManager();
        public MainForm()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            viewManager.Paint(sender as Control, e);
        }

        private void splitContainer1_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            viewManager.MouseDown(sender as Control, e);
        }

        private void splitContainer1_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            viewManager.MouseMove(sender as Control, e);
        }

        private void splitContainer1_Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            viewManager.MouseUp(sender as Control, e);
        }
    }
}
