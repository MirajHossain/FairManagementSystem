using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FairManagementSystem.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
           
        }
       
        private void visitorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           VisitorEntryUI aVisitorEntryUi = new VisitorEntryUI();
            aVisitorEntryUi.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zoneTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeEntryUI aZoneTypeEntryUi = new ZoneTypeEntryUI();
            aZoneTypeEntryUi.Show();
        }

        private void zoneWiseDetailsVisitorInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneSpecificVistorDetailsUI aZoneSpecificVistorDetailsUi = new ZoneSpecificVistorDetailsUI();
            aZoneSpecificVistorDetailsUi.Show();
        }

        private void zoneWiseVisitorNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeWiseVisitorUI aZoneTypeWiseVisitorUi = new ZoneTypeWiseVisitorUI();
            aZoneTypeWiseVisitorUi.Show();
        }
    }
}
