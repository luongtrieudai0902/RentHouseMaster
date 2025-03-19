using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentHouseMaster.Forms
{
    public partial class ManageRoomPage : Form
    {
        private List<Room> roomList = new List<Room>();

        public ManageRoomPage()
        {
            InitializeComponent();
            LoadRoomData();
            roomDataGridView.EnableHeadersVisualStyles = false;
        }

        private void LoadRoomData()
        {

            roomList.Add(new Room { nha = "22L Quận 7", phongtrong = "2", phongchuathanhtoan = "0", hethanhopdong = "1" });
            roomList.Add(new Room { nha = "22L Quận 8", phongtrong = "3", phongchuathanhtoan = "0", hethanhopdong = "0" });
            roomList.Add(new Room { nha = "25M Quận 7", phongtrong = "1/2", phongchuathanhtoan = "0", hethanhopdong = "2" });

            roomDataGridView.DataSource = null;
            roomDataGridView.DataSource = roomList;

            roomDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // set headers
            roomDataGridView.Columns[0].HeaderText = "Nhà";
            roomDataGridView.Columns[1].HeaderText = "Phòng trống";
            roomDataGridView.Columns[2].HeaderText = "Phòng chưa thanh toán";
            roomDataGridView.Columns[3].HeaderText = "Sắp hết hạn hợp đồng";
            //roomDataGridView.Columns[4].HeaderText = "Chức năng";
        }
    }

    public class Room
    {
        public string nha { get; set; }
        public string phongtrong { get; set; }
        public string phongchuathanhtoan { get; set; }
        public string hethanhopdong { get; set; }

    }
}
