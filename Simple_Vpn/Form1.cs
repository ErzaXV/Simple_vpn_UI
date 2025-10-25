using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Reflection.Emit;

namespace Simple_Vpn
{

    public partial class Form1 : Form
    {
        bool mousedown;
        private Point offset;
     
       
        public Form1()
        {
            InitializeComponent();
          
        }
        private void toggle_Button1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (toggle_Button1.Checked)
            {
                label1.Text = "On";
                if(Server_Vaule.server == 1)
                {
                    MessageBox.Show("Connected to server 1");
                }
                if (Server_Vaule.server == 2)
                {
                    MessageBox.Show("Connected to server 2");
                }
                if (Server_Vaule.server == 3)
                {
                    MessageBox.Show("Connected to server 3");
                }
            }
            else if (toggle_Button1.Checked == false)
            {
                label1.Text = "Off";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
             closechildfrom(new Location_form());
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
             openchildform(new Location_form());
        
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
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Form activefrom = null; // old one
        private void openchildform(Form childfrom)
        {
       
            if (activefrom != null)
                activefrom.Close();
            activefrom = childfrom;
            childfrom.TopLevel = false;
            childfrom.FormBorderStyle = FormBorderStyle.None;
            childfrom.Dock = DockStyle.Fill;
            Childpanel.Controls.Add(childfrom);
            Childpanel.Tag = childfrom;
            childfrom.BringToFront();
            childfrom.Show();
        }
        private void closechildfrom(Form childfrom)
        {
            if (activefrom != null)
            {
                activefrom.Close();
                Childpanel.Controls.Remove(activefrom);
                activefrom = null;
            }
        }
       
       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Childpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login_form login_Form = new Login_form();
            login_Form.Show();
        }
    }
}
