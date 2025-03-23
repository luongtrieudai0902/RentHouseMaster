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
    public partial class RegisterAccomodationPage : Form
    {
        public RegisterAccomodationPage()
        {
            InitializeComponent();

            //adding data to gender box
            genderBox.Items.Add("Nam");
            genderBox.Items.Add("Nữ");

            nationalityBox.Items.Add("Vietnam");
            nationalityBox.Items.Add("Myanmar");
            nationalityBox.Items.Add("Lao");
            nationalityBox.Items.Add("Cambodia");
        }
    }
}
