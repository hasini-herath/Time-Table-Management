using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace timetablepro
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            String mainconn = ConfigurationManager.ConnectionStrings["TimeManagement1.Properties.Settings.time1ConnectionString1"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);


            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {
                bool checkboxselected = Convert.ToBoolean(dr.Cells["chekBoxColum"].Value);
                if (checkboxselected)
                {


                    string sqlquery = "insert into consec values(@selec,@selgrp,@selsub,@seltag,@nostu,@duration)";
                    //  if (dr.IsNewRow) continue;
                    //   {

                    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);


                    // cmd.Parameters.AddWithValue("@id", dr.Cells[1].Value);
                    sqlcomm.Parameters.AddWithValue("@selec", dr.Cells[2].Value ?? DBNull.Value);
                    sqlcomm.Parameters.AddWithValue("@selgrp", dr.Cells[3].Value ?? DBNull.Value);
                    sqlcomm.Parameters.AddWithValue("@selsub", dr.Cells[4].Value ?? DBNull.Value);
                    sqlcomm.Parameters.AddWithValue("@seltag", dr.Cells[5].Value ?? DBNull.Value);
                    sqlcomm.Parameters.AddWithValue("@nostu", dr.Cells[6].Value ?? DBNull.Value);
                    sqlcomm.Parameters.AddWithValue("@duration", dr.Cells[7].Value ?? DBNull.Value);

                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();

                    display_session();
                    display_consec();
                    // display_data1();
                    //   display_data2();
                    MessageBox.Show("Add Data Successfully!");

                }
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from consec where id='" + textBox30.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
                display_consec();
                // display_data2();
                MessageBox.Show("delete succesfull!");
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
                cmd.CommandText = "insert into parl values('" + textBox36.Text + "','" + textBox35.Text + "','" + textBox34.Text + "','" + textBox33.Text + "','" + textBox32.Text + "','" + textBox31.Text + "','" + textBox3.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                display_session();
                display_parl();
                // display_data1();
                //   display_data2();
                MessageBox.Show("Add Data Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from parl where id='" + textBox42.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
                display_parl();
                // display_data2();
                MessageBox.Show("delete succesfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into non values('" + textBox28.Text + "','" + textBox27.Text + "','" + textBox26.Text + "','" + textBox25.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox2.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                display_session();
                display_non();
                // display_data1();
                //   display_data2();
                MessageBox.Show("Add Data Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from non where id='" + textBox11.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
                display_non();
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
