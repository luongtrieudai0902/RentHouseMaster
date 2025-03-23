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
    public partial class ManageTransportationPage : Form
    {
        private List<Transportation> transportationList = new List<Transportation>();
        public ManageTransportationPage()
        {
            InitializeComponent();
            LoadRoomData();
            TransportDataGridView.EnableHeadersVisualStyles = false;
        }

        private void LoadRoomData()
        {

            transportationList.Add(new Transportation { nha = "22L Quận 7", soluongxe = "2", chotrong = "30", tongphi = "100" });
            transportationList.Add(new Transportation { nha = "22L Quận 8", soluongxe = "4", chotrong = "10", tongphi = "200" });

            TransportDataGridView.DataSource = null;
            TransportDataGridView.DataSource = transportationList;

            TransportDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // set headers
            TransportDataGridView.Columns[0].HeaderText = "Nhà";
            TransportDataGridView.Columns[1].HeaderText = "Số lượng xe";
            TransportDataGridView.Columns[2].HeaderText = "Chỗ trống";
            TransportDataGridView.Columns[3].HeaderText = "Tổng phí";
            //roomDataGridView.Columns[4].HeaderText = "Chức năng";

            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
            linkColumn.HeaderText = "Chức năng";
            linkColumn.Name = "XemNha";
            linkColumn.Text = "Xem nhà";
            linkColumn.UseColumnTextForLinkValue = true; //repeative text for all rows

            TransportDataGridView.Columns.Add(linkColumn);
        }
    }

    public class Transportation
    {
        public string nha { get; set; }
        public string soluongxe { get; set; }
        public string chotrong { get; set; }
        public string tongphi { get; set; }

    }
}
