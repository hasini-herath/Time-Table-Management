using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timesadepika
{
    public partial class session : Form
    {
        SqlConnection con = new SqlConnection(@"Server=tcp:time-table-manage.database.windows.net,1433;Initial Catalog=timeaz;Persist Security Info=False;User ID=piya;Password=sachin123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        string t1, m, t, w, th, f, s, sun;

        public session()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            domainUpDown8.Text = "";
            checkBox20.Checked = false;
            checkBox15.Checked = false;
            checkBox19.Checked = false;
            checkBox16.Checked = false;
            checkBox7.Checked = false;
            checkBox18.Checked = false;
            checkBox17.Checked = false;
            domainUpDown11.Text = "";
            domainUpDown12.Text = "";
            domainUpDown13.Text = "";
            domainUpDown14.Text = "";
            comboBox13.Text = "";
            comboBox14.Text = "";
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update work_per1 set no_work='" + domainUpDown7.Text + "',mon='" + comboBox21.Text + "',tue='" + comboBox22.Text + "',wend='" + comboBox23.Text + "' ,thurs='" + comboBox24.Text + "',frida='" + comboBox25.Text + "',sat='" + comboBox26.Text + "',sun='" + comboBox27.Text + "',start_time='" + textBox14.Text + "',end_time='" + textBox15.Text + "',time_slot='" + domainUpDown1.Text + "' where id='" + textBox16.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
              //  display_data1();
                //display_data2();
                MessageBox.Show("update succcess");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from work_per1 where id='" + textBox16.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
              //  display_data1();
                // display_data2();
                MessageBox.Show("delete succesfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            domainUpDown7.Text = "";
            comboBox21.Text = "";
            comboBox22.Text = "";
            comboBox23.Text = "";
            comboBox24.Text = "";
            comboBox25.Text = "";
            comboBox26.Text = "";
            comboBox27.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            domainUpDown1.Text = "";
            textBox16.Text = "";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from work_per1 where Id='" + textBox16.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView8.DataSource = dt;
            con.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void session_Load(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into nosession values('" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + dateTimePicker1.Text + "','" + domainUpDown10.Text + ":" + domainUpDown9.Text + "." + comboBox18.Text + "','" + domainUpDown6.Text + ":" + domainUpDown5.Text + "." + comboBox17.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

               // display_data1();
                //display_nosession();
                // display_data1();
                //   display_data2();
                MessageBox.Show("Submit Data Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            dateTimePicker1.Text = "";
            domainUpDown10.Text = "";
            domainUpDown9.Text = "";
            domainUpDown6.Text = "";
            domainUpDown5.Text = "";
            comboBox18.Text = "";
            comboBox17.Text = "";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update nosession set selclec='" + comboBox20.Text + "',selgrp='" + comboBox19.Text + "',selsubgrp='" + comboBox12.Text + "',seldate='" + textBox38.Text + "' ,selsttime='" + textBox29.Text + "',selentime='" + textBox37.Text + "' where id='" + textBox13.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
              //  display_nosession();

                //display_data2();
                MessageBox.Show("update succcess");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from nosession where id='" + textBox13.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
                //display_nosession();
                // display_data2();
                MessageBox.Show("delete succesfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from nosession where id='" + textBox13.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView9.DataSource = dt;
            con.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {

                if (radioButton7.Checked == true)
                {
                    t1 = "thirt mint";
                }
                else
                    if (radioButton8.Checked == true)
                {
                    t1 = "one hours";
                }
                else
                {
                    t1 = "two hours";
                }
                //check

                /*if (checkBox20.Checked == true)
                {
                    che = "monday";
                }else if(checkBox15.Checked == true)
                {
                    che = "tuesday";
                }
                else if (checkBox19.Checked == true)
                {
                    che = "wendnesday";
                }
                else if (checkBox18.Checked)
                {
                    che = "thursday";
                }
                else if (checkBox17.Checked)
                {
                    che = "friday";
                }
                else if (checkBox16.Checked)
                {
                    che = "saturday";
                }
                else if (checkBox7.Checked)
                {
                    che = "sunday";
                } */



                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into work_per1 values('" + domainUpDown8.Text + "','" + m + "','" + t + "','" + w + "','" + th + "','" + f + "','" + s + "','" + sun + "','" + domainUpDown14.Text + ":" + domainUpDown13.Text + "." + comboBox13.Text + "','" + domainUpDown12.Text + ":" + domainUpDown11.Text + "." + comboBox14.Text + "','" + t1 + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                //display_data1();
               // display_data1();
                //   display_data2();
                MessageBox.Show("Insert Data Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
