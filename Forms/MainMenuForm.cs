using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using RentHouseMaster.Models;

namespace RentHouseMaster.Forms
{
    public partial class MainMenuForm : Form
    {
        public Point MouseLocation;
        private Boolean isExpanded = false;
        // Dictionary to store default icons
        private Dictionary<Button, Image> defaultIcons = new Dictionary<Button, Image>();

        private UserModel loggedInUser = null;
       
        public MainMenuForm(UserModel user)
        {
            InitializeComponent();

            this.loggedInUser = user;

            // Hiển thị thông tin người dùng lên giao diện
            if (loggedInUser != null)
            {
                lblEmail.Text = loggedInUser.Email;
                lblUsername.Text = loggedInUser.Username;
            }
           

            this.FormBorderStyle = FormBorderStyle.None; // Remove window border
            subPanelForAccomo.Visible = false;
            subPanelForServices.Visible = false;
            subPanelForTools.Visible = false;
        }


        public MainMenuForm()
        {
            InitializeComponent();
            
            this.FormBorderStyle = FormBorderStyle.None; // Remove window border
            subPanelForAccomo.Visible = false;
            subPanelForServices.Visible = false;
            subPanelForTools.Visible = false;

            // Store default icons
            defaultIcons[homeBtn] = Properties.Resources.home;
            defaultIcons[manageAccomoBtn] = Properties.Resources.account;
            defaultIcons[registerAccomoBtn] = Properties.Resources.register;
            defaultIcons[manageRoomBtn] = Properties.Resources.house;
            defaultIcons[manageServicesBtn] = Properties.Resources.hug;
            defaultIcons[manageElectricsBtn] = Properties.Resources.electric;
            defaultIcons[manageOtherServicesBtn] = Properties.Resources.room_service;
            defaultIcons[manageTransportationBtn] = Properties.Resources.cycle;
            defaultIcons[requestBtn] = Properties.Resources.mask;
            defaultIcons[manageToolsBtn] = Properties.Resources.tools;
            defaultIcons[printBtn] = Properties.Resources.electric;
            defaultIcons[helpBtn] = Properties.Resources.help;
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

        //maximize the app
        private void btnMaximize_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
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

        //adding hover effect
        private void btn_Hover(Button clickedBtn)
        {
            ResetButtonColors();

            // Highlight the clicked button
            clickedBtn.BackColor = Color.FromArgb(50, 105, 232);
            clickedBtn.ForeColor = Color.White;

            // Change icon to white
            if (clickedBtn == homeBtn)
            {
                clickedBtn.Image = Properties.Resources.home_white;
            }
            else if (clickedBtn == manageAccomoBtn)
            {
                clickedBtn.Image = Properties.Resources.account_white;
            }
            else if (clickedBtn == registerAccomoBtn)
            {
                clickedBtn.Image = Properties.Resources.register_white;
            }
            else if (clickedBtn == manageRoomBtn)
            {
                clickedBtn.Image = Properties.Resources.add_white;
            }
            else if (clickedBtn == manageServicesBtn)
            {
                clickedBtn.Image = Properties.Resources.hug_white;
            }
            else if (clickedBtn == manageElectricsBtn || clickedBtn == printBtn)
            {
                clickedBtn.Image = Properties.Resources.lightning;
            }
            else if (clickedBtn == manageOtherServicesBtn)
            {
                clickedBtn.Image = Properties.Resources.room_service_white;
            }
            else if (clickedBtn == manageTransportationBtn)
            {
                clickedBtn.Image = Properties.Resources.cycle_white;
            }
            else if (clickedBtn == requestBtn)
            {
                clickedBtn.Image = Properties.Resources.mask_white;
            }
            else if (clickedBtn == manageToolsBtn)
            {
                clickedBtn.Image = Properties.Resources.tool_white;
            }
            else if (clickedBtn == helpBtn)
            {
                clickedBtn.Image = Properties.Resources.help_white;
            }
        }

        private void ResetButtonColors()
        {
            List<Button> buttons = new List<Button>
            {
                homeBtn,
                manageAccomoBtn,
                registerAccomoBtn,
                manageRoomBtn,
                manageServicesBtn,
                manageElectricsBtn,
                manageOtherServicesBtn,
                manageTransportationBtn,
                requestBtn,
                manageToolsBtn,
                printBtn,
                helpBtn,
                logoutBtn
            };

            // Reset all buttons to default color and restore default icons
            foreach (Button btn in buttons)
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;

                if (defaultIcons.ContainsKey(btn))
                {
                    btn.Image = defaultIcons[btn];
                }
            }
        }

        private Form formHienTai = null;
        public void OpenChildForm(Form formmoi)
        {
            if (formHienTai != null)
            {
                formHienTai.Close();  // Close the previous form
            }

            formHienTai = formmoi;
            formmoi.TopLevel = false;
            formmoi.FormBorderStyle = FormBorderStyle.None;
            formmoi.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(formmoi);
            formmoi.BringToFront();
            formmoi.Show();
        }

        private void manageAccomoBtn_Click(object sender, EventArgs e)
        {
            isExpanded = !isExpanded;
            subPanelForAccomo.Visible = isExpanded;
            expandPicAccomo.Image = isExpanded ? Properties.Resources.Dropdown : Properties.Resources.expend;

            //hover
            btn_Hover((Button)sender);
            
            
        }

        private void manageServicesBtn_Click(object sender, EventArgs e)
        {
            isExpanded = !isExpanded;
            subPanelForServices.Visible = isExpanded;
            expandPicServices.Image = isExpanded ? Properties.Resources.Dropdown : Properties.Resources.expend;

            //hover
            btn_Hover((Button)sender);
        }

        private void manageToolsBtn_Click(object sender, EventArgs e)
        {
            isExpanded = !isExpanded;
            subPanelForTools.Visible = isExpanded;
            expandPicforTools.Image = isExpanded ? Properties.Resources.Dropdown : Properties.Resources.expend;

            //hover
            btn_Hover((Button)sender);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            //hover
            btn_Hover((Button)sender);
            HomePage homePage = new HomePage();
            OpenChildForm(homePage);
        }

        private void registerAccomoBtn_Click(object sender, EventArgs e)
        {
            //hover
            btn_Hover((Button)sender);
            RegisterAccomodationPage register = new RegisterAccomodationPage();
            OpenChildForm(register);
        }

        private void manageRoomBtn_Click(object sender, EventArgs e)
        {
            //hover
            btn_Hover((Button)sender);
            ManageRoomPage manageRoomPage = new ManageRoomPage();
            OpenChildForm(manageRoomPage);
        }

        private void manageElectricsBtn_Click(object sender, EventArgs e)
        {
            //hover
            btn_Hover((Button)sender);
            ManageElectricsPage manageElectricsPage = new ManageElectricsPage();
            OpenChildForm(manageElectricsPage);
        }

        private void manageOtherServicesBtn_Click(object sender, EventArgs e)
        {
            //hover
            btn_Hover((Button)sender);
            ManageOtherServicesPage manageOtherServicesPage = new ManageOtherServicesPage();    
            OpenChildForm(manageOtherServicesPage);
        }

        private void manageTransportationBtn_Click(object sender, EventArgs e)
        {
            //hover
            btn_Hover((Button)sender);
            ManageTransportationPage manageTransportationPage = new ManageTransportationPage();
            OpenChildForm(manageTransportationPage);
        }

        private void requestBtn_Click(object sender, EventArgs e)
        {
            //hover
            btn_Hover((Button)sender);
            RequestPage requestPage = new RequestPage();
            OpenChildForm(requestPage);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            //hover
            btn_Hover((Button)sender);
            PrintDocPage printDocPage = new PrintDocPage();
            OpenChildForm(printDocPage);
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            //hover
            btn_Hover((Button)sender);
            HelpPage helpPage = new HelpPage(); 
            OpenChildForm(helpPage);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            //hover
            btn_Hover((Button)sender);

            MainLoginForm mainRegisterForm = new MainLoginForm();
            this.Hide();
            mainRegisterForm.Show();
        }
    }
}
