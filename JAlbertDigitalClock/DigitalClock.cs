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
            clockLabel.ForeColor = Color.Aquamarine;
        }
        private void timerStop_Click(object sender, EventArgs e)
        {
            clockTimer.Stop();
            clockLabel.ForeColor = Color.DarkRed;
        }
        private void timerStart_Click(object sender, EventArgs e)
        {
            clockTimer.Start();
        }

        private void pacificTime_Click(object sender, EventArgs e)
        {
                TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
                DateTime pacificTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, pstZone);
                clockLabel.Text = pacificTime.ToString("hh:mm:ss");
 
        }

        private void centralTime_Click(object sender, EventArgs e)
        {
            TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
            DateTime centralTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, cstZone);
            clockLabel.Text = centralTime.ToString("hh:mm:ss");
            
        }

        private void mountainTime_Click(object sender, EventArgs e)
        {
            TimeZoneInfo mstZone = TimeZoneInfo.FindSystemTimeZoneById("Mountain Standard Time");
            DateTime mountainTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, mstZone);
            clockLabel.Text = mountainTime.ToString("hh:mm:ss");

        }

    }
}
