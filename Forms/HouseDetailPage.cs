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
    public partial class HouseDetailPage : Form
    {

        private List<RoomInfo> roomDetailList = new List<RoomInfo>();
        public HouseDetailPage()
        {
            InitializeComponent();
            LoadRoomData();
            roomDataGridView.EnableHeadersVisualStyles = false;
        }


        private void LoadRoomData()
        {
            roomDetailList.Add(new RoomInfo { room = "001", noOfPeople = "Trong", price = "200.000" });
            roomDetailList.Add(new RoomInfo { room = "002", noOfPeople = "2", price = "200.000" });

            roomDataGridView.DataSource = null;
            roomDataGridView.DataSource = roomDetailList;
            roomDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            roomDataGridView.Columns[0].HeaderText = "Phòng";
            roomDataGridView.Columns[1].HeaderText = "Số người ở";
            roomDataGridView.Columns[2].HeaderText = "Giá phòng";

            //adding the link columns for data grid view 
            DataGridViewLinkColumn contractColumn = new DataGridViewLinkColumn();
            contractColumn.HeaderText = "Chức năng";
            contractColumn.Name = "Contract";
            contractColumn.Text = "Xem hợp đồng";
            contractColumn.UseColumnTextForLinkValue = true; //repeative text for all rows

            DataGridViewLinkColumn rentHistoryColumn = new DataGridViewLinkColumn();
            rentHistoryColumn.HeaderText = "";
            rentHistoryColumn.Name = "RentHistory";
            rentHistoryColumn.Text = "Lịch sử thuê";
            rentHistoryColumn.UseColumnTextForLinkValue = true;

            DataGridViewLinkColumn editColumn = new DataGridViewLinkColumn();
            editColumn.HeaderText = "";
            editColumn.Name = "Edit";
            editColumn.Text = "Chính sửa";
            editColumn.UseColumnTextForLinkValue = true;

            roomDataGridView.Columns.Add(contractColumn);
            roomDataGridView.Columns.Add(rentHistoryColumn);
            roomDataGridView.Columns.Add(editColumn);
        }

        private void roomDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (roomDataGridView.Columns[e.ColumnIndex].Name == "Contract" && e.RowIndex >= 0)
            {
                // Get the selected house data
                string houseName = roomDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                RentalContractPage rentalContractPage = new RentalContractPage();

                MainMenuForm mainMenuForm = (MainMenuForm)this.ParentForm;
                mainMenuForm.OpenChildForm(rentalContractPage);
            }
            else if (roomDataGridView.Columns[e.ColumnIndex].Name == "RentHistory" && e.RowIndex >= 0)
            {
                // Get the selected house data
                string houseName = roomDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                RentalHistoryPage rentalHistoryPage = new RentalHistoryPage();

                MainMenuForm mainMenuForm = (MainMenuForm)this.ParentForm;
                mainMenuForm.OpenChildForm(rentalHistoryPage);
            }
            else if (roomDataGridView.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex >= 0)
            {
                // Get the selected house data
                string houseName = roomDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                EditRoomPage editRoomPage = new EditRoomPage();

                MainMenuForm mainMenuForm = (MainMenuForm)this.ParentForm;
                mainMenuForm.OpenChildForm(editRoomPage);
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            ManageRoomPage manageRoomPage = new ManageRoomPage();

            MainMenuForm mainMenuForm = (MainMenuForm)this.ParentForm;
            mainMenuForm.OpenChildForm(manageRoomPage);
        }
    }

    public class RoomInfo
    {
        public string room { get; set; }
        public string noOfPeople { get; set; }

        public string price { get; set; }
    }

}
