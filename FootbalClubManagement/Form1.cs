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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }



        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {

            lastPoint = new Point(e.X, e.Y);
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if(SidePanel.Width == 75)
            {
                SidePanel.Visible = false;
                SidePanel.Width = 260;
                PanelTransition.ShowSync(SidePanel);
                logoTransition.ShowSync(logo);
            }
            else
            {
                logoTransition.Hide(logo);
                SidePanel.Visible = false;
                SidePanel.Width = 75;
                PanelTransition.ShowSync(SidePanel);
            }
        }

        private void btn_Menu_Click_1(object sender, EventArgs e)
        {
            if (SidePanel.Width == 75)
            {
                SidePanel.Visible = false;
                SidePanel.Width = 260;
                PanelTransitionOut.ShowSync(SidePanel, false, null);
                logoTransition.ShowSync(logo);
            }
            else
            {
                logoTransition.Hide(logo);
                SidePanel.Visible = false;
                SidePanel.Width = 75;
                PanelTransition.ShowSync(SidePanel, false, null);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
