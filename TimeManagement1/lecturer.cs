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

namespace TimeManagement1
{
    public partial class lecturer : Form
    {
        
        public lecturer()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void display_data1()
        {
           
        }

        public void display_data2()
        {
           
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into addlec values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox8.Text + "','" + comboBox7.Text + "','" + comboBox9.Text + "','" + textBox10.Text + "')";
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
            comboBox9.Text = "";

            textBox10.Text = "";
        }

        private void lecturer_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                textBox10.Text = comboBox9.Text + "." + textBox2.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from addlec where lecna='" + textBox9.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            display_data1();
            display_data2();
        }
    }

        private void button6_Click(object sender, EventArgs e)
        {
        try
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update addlec set lecna='" + textBox9.Text + "',fact='" + comboBox12.Text + "',dept='" + comboBox11.Text + "',cent='" + comboBox10.Text + "' ,build='" + comboBox4.Text + "',levl='" + comboBox3.Text + "',rnk='" + textBox3.Text + "' where lecid='" + textBox4.Text + "'";
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
            cmd.CommandText = "delete from addlec where lecid='" + textBox4.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            // display_data();
            display_data1();
            //  display_data2();
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
        textBox4.Text = "";
        comboBox12.Text = "";
        comboBox11.Text = "";
        comboBox10.Text = "";
        comboBox4.Text = "";
        comboBox3.Text = "";

        textBox3.Text = "";
    }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
        try
        {
            if (radioButton1.Checked == true)
            {
                g = "1st sem";
            }
            else
            {
                g = "2nd sem";
            }

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into addsub values('" + comboBox5.Text + "','" + g + "','" + textBox5.Text + "','" + textBox6.Text + "','" + domainUpDown1.Text + "','" + domainUpDown2.Text + "','" + domainUpDown3.Text + "','" + domainUpDown4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            display_data2();
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
        private void button7_Click(object sender, EventArgs e)
        {

        {
            comboBox5.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            domainUpDown1.Text = "";
            domainUpDown2.Text = "";
            domainUpDown3.Text = "";
            domainUpDown4.Text = "";

        }
    }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        int rowIndex = e.RowIndex;
        comboBox6.Text = dataGridView2.Rows[rowIndex].Cells[1].Value.ToString();
        //  textBox4.Text = dataGridView2.Rows[rowIndex].Cells[2].Value.ToString();
        textBox7.Text = dataGridView2.Rows[rowIndex].Cells[3].Value.ToString();
        textBox8.Text = dataGridView2.Rows[rowIndex].Cells[4].Value.ToString();
        domainUpDown8.Text = dataGridView2.Rows[rowIndex].Cells[5].Value.ToString();
        domainUpDown7.Text = dataGridView2.Rows[rowIndex].Cells[6].Value.ToString();
        domainUpDown6.Text = dataGridView2.Rows[rowIndex].Cells[7].Value.ToString();

        domainUpDown5.Text = dataGridView2.Rows[rowIndex].Cells[8].Value.ToString();
    }

        private void button10_Click_1(object sender, EventArgs e)
        {
        comboBox6.Text = "";
        textBox7.Text = "";
        textBox8.Text = "";

        domainUpDown5.Text = "";
        domainUpDown6.Text = "";
        domainUpDown7.Text = "";
        domainUpDown8.Text = "";
    }

        private void button13_Click(object sender, EventArgs e)
        {
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from addsub where modn='" + textBox7.Text + "'";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        dataGridView2.DataSource = dt;
        con.Close();
    }
        private void button15_Click(object sender, EventArgs e)
        {
        display_data2();
    }

        private void button11_Click_1(object sender, EventArgs e)
        {
        try
        {
            if (radioButton1.Checked == true)
            {
                g = "1st sem";
            }
            else
            {
                g = "2nd sem";
            }

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update addsub set year='" + comboBox6.Text + "',sem='" + g + "',modn='" + textBox7.Text + "',nlh='" + domainUpDown8.Text + "' ,nth='" + domainUpDown7.Text + "',nlab='" + domainUpDown6.Text + "',neh='" + domainUpDown5.Text + "' where mcode='" + textBox8.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            // display_data();
            // display_data1();
            display_data2();
            MessageBox.Show("update succcess");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

        private void button9_Click_1(object sender, EventArgs e)
        {
        try
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from addsub where mcode='" + textBox8.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            // display_data();
            display_data2();
            //  display_data2();
            MessageBox.Show("delete succesfull!");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        nb9 
    }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
