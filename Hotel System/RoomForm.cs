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
    public partial class RoomForm : Form
    {
        RoomClass room = new RoomClass();
        public RoomForm()
        {
            InitializeComponent();
        }

        

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            //To Show a room type in combobox
            comboBox_roomType.DataSource = room.getRoomType();
            comboBox_roomType.DisplayMember = "Label";
            comboBox_roomType.ValueMember = "CategoryId";

            //To show  a room list in Datagridview 
          //  getRoomList();

            dataGridView_room.DefaultCellStyle.ForeColor = Color.Black;
        }
    }
}
