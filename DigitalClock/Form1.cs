using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Timer interval
            t.Interval = 1000; //in milliseconds

            t.Tick += new EventHandler(this.t_Tick);

            // Start timer when form loads
            t.Start(); // This will use t_Tick() method
        }
        // Timer eventhandler
        private void t_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToString("HH:mm:ss");
            // Update label
            label1.Text = clock;
        }
    }
}
