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
    public partial class Location_form : Form
    {
       
        public Location_form()
        {
            InitializeComponent();
        }

        private void Location_form_Load(object sender, EventArgs e)
        {
          
        }

        private void toggle_Button1_CheckedChanged(object sender, EventArgs e)
        {
   
            if (toggle_Button1.Checked)
            {
                Server_Vaule.server = 1;
                toggle_Button2.Checked = false;
                toggle_Button3.Checked = false;
               
            }
        }

        private void toggle_Button2_CheckedChanged(object sender, EventArgs e)
        {

            if (toggle_Button2.Checked)
            {
                Server_Vaule.server = 2;
                toggle_Button1.Checked = false;
                toggle_Button3.Checked = false;

            }
        }

        private void toggle_Button3_CheckedChanged(object sender, EventArgs e)
        {

            if (toggle_Button3.Checked)
            {
                Server_Vaule.server = 3;
                toggle_Button1.Checked = false;
                toggle_Button2.Checked = false;

            }
        }

    

    }
}
