using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proteklo_i_tekuce_vrijeme
{
    public partial class Form1 : Form
    {
        DateTime pocetno;
        public Form1()
        {
            InitializeComponent();
        }

        private void sspStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pocetno = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Trenutno: " + DateTime.Now.ToLongTimeString();
            TimeSpan proteklo = new TimeSpan();
            proteklo = DateTime.Now - pocetno;
            toolStripStatusLabel1.Text = "Proteklo: " + proteklo.Hours.ToString() + ":" + proteklo.Minutes.ToString() + ":" + proteklo.Seconds.ToString();
        }
    }
}
