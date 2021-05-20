using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace timetablepro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into tags values('" + textBox6.Text + "','" + textBox5.Text + "','" + comboBox5.Text + "')";
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

        private void button8_Click(object sender, EventArgs e)
        {

            textBox6.Text = "";
            textBox5.Text = "";
            comboBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tags where s_name='" + textBox8.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display_data1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update tags set s_name='" + textBox8.Text + "',s_code='" + textBox7.Text + "',r_tag='" + comboBox6.Text + "'  where id='" + textBox1.Text + "'";
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from tags where id='" + textBox1.Text + "'";
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
    }
}
