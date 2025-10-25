using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Vpn
{
    public partial class Login_form : Form
    {
        bool mousedown;
        private Point offset;
        public Login_form()
        {
            InitializeComponent();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }

        private void Mousedown_event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }

        private void Mousemove_event(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point currentscreenpos = PointToScreen(e.Location);
                Location = new Point(currentscreenpos.X - offset.X, currentscreenpos.Y - offset.Y);
            }
        }

        private void Mouseup_event(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
