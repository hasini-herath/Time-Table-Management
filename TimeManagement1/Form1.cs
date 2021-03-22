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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            student infrm = new student();
            infrm.TopLevel = false;
            panel2.Controls.Add(infrm);
            infrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            infrm.Dock = DockStyle.Fill;
            infrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            lecturer infrm = new lecturer();
            infrm.TopLevel = false;
            panel2.Controls.Add(infrm);
            infrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            infrm.Dock = DockStyle.Fill;
            infrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            sesions infrm = new sesions();
            infrm.TopLevel = false;
            panel2.Controls.Add(infrm);
            infrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            infrm.Dock = DockStyle.Fill;
            infrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            location infrm = new location();
            infrm.TopLevel = false;
            panel2.Controls.Add(infrm);
            infrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            infrm.Dock = DockStyle.Fill;
            infrm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Statictits infrm = new Statictits();
            infrm.TopLevel = false;
            panel2.Controls.Add(infrm);
            infrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            infrm.Dock = DockStyle.Fill;
            infrm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
