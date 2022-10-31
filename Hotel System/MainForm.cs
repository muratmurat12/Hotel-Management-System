using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_guest.Height; 
            panel_slide.Top = button_guest.Top;

            panel_cover.Controls.Clear();
            GuestForm guestForm = new GuestForm();
            guestForm.TopLevel=false;
            guestForm.Dock = DockStyle.Fill;
            guestForm.FormBorderStyle = FormBorderStyle.None;
            panel_cover.Controls.Add(guestForm);
            guestForm.Show();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            panel_slide.Height =button_dashboard.Height;
            panel_slide.Top =button_dashboard.Top; 
            
            panel_main.Controls.Clear();
            panel_main.Controls.Add(panel_cover);
        }

        private void button_reception_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_reception.Height;
            panel_slide.Top = button_reception.Top;


        }

        private void button_room_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_room.Height;
            panel_slide.Top = button_room.Top;

            panel_main.Controls.Clear();
            RoomForm room = new RoomForm();
            room.TopLevel = false;
            room.Dock = DockStyle.Fill;
            room.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(room);
            room.Show();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_logout.Height;
            panel_slide.Top = button_logout.Top;

            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
