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
    public partial class location : Form
    {
        SqlConnection con = new SqlConnection(@"Server=tcp:time-table-manage.database.windows.net,1433;Initial Catalog=timeaz;Persist Security Info=False;User ID=piya;Password=sachin123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public location()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into nolocation values('" + comboBox16.Text + "','" + dateTimePicker1.Text + "','" + numericUpDown12.Text + ":" + numericUpDown8.Text + "." + comboBox19.Text + "','" + numericUpDown7.Text + ":" + numericUpDown9.Text + "." + comboBox18.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

              //  display_nolocation();
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

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox16.Text = "";
            // textBox10.Text = "";
            dateTimePicker1.Text = "";

            numericUpDown12.Text = "";
            numericUpDown8.Text = "";

            numericUpDown7.Text = "";

            numericUpDown7.Text = "";

            comboBox19.Text = "";
            comboBox18.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update nolocation set selloc='" + comboBox17.Text + "',seldate='" + textBox11.Text + "',st='" + textBox8.Text + "',en='" + textBox10.Text + "'  where id='" + textBox9.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
                //display_nolocation();

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
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from nolocation where id='" + textBox9.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
               // display_nolocation();
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
            textBox9.Text = "";
            comboBox17.Text = "";
            textBox11.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from nolocation where id='" + textBox9.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }
    }
}
