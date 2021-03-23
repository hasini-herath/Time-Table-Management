using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeManagement1
{
    public partial class Statictits : Form
    {
        public Statictits()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Age"].Points.AddXY("Max",33);
            this.chart1.Series["Age"].Points.AddXY("carl", 20);
            this.chart1.Series["Age"].Points.AddXY("mark", 50);
            this.chart1.Series["Age"].Points.AddXY("alli", 40);
        }
    }
}
