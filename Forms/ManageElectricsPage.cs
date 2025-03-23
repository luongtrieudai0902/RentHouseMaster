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
    public partial class ManageElectricsPage : Form
    {
        private List<Electrics> electricList = new List<Electrics>();
        public ManageElectricsPage()
        {
            InitializeComponent();
            LoadRoomData();
            roomDataGridView.EnableHeadersVisualStyles = false;
        }

        private void LoadRoomData()
        {

            electricList.Add(new Electrics { nha = "22L Quận 7", chiphi = "250", khoinuoc = "100", sodien = "1"});
            electricList.Add(new Electrics { nha = "22L Quận 8", chiphi = "250", khoinuoc = "100", sodien = "2" });

            roomDataGridView.DataSource = null;
            roomDataGridView.DataSource = electricList;

            roomDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // set headers
            roomDataGridView.Columns[0].HeaderText = "Nhà";
            roomDataGridView.Columns[1].HeaderText = "Chi phí";
            roomDataGridView.Columns[2].HeaderText = "Khởi nước";
            roomDataGridView.Columns[3].HeaderText = "Số điện";
            //roomDataGridView.Columns[4].HeaderText = "Chức năng";

            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
            linkColumn.HeaderText = "Chức năng";
            linkColumn.Name = "XemNha";
            linkColumn.Text = "Xem nhà";
            linkColumn.UseColumnTextForLinkValue = true; //repeative text for all rows

            roomDataGridView.Columns.Add(linkColumn);
        }
    }

    public class Electrics
    {
        public string nha { get; set; }
        public string chiphi { get; set; }
        public string khoinuoc { get; set; }
        public string sodien { get; set; }

    }

}

