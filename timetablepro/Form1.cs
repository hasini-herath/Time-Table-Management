using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetablepro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                textBox1.Text = comboBox1.Text + "." + comboBox2.Text + "." + domainUpDown1.Text;
                textBox2.Text = comboBox1.Text + "." + comboBox2.Text + "." + domainUpDown1.Text + "." + domainUpDown1.Text;







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into addstud values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + domainUpDown1.Text + "','" + domainUpDown2.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                display_data1();
                // display_data1();
                //   display_data2();
                MessageBox.Show("Insert Data Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";

            comboBox2.Text = "";
            domainUpDown1.Text = "";
            domainUpDown2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from addstud where prgm='" + comboBox3.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display_data1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from addstud where id='" + textBox9.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
                display_data1();
                // display_data2();
                MessageBox.Show("delete succesfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update addstud set acdemic_year='" + comboBox4.Text + "',prgm='" + comboBox3.Text + "',groupnm='" + domainUpDown4.Text + "',sbgroupnm='" + domainUpDown3.Text + "' ,groupid='" + textBox4.Text + "',subgroupid='" + textBox3.Text + "' where id='" + textBox9.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
                display_data1();
                //display_data2();
                MessageBox.Show("update succcess");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            textBox9.Text = "";
            comboBox4.Text = "";
            comboBox3.Text = "";
            domainUpDown4.Text = "";
            domainUpDown3.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox4.Text = comboBox4.Text + "." + comboBox3.Text + "." + domainUpDown4.Text;
            textBox3.Text = comboBox4.Text + "." + comboBox3.Text + "." + domainUpDown4.Text + "." + domainUpDown3.Text;
        }
    }
}
