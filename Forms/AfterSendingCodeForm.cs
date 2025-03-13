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
    public partial class AfterSendingCodeForm : Form
    {

        private Point MouseLocation;
        public AfterSendingCodeForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //close the app
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát chương trình", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //minimize the app
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //for movable form
        private void mouse_Down(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newMousePoint = Control.MousePosition;
                newMousePoint.Offset(MouseLocation.X, MouseLocation.Y);
                Location = newMousePoint;
            }
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewPassword newPsw = new CreateNewPassword();
            newPsw.Show();
        }

        private void sendCodeAgainLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MainForgotPassword forgotPsw = new MainForgotPassword();
            forgotPsw.Show();
        }

        private void loginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MainRegisterForm registerForm = new MainRegisterForm();
            registerForm.Show();
        }
    }
}
