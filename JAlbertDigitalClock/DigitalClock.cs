using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAlbertDigitalClock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
        }

        private void DigitalClock_Load_1(object sender, EventArgs e)
        {
            
        }
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        private void timerStop_Click(object sender, EventArgs e)
        {
            clockTimer.Stop();
        }
        private void timerStart_Click(object sender, EventArgs e)
        {
            clockTimer.Start();
        }

 


    }
}
