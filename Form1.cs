using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sagdan_sola_yukardan_asagi_kayan_yazi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x = 0; 
        int y = 30; 
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            // label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0,1); 
            label1.Location = new Point(x, label1.Location.Y); 
            label2.Location = new Point(label1.Location.Y, y); 
            x -= 5; 
            y += 5; 
            if (x < 0) x = 425; 
            if (y > 260) y = 30; 
        }
    }
}
