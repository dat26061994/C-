using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if((txtUsername.Text == "") || (txtPassword.Text == ""))
            {
                MessageBox.Show("Please enter username and password !");
            }
            else if((txtUsername.Text != "admin") || (txtPassword.Text != "123456"))
            {
                MessageBox.Show("Wrong username or password !");
            }
            else
            {
                Form1 mainFrm = new Form1();
                mainFrm.Show();
            }
        }
    }
}
