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
            houseDataGridView.EnableHeadersVisualStyles = false;
        }

        private void LoadRoomData()
        {

            roomList.Add(new Room { nha = "22L Quận 7", phongtrong = "2", phongchuathanhtoan = "0", hethanhopdong = "1" });
            roomList.Add(new Room { nha = "22L Quận 8", phongtrong = "3", phongchuathanhtoan = "0", hethanhopdong = "0" });
            roomList.Add(new Room { nha = "25M Quận 7", phongtrong = "1/2", phongchuathanhtoan = "0", hethanhopdong = "2" });

            houseDataGridView.DataSource = null;
            houseDataGridView.DataSource = roomList;

            houseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // set headers
            houseDataGridView.Columns[0].HeaderText = "Nhà";
            houseDataGridView.Columns[1].HeaderText = "Phòng trống";
            houseDataGridView.Columns[2].HeaderText = "Phòng chưa thanh toán";
            houseDataGridView.Columns[3].HeaderText = "Sắp hết hạn hợp đồng";

            //adding the link column for data grid view 
            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
            linkColumn.HeaderText = "Chức năng";
            linkColumn.Name = "XemNha";
            linkColumn.Text = "Xem nhà";
            linkColumn.UseColumnTextForLinkValue = true; //repeative text for all rows

            houseDataGridView.Columns.Add(linkColumn);
        }

        private void roomDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (houseDataGridView.Columns[e.ColumnIndex].Name == "XemNha" && e.RowIndex >= 0)
            {
                // Get the selected house data
                string houseName = houseDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                HouseDetailPage houseDetailPage = new HouseDetailPage();

                MainMenuForm mainMenuForm = (MainMenuForm)this.ParentForm;
                mainMenuForm.OpenChildForm(houseDetailPage);
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
}