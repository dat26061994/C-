using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial.SqlConn;

namespace FootbalClubManagement
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();

            
        }

        private void GradientPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        Point lastPoint;

        private void GradientPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }




        private static void queryLogin(MySqlConnection conn)
        {
            
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {

            //Khai báo kết nối DB
            MySqlConnection conn = null;
            MySqlDataReader rdr = null;

            try
            {
                //Kết nối DB
                conn = DBUtils.GetDBConnection();
                conn.Open();


                string query = "SELECT * FROM admin WHERE id = 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //Compare data
                    string username = rdr.GetString(1);
                    string password = rdr.GetString(2);
                    
                    if ((txtUsername.Text == "") || (txtPassword.Text == ""))
                    {
                        MessageBox.Show("Please enter username and password !");
                    }
                    else if ((txtUsername.Text != username) || (txtPassword.Text != password))
                    {
                        MessageBox.Show("Wrong username or password !");
                    }
                    else
                    {
                        MessageBox.Show("Login Successful !");
                        this.Hide();
                        Form1 mainFrm = new Form1();
                        mainFrm.Show();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: {0}", ex.ToString());
            }
            finally
            {
                if(rdr != null)
                {
                    rdr.Close();
                }
                if(conn != null)
                {
                    conn.Close();
                }
            }


            


            
        }
    }
}
