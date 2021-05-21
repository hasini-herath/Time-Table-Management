using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TimeManagement1
{
    public partial class location1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Desktop\TimeManagement\TimeManagement1\TimeManagement1\timemanagement.mdf;Integrated Security=True;Connect Timeout=30");
        public location1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into location values('"+ comboBox24.Text+"','"+ comboBox25.Text+ "','" + comboBox22.Text + "','" + textBox3.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("locations saved");

            display_data();

        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            

        }

        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from location";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           // dataGridView//2.DataSource = dt;
            con.Close();
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void location1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timemanagementDataSet54.subjectrooms' table. You can move, or remove it, as needed.
            this.subjectroomsTableAdapter.Fill(this.timemanagementDataSet54.subjectrooms);
            // TODO: This line of code loads data into the 'timemanagementDataSet53.location' table. You can move, or remove it, as needed.
            this.locationTableAdapter6.Fill(this.timemanagementDataSet53.location);
            // TODO: This line of code loads data into the 'timemanagementDataSet52.consecutiveroom' table. You can move, or remove it, as needed.
            this.consecutiveroomTableAdapter.Fill(this.timemanagementDataSet52.consecutiveroom);
            // TODO: This line of code loads data into the 'timemanagementDataSet51.location' table. You can move, or remove it, as needed.
            this.locationTableAdapter5.Fill(this.timemanagementDataSet51.location);
            // TODO: This line of code loads data into the 'timemanagementDataSet50.consecutive' table. You can move, or remove it, as needed.
            this.consecutiveTableAdapter1.Fill(this.timemanagementDataSet50.consecutive);
            // TODO: This line of code loads data into the 'timemanagementDataSet49.consecutive' table. You can move, or remove it, as needed.
          //  this.consecutiveTableAdapter.Fill(this.timemanagementDataSet49.consecutive);
            // TODO: This line of code loads data into the 'timemanagementDataSet48.roomGroup' table. You can move, or remove it, as needed.
            this.roomGroupTableAdapter1.Fill(this.timemanagementDataSet48.roomGroup);
            // TODO: This line of code loads data into the 'timemanagementDataSet47.roomGroup' table. You can move, or remove it, as needed.
            this.roomGroupTableAdapter.Fill(this.timemanagementDataSet47.roomGroup);
            // TODO: This line of code loads data into the 'timemanagementDataSet46.session_tble' table. You can move, or remove it, as needed.
            this.session_tbleTableAdapter4.Fill(this.timemanagementDataSet46.session_tble);
            // TODO: This line of code loads data into the 'timemanagementDataSet45.location' table. You can move, or remove it, as needed.
            this.locationTableAdapter4.Fill(this.timemanagementDataSet45.location);
            // TODO: This line of code loads data into the 'timemanagementDataSet44.subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter4.Fill(this.timemanagementDataSet44.subject);
            // TODO: This line of code loads data into the 'timemanagementDataSet43.subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter3.Fill(this.timemanagementDataSet43.subject);
            // TODO: This line of code loads data into the 'timemanagementDataSet42.lecturerroom' table. You can move, or remove it, as needed.
            this.lecturerroomTableAdapter2.Fill(this.timemanagementDataSet42.lecturerroom);
            // TODO: This line of code loads data into the 'timemanagementDataSet41.lecturerroom' table. You can move, or remove it, as needed.
            this.lecturerroomTableAdapter1.Fill(this.timemanagementDataSet41.lecturerroom);
            // TODO: This line of code loads data into the 'timemanagementDataSet40.lecturerroom' table. You can move, or remove it, as needed.
            this.lecturerroomTableAdapter.Fill(this.timemanagementDataSet40.lecturerroom);
            // TODO: This line of code loads data into the 'timemanagementDataSet39.location' table. You can move, or remove it, as needed.
            this.locationTableAdapter3.Fill(this.timemanagementDataSet39.location);
            // TODO: This line of code loads data into the 'timemanagementDataSet38.subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter2.Fill(this.timemanagementDataSet38.subject);
            // TODO: This line of code loads data into the 'timemanagementDataSet37.subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter1.Fill(this.timemanagementDataSet37.subject);
            // TODO: This line of code loads data into the 'timemanagementDataSet36.Lecturer1' table. You can move, or remove it, as needed.
            this.lecturer1TableAdapter.Fill(this.timemanagementDataSet36.Lecturer1);
            // TODO: This line of code loads data into the 'timemanagementDataSet35.tagroom' table. You can move, or remove it, as needed.
            this.tagroomTableAdapter3.Fill(this.timemanagementDataSet35.tagroom);
            // TODO: This line of code loads data into the 'timemanagementDataSet34.tagroom' table. You can move, or remove it, as needed.
            this.tagroomTableAdapter2.Fill(this.timemanagementDataSet34.tagroom);
            // TODO: This line of code loads data into the 'timemanagementDataSet33.tagroom' table. You can move, or remove it, as needed.
            this.tagroomTableAdapter1.Fill(this.timemanagementDataSet33.tagroom);
            // TODO: This line of code loads data into the 'timemanagementDataSet32.tagroom' table. You can move, or remove it, as needed.
            this.tagroomTableAdapter.Fill(this.timemanagementDataSet32.tagroom);
            // TODO: This line of code loads data into the 'timemanagementDataSet31.tagnew' table. You can move, or remove it, as needed.
            this.tagnewTableAdapter.Fill(this.timemanagementDataSet31.tagnew);
            // TODO: This line of code loads data into the 'timemanagementDataSet30.location' table. You can move, or remove it, as needed.
            this.locationTableAdapter2.Fill(this.timemanagementDataSet30.location);
            // TODO: This line of code loads data into the 'timemanagementDataSet29.sessRoom' table. You can move, or remove it, as needed.
            this.sessRoomTableAdapter1.Fill(this.timemanagementDataSet29.sessRoom);
            // TODO: This line of code loads data into the 'timemanagementDataSet28.session_tble' table. You can move, or remove it, as needed.
            this.session_tbleTableAdapter3.Fill(this.timemanagementDataSet28.session_tble);
            // TODO: This line of code loads data into the 'timemanagementDataSet27.session_tble' table. You can move, or remove it, as needed.
            this.session_tbleTableAdapter2.Fill(this.timemanagementDataSet27.session_tble);
            // TODO: This line of code loads data into the 'timemanagementDataSet26.session_tble' table. You can move, or remove it, as needed.
            this.session_tbleTableAdapter1.Fill(this.timemanagementDataSet26.session_tble);
            // TODO: This line of code loads data into the 'timemanagementDataSet25.session_tble' table. You can move, or remove it, as needed.
            this.session_tbleTableAdapter.Fill(this.timemanagementDataSet25.session_tble);
            // TODO: This line of code loads data into the 'timemanagementDataSet24.sess_tble' table. You can move, or remove it, as needed.
            this.sess_tbleTableAdapter7.Fill(this.timemanagementDataSet24.sess_tble);
            // TODO: This line of code loads data into the 'timemanagementDataSet23.sess_tble' table. You can move, or remove it, as needed.
            this.sess_tbleTableAdapter6.Fill(this.timemanagementDataSet23.sess_tble);
            // TODO: This line of code loads data into the 'timemanagementDataSet22.sess_tble' table. You can move, or remove it, as needed.
            this.sess_tbleTableAdapter5.Fill(this.timemanagementDataSet22.sess_tble);
            // TODO: This line of code loads data into the 'timemanagementDataSet21.sess_tble' table. You can move, or remove it, as needed.
            // this.sess_tbleTableAdapter4.Fill(this.timemanagementDataSet21.sess_tble);
            // TODO: This line of code loads data into the 'timemanagementDataSet20.sessRoom' table. You can move, or remove it, as needed.
            // this.sessRoomTableAdapter.Fill(this.timemanagementDataSet20.sessRoom);
            // TODO: This line of code loads data into the 'timemanagementDataSet19.location' table. You can move, or remove it, as needed.
            this.locationTableAdapter1.Fill(this.timemanagementDataSet19.location);
            // TODO: This line of code loads data into the 'timemanagementDataSet18.sess_tble' table. You can move, or remove it, as needed.
         //   this.sess_tbleTableAdapter3.Fill(this.timemanagementDataSet18.sess_tble);
            // TODO: This line of code loads data into the 'timemanagementDataSet17.sess_tble' table. You can move, or remove it, as needed.
         //   this.sess_tbleTableAdapter2.Fill(this.timemanagementDataSet17.sess_tble);
            // TODO: This line of code loads data into the 'timemanagementDataSet16.sess_tble' table. You can move, or remove it, as needed.
            // this.sess_tbleTableAdapter2.Fill(this.timemanagementDataSet16.sess_tble);
            // TODO: This line of code loads data into the 'timemanagementDataSet15.sess_tble' table. You can move, or remove it, as needed.
         //   this.sess_tbleTableAdapter1.Fill(this.timemanagementDataSet15.sess_tble);
            // TODO: This line of code loads data into the 'timemanagementDataSet14.sess_tble' table. You can move, or remove it, as needed.
          //  this.sess_tbleTableAdapter.Fill(this.timemanagementDataSet14.sess_tble);
            // TODO: This line of code loads data into the 'timemanagementDataSet13.session' table. You can move, or remove it, as needed.
            // this.sessionTableAdapter3.Fill(this.timemanagementDataSet13.session);
            // TODO: This line of code loads data into the 'timemanagementDataSet11.session' table. You can move, or remove it, as needed.
            // this.sessionTableAdapter2.Fill(this.timemanagementDataSet11.session);
            // TODO: This line of code loads data into the 'timemanagementDataSet10.session' table. You can move, or remove it, as needed.
            // this.sessionTableAdapter1.Fill(this.timemanagementDataSet10.session);
            // TODO: This line of code loads data into the 'timemanagementDataSet9.session' table. You can move, or remove it, as needed.
            //this.sessionTableAdapter.Fill(this.timemanagementDataSet9.session);
            // TODO: This line of code loads data into the 'timemanagementDataSet8.session_table' table. You can move, or remove it, as needed.
            //this.session_tableTableAdapter.Fill(this.timemanagementDataSet8.session_table);
            // TODO: This line of code loads data into the 'timemanagementDataSet7.session_t' table. You can move, or remove it, as needed.
            // this.session_tTableAdapter3.Fill(this.timemanagementDataSet7.session_t);
            // TODO: This line of code loads data into the 'timemanagementDataSet6.session_t' table. You can move, or remove it, as needed.
            //   this.session_tTableAdapter2.Fill(this.timemanagementDataSet6.session_t);
            // TODO: This line of code loads data into the 'timemanagementDataSet5.session_t' table. You can move, or remove it, as needed.
            // this.session_tTableAdapter1.Fill(this.timemanagementDataSet5.session_t);
            // TODO: This line of code loads data into the 'timemanagementDataSet4.session_t' table. You can move, or remove it, as needed.
            // this.session_tTableAdapter.Fill(this.timemanagementDataSet4.session_t);
            // TODO: This line of code loads data into the 'timemanagementDataSet3.location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.timemanagementDataSet3.location);
            // TODO: This line of code loads data into the 'timemanagementDataSet2.subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.timemanagementDataSet2.subject);
            display_data();

        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox10.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            comboBox26.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            comboBox27.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            comboBox23.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            textBox7.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
        }


        private void dataGridView4_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
           /* int rowIndex = e.RowIndex;
            textBox2.Text = dataGridView4.Rows[rowIndex].Cells[0].Value.ToString();
            comboBox4.Text = dataGridView4.Rows[rowIndex].Cells[1].Value.ToString();
            comboBox5.Text = dataGridView4.Rows[rowIndex].Cells[2].Value.ToString();
            comboBox6.Text = dataGridView4.Rows[rowIndex].Cells[3].Value.ToString();
            textBox11.Text = dataGridView4.Rows[rowIndex].Cells[4].Value.ToString();
            textBox12.Text = dataGridView4.Rows[rowIndex].Cells[5].Value.ToString();
            textBox13.Text = dataGridView4.Rows[rowIndex].Cells[6].Value.ToString();
           */ 
        }



        /*    //test manage session rooms
            private void dataGridView4_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
            {
                int rowIndex = e.RowIndex;

                comboBox1.Text = dataGridView4.Rows[rowIndex].Cells[1].Value.ToString();

            }

        */



        //test Manage session rooms

        //test

        /*  public void display_data1()
          {
              con.Open();
              SqlCommand cmd = con.CreateCommand();
              cmd.CommandType = CommandType.Text;
              cmd.CommandText = "select * from session_t";
              cmd.ExecuteNonQuery();
              DataTable dt = new DataTable();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(dt);
              dataGridView4.DataSource = dt;
              // dataGridView//2.DataSource = dt;
              con.Close();
          } */





        //test






        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update location set buildingname='" + comboBox26.Text + "',roomname='" + comboBox27.Text + "',roomtype='" + comboBox23.Text + "',capacity='" + textBox7.Text + "'  where id='" + textBox10.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
                display_data();
                //display_data2();
                MessageBox.Show("update succcess");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from location where id='" + textBox10.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                display_data();
                display_data();
                display_data();
                MessageBox.Show("delete succesfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox24.Text = "";
            comboBox25.Text = "";
            comboBox22.Text = "";
            textBox3.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox10.Text = "";
            comboBox26.Text = "";
            comboBox27.Text = "";
            comboBox23.Text = "";
            textBox7.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from location where id='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tagroom values('" + textBox9.Text + "','" + textBox22.Text + "','" + textBox21.Text + "','" + comboBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Rooms for tags saved");

            display_data();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        

        
        private void button12_Click(object sender, EventArgs e)
       {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into sessRoom values('" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + comboBox1.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Rooms for sessions saved");

            display_data();

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
           


        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                string query = "SELECT * FROM session_tble WHERE sessionId = '" + comboBox2.Text + "'";
                SqlCommand cmd;
                cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBox2.Text = reader["sessionId"].ToString();
                    textBox4.Text = reader["lecturer1"].ToString();
                    textBox5.Text = reader["lecturer2"].ToString();
                    textBox6.Text = reader["subjectcode"].ToString();
                    textBox11.Text = reader["subjectname"].ToString();
                    textBox12.Text = reader["groupId"].ToString();
                    textBox13.Text = reader["tag"].ToString();



                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" +ex);
            }
            

           
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox2.Text = dataGridView4.Rows[rowIndex].Cells[0].Value.ToString();
            textBox4.Text = dataGridView4.Rows[rowIndex].Cells[1].Value.ToString();
            textBox5.Text = dataGridView4.Rows[rowIndex].Cells[2].Value.ToString();
            textBox6.Text = dataGridView4.Rows[rowIndex].Cells[3].Value.ToString();
            textBox11.Text = dataGridView4.Rows[rowIndex].Cells[4].Value.ToString();
            textBox12.Text = dataGridView4.Rows[rowIndex].Cells[5].Value.ToString();
            textBox13.Text = dataGridView4.Rows[rowIndex].Cells[6].Value.ToString();
            
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox2.Text = dataGridView2.Rows[rowIndex].Cells[0].Value.ToString();
            textBox4.Text = dataGridView2.Rows[rowIndex].Cells[1].Value.ToString();
            textBox5.Text = dataGridView2.Rows[rowIndex].Cells[2].Value.ToString();
            textBox6.Text = dataGridView2.Rows[rowIndex].Cells[3].Value.ToString();
            textBox11.Text = dataGridView2.Rows[rowIndex].Cells[4].Value.ToString();
            textBox12.Text = dataGridView2.Rows[rowIndex].Cells[5].Value.ToString();
            textBox13.Text = dataGridView2.Rows[rowIndex].Cells[6].Value.ToString();
            comboBox1.Text = dataGridView2.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from sessRoom where sessId='" + textBox8.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                display_data();
                display_data();
                display_data();
                MessageBox.Show("delete succesfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox8.Text = dataGridView2.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update sessRoom set lecturer1='" + textBox4.Text + "',lecturer2='" + textBox5.Text + "',subjectcode='" + textBox6.Text + "',subject='" + textBox11.Text + "',grpId='" + textBox12.Text + "',tag='" + textBox13.Text + "',room='" + comboBox1.Text + "'  where sessId='" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
                display_data();
                //display_data2();
                MessageBox.Show("update succcess");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into tagnew values('" + textBox9.Text + "','" + textBox22.Text + "','" + textBox21.Text + "','" + comboBox4.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("session rooms saved");

                display_data();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Session id cannot be repeated ");
                con.Close();
            }
        }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox18.Text = dataGridView3.Rows[rowIndex].Cells[0].Value.ToString();
            textBox9.Text = dataGridView3.Rows[rowIndex].Cells[1].Value.ToString();
            textBox22.Text = dataGridView3.Rows[rowIndex].Cells[2].Value.ToString();
            textBox21.Text = dataGridView3.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void dataGridView5_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dataGridView5_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox17.Text = dataGridView5.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from tagroom where tagRoomID='" + textBox17.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                display_data();
                display_data();
                display_data();
                MessageBox.Show("delete succesfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView6_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            


        }

        private void button16_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into lecturerroom values('" + comboBox6.Text + "','" + comboBox7.Text + "','" + comboBox3.Text + "','" + comboBox9.Text + "','" + comboBox5.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("selected rooms saved");

            display_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update lecturerroom set lecturerName='" + comboBox6.Text + "',subject='" + comboBox7.Text + "',subjectCode='" + comboBox3.Text + "',room='" + comboBox9.Text + "',tag='" + comboBox5.Text + "'  where lecturerRoomId='" + textBox19.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
                display_data();
                //display_data2();
                MessageBox.Show("update succcess");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView6_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox19.Text = dataGridView6.Rows[rowIndex].Cells[0].Value.ToString();
            comboBox6.Text = dataGridView6.Rows[rowIndex].Cells[1].Value.ToString();
            comboBox7.Text = dataGridView6.Rows[rowIndex].Cells[2].Value.ToString();
            comboBox3.Text = dataGridView6.Rows[rowIndex].Cells[3].Value.ToString();
            comboBox9.Text = dataGridView6.Rows[rowIndex].Cells[4].Value.ToString();
            comboBox5.Text = dataGridView6.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from lecturerroom where lecturerRoomId='" + textBox19.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                display_data();
                display_data();
                display_data();
                MessageBox.Show("delete succesfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView7_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox20.Text = dataGridView7.Rows[rowIndex].Cells[0].Value.ToString();
            comboBox8.Text = dataGridView7.Rows[rowIndex].Cells[1].Value.ToString();
            comboBox10.Text = dataGridView7.Rows[rowIndex].Cells[2].Value.ToString();
            comboBox12.Text = dataGridView7.Rows[rowIndex].Cells[3].Value.ToString();
            comboBox11.Text = dataGridView7.Rows[rowIndex].Cells[4].Value.ToString();
            comboBox16.Text = dataGridView7.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into roomGroup values('" + comboBox8.Text + "','" + comboBox10.Text + "','" + comboBox12.Text + "','" + comboBox11.Text + "','" + comboBox16.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Rooms for groups saved");

            display_data();

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update roomGroup set groupId='" + comboBox8.Text + "',subject='" + comboBox10.Text + "',subjectCode='" + comboBox12.Text + "',tag='" + comboBox11.Text + "',room='" + comboBox16.Text + "'  where Id='" + textBox20.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
                display_data();
                //display_data2();
                MessageBox.Show("update succcess");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView3_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from roomGroup where Id='" + textBox20.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                display_data();
                display_data();
                display_data();
                MessageBox.Show("delete succesfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView8_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox14.Text = dataGridView8.Rows[rowIndex].Cells[0].Value.ToString();
            comboBox13.Text = dataGridView8.Rows[rowIndex].Cells[1].Value.ToString();
           
            comboBox17.Text = dataGridView8.Rows[rowIndex].Cells[2].Value.ToString();
            comboBox14.Text = dataGridView8.Rows[rowIndex].Cells[3].Value.ToString();
            comboBox15.Text = dataGridView8.Rows[rowIndex].Cells[4].Value.ToString();
           
        }

        private void button20_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into consecutiveroom values('" + comboBox13.Text + "','" + comboBox17.Text + "','" + comboBox14.Text + "','" + comboBox15.Text + "','" + comboBox18.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Rooms for consecutive sessions saved");

            display_data();
        }

        private void dataGridView9_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox15.Text = dataGridView9.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from consecutiveroom where Id='" + textBox15.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                display_data();
                display_data();
                display_data();
                MessageBox.Show("delete succesfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView10_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox16.Text = dataGridView10.Rows[rowIndex].Cells[0].Value.ToString();
            textBox25.Text = dataGridView10.Rows[rowIndex].Cells[1].Value.ToString();
            textBox24.Text = dataGridView10.Rows[rowIndex].Cells[2].Value.ToString();
            comboBox19.Text = dataGridView10.Rows[rowIndex].Cells[3].Value.ToString();
            comboBox20.Text = dataGridView10.Rows[rowIndex].Cells[4].Value.ToString();
           

        }

        private void button21_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into subjectrooms values('" + textBox25.Text + "','" + textBox24.Text + "','" + comboBox19.Text + "','" + comboBox20.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("saved");

            display_data();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update subjectrooms set subjectcode='" + textBox25.Text + "',subjectname='" + textBox24.Text + "',tag='" + comboBox19.Text + "',room='" + comboBox20.Text + "'  where Id='" + textBox16.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                // display_data();
                display_data();
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
                cmd.CommandText = "delete from subjectrooms where Id='" + textBox16.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                display_data();
                display_data();
                display_data();
                MessageBox.Show("delete succesfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
