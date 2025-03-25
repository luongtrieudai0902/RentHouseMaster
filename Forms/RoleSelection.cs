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
    public partial class RoleSelection : Form
    {
        public RoleSelection()
        {
            InitializeComponent();
        }
        private void OpenLoginForm(string role)
        {
            MainLoginForm loginForm = new MainLoginForm(role);
            loginForm.Show();
            this.Hide();
        }

        private void btnChuNha_Click(object sender, EventArgs e)
        {
            OpenLoginForm("ChuNha");
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenLoginForm("NhanVien");
        }

        private void btnKhachThue_Click(object sender, EventArgs e)
        {
            OpenLoginForm("KhachThue");
        }

        private void lblChuaCoTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MainRegisterForm mainRegisterForm = new MainRegisterForm();
            mainRegisterForm.Show();
        }
    }
}
