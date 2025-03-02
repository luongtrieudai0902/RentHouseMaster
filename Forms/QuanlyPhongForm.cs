using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentHouseMaster.Forms
{
    public partial class QuanlyPhongForm : Form
    {

        //variable declaration
        private string filePath = "phongdata.txt";
        private List<Phong> roomList = new List<Phong>();
        public QuanlyPhongForm()
        {
            InitializeComponent();
            LoadRoomData(filePath);
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {

        }

        private void LoadRoomData(string filePath)
        {
            if (File.Exists(filePath))
            {
                roomList.Clear();

                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length == 0)
                {
                    MessageBox.Show("The file is empty!");
                    return;
                }

                foreach (var line in lines)
                {
                    var parts = line.Split('\t');
                    if (parts.Length == 4)
                    {
                        roomList.Add(new Phong
                        {
                            phongNo = parts[0],
                            soluong = parts[1],
                            chiphi = parts[2],
                            date = parts[3],
                        });
                    }
                }

                roomDataGridView.DataSource = null;
                roomDataGridView.DataSource = roomList;

                roomDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // set headers
                roomDataGridView.Columns[0].HeaderText = "Phòng";
                roomDataGridView.Columns[1].HeaderText = "Số lượng";
                roomDataGridView.Columns[2].HeaderText = "Chưa thanh toán";
                roomDataGridView.Columns[3].HeaderText = "Hạn hợp đồng";

            }
        }

        private void QuanlyPhong_Shown(object sender, EventArgs e)
        {
            specificCellFormatting();
        }


        private void specificCellFormatting()
        {
            foreach (DataGridViewRow row in roomDataGridView.Rows)
            {
                if ((row.Cells[1].Value?.ToString() == "Trống")
)
                {
                    row.Cells[1].Style.BackColor = Color.FromArgb(200, 255, 215);
                    row.Cells[1].Style.ForeColor = Color.FromArgb(70, 197, 100);
                }
                else
                {
                    row.Cells[1].Style.BackColor = Color.FromArgb(255, 200, 201);
                    row.Cells[1].Style.ForeColor = Color.FromArgb(197, 70, 72);
                }

                if (row.Cells[3].Value != null)
                {
                    string dateText = row.Cells[3].Value.ToString().Trim();
                    DateTime contractDate;

                    if (DateTime.TryParseExact(dateText, "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out contractDate) ||
                        DateTime.TryParseExact(dateText, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out contractDate) ||
                        DateTime.TryParse(dateText, out contractDate))
                    {
                        if (contractDate < DateTime.Today)
                        {
                            row.Cells[3].Style.ForeColor = Color.FromArgb(211, 0, 14);
                        }
                    }

                }
            }

            roomDataGridView.ClearSelection();


        }
    }
    public class Phong
    {
        public string phongNo { get; set; }
        public string soluong { get; set; }
        public string chiphi { get; set; }
        public string date { get; set; }

    }
}

