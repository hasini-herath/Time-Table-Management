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
    public partial class Statistics : Form
    {


        public Statistics()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Connect to the database
            String str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Desktop\TimeManagement\TimeManagement1\TimeManagement1\timemanagement.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            //create a command
            string query = "SELECT COUNT(roomname) FROM location";


            try
            {
                con.Open();
                // label1.ForeColor = Color.Green;
                // label1.Text = "Database successfully connected!!!";


                cmd = new SqlCommand(query, con);

                //Read from db

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();


                //Display data on the page
                label3.ForeColor = Color.Black;

                label3.Text = "No of locations = " + rows_count.ToString();




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }

            }


            //No of lecture halls


            //create a command
            string query1 = "SELECT COUNT(roomtype) FROM location WHERE roomtype = 'LECTURE HALL' GROUP BY roomtype";


            try
            {
                con.Open();
                // label1.ForeColor = Color.Green;
                //label1.Text = "Database successfully connected!!!";


                cmd = new SqlCommand(query1, con);

                //Read from db

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();


                //Display data on the page
                label4.ForeColor = Color.Black;

                label4.Text = "No of Lecture halls = " + rows_count.ToString();




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }




            }


            //No of laboratories

            //create a command
            string query2 = "SELECT COUNT(roomtype) FROM location WHERE roomtype = 'LABORATORY' GROUP BY roomtype";



            try
            {
                con.Open();
                //label1.ForeColor = Color.Green;
                //label1.Text = "Database successfully connected!!!";


                cmd = new SqlCommand(query2, con);

                //Read from db

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();


                //Display data on the page
                label5.ForeColor = Color.Black;

                label5.Text = "No of laboratories = " + rows_count.ToString();




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }
            }

            //NO of lecturers

            //create a command
            string query12 = "SELECT COUNT(lecturernme) FROM Lecturer1";


            try
            {
                con.Open();
                // label1.ForeColor = Color.Green;
                //label1.Text = "Database successfully connected!!!";


                cmd = new SqlCommand(query12, con);

                //Read from db

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();


                //Display data on the page
                label6.ForeColor = Color.Black;

                label6.Text = "No of Lecturers = " + rows_count.ToString();




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }

            }


            //create a command
            string query45 = "SELECT COUNT(studentnme) FROM student";


            try
            {
                con.Open();
                // label1.ForeColor = Color.Green;
                //  label1.Text = "Database successfully connected!!!";


                cmd = new SqlCommand(query45, con);

                //Read from db

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();


                //Display data on the page
                label7.ForeColor = Color.Black;

                label7.Text = "No of students = " + rows_count.ToString();




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }
            }

            //No of subjects
            //create a command
            string query34 = "SELECT COUNT(roomname) FROM location";


            try
            {
                con.Open();
                // label1.ForeColor = Color.Green;
                //label1.Text = "Database successfully connected!!!";


                cmd = new SqlCommand(query34, con);

                //Read from db

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();


                //Display data on the page
                label2.ForeColor = Color.Black;

                label2.Text = "No of Brand = " + rows_count.ToString();




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }

            }

            //No of subjects
            //create a command
            string query78 = "SELECT COUNT(subcode) FROM subject";


            try
            {
                con.Open();
                //label1.ForeColor = Color.Green;
                //label1.Text = "Database successfully connected!!!";


                cmd = new SqlCommand(query78, con);

                //Read from db

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();


                //Display data on the page
                label8.ForeColor = Color.Black;

                label8.Text = "No of subjects = " + rows_count.ToString();




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }


            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.chart1.Series["Location"].Points.AddXY("Lecture hall", 8);
            this.chart1.Series["Location"].Points.AddXY("Laboratory", 4);

          
        }
    }
    }
        

