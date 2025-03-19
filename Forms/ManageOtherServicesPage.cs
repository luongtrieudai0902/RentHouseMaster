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
    public partial class ManageOtherServicesPage : Form
    {
        private List<Services> servicesList = new List<Services>();
        public ManageOtherServicesPage()
        {
            InitializeComponent();
            LoadRoomData();
            servicesDataGridView.EnableHeadersVisualStyles = false;
        }

        private void LoadRoomData()
        {

            servicesList.Add(new Services { nha = "22L Quận 7", giatui = "250", vesinh = "100", internet = "100" });
            servicesList.Add(new Services { nha = "22L Quận 8", giatui = "250", vesinh = "100", internet = "200" });

            servicesDataGridView.DataSource = null;
            servicesDataGridView.DataSource = servicesList;

            servicesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // set headers
            servicesDataGridView.Columns[0].HeaderText = "Nhà";
            servicesDataGridView.Columns[1].HeaderText = "Giật ủi";
            servicesDataGridView.Columns[2].HeaderText = "Vệ sinh";
            servicesDataGridView.Columns[3].HeaderText = "Internet";
            //roomDataGridView.Columns[4].HeaderText = "Chức năng";
        }
    }

    public class Services
    {
        public string nha { get; set; }
        public string giatui { get; set; }
        public string vesinh { get; set; }
        public string internet { get; set; }

    }
}
