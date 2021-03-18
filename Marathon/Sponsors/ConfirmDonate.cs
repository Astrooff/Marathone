using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;
using Marathon.Database;

namespace Marathon.Sponsors
{
    public partial class ConfirmDonate : MetroFramework.Forms.MetroForm
    {
        public ConfirmDonate()
        {
            InitializeComponent();
            showInfoDonate();
        }
        public void showInfoDonate()
        {
            metrolabelNameRunner.Text = $"{AddSponsors.fullName[0]} {AddSponsors.fullName[2]} {AddSponsors.fullName[4]}";
            labelFund.Text = AddSponsors.sponsorName;
            labelCountDonate.Text = $"${AddSponsors.num}.00";
        }
    }
}
