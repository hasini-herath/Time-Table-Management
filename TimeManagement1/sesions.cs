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
    public partial class sesions : Form
    {
        public sesions()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage17_Click(object sender, EventArgs e)
        {

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button23_Click_1(object sender, EventArgs e)
        {

        }

        private void label70_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into session values('" + comboBox11.Text + "','" + comboBox9.Text + "','" + comboBox8.Text + "','" + comboBox10.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                display_session();
                // display_data1();
                //   display_data2();
                MessageBox.Show("Insert Data Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            comboBox11.Text = "";
            comboBox9.Text = "";
            comboBox8.Text = "";
            comboBox10.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox12.Text = comboBox11.Text + " - " + comboBox10.Text + " - " + comboBox9.Text + " - " + comboBox8.Text + " - " + textBox8.Text + " - " + textBox9.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text == "lecturer")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from session where selec='" + textBox4.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (comboBox5.Text == "subject")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from session where selsub='" + textBox4.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (comboBox5.Text == "group")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from session where selgrp='" + textBox4.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display_session();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update session set selec='" + comboBox29.Text + "',selgrp='" + comboBox16.Text + "',selsub='" + comboBox15.Text + "',seltag='" + comboBox28.Text + "',nostu='" + textBox10.Text + "' ,duration='" + textBox17.Text + "' where id='" + textBox18.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
                display_session();
                //display_data2();
                MessageBox.Show("update succcess");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from session where id='" + textBox18.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
                display_session();
                // display_data2();
                MessageBox.Show("delete succesfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox5.Text = comboBox29.Text + " - " + comboBox16.Text + " - " + comboBox15.Text + " - " + comboBox28.Text + " - " + textBox10.Text + " - " + textBox17.Text;
        }
    }
}
