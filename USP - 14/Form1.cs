using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace USP___14
{
    public partial class Form1 : Form
    {
        UserControlInsertRevenue USRevenue = new UserControlInsertRevenue();
        UserControlInsertExpense USExpense = new UserControlInsertExpense();
        UserControlSearch USserch = new UserControlSearch();
        UserControlStatistics USstatistics = new UserControlStatistics();
      

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Form1()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
        }

        private void panel_Mouse_Down(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel_Mouse_Up(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel_Mouse_Move(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            USExpense.Hide();
            USserch.Hide();
            USstatistics.Hide();
            USRevenue.Show();
            USRevenue.Dock = DockStyle.Fill;
            this.Controls.Add(USRevenue);
        }

        private void flatButtonCreareExpense_Click(object sender, EventArgs e)
        {     
            USRevenue.Hide();
            USserch.Hide();
            USstatistics.Hide();
            USExpense.Show();
            USExpense.Dock = DockStyle.Fill;
            this.Controls.Add(USExpense);
        }

        private void flatButtonSearch_Click(object sender, EventArgs e)
        {
            USRevenue.Hide();
            USExpense.Hide();
            USstatistics.Hide();
            USserch.Show();
            USserch.Dock = DockStyle.Fill;
            this.Controls.Add(USserch);
        }

        private void flatButtonStatistics_Click(object sender, EventArgs e)
        {          USRevenue.Hide();
            USExpense.Hide();
            USserch.Hide();
            USstatistics.Show();
            USstatistics.Dock = DockStyle.Fill;
            this.Controls.Add(USstatistics);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
