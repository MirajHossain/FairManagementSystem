using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementSystem.BLL;
using FairManagementSystem.DAL.DAO;

namespace FairManagementSystem.UI
{
    public partial class ZoneTypeEntryUI : Form
    {
        Zone aZone = new Zone();
        ZoneManager aZoneManager = new ZoneManager();
        Visitor aVisitor = new Visitor();
        VisitorManager aVisitorManager = new VisitorManager();
        VisitorZoneManager avVisitorZoneManager = new VisitorZoneManager();
        public ZoneTypeEntryUI()
        {

            InitializeComponent();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           
            aZone.ZoneName = zoneNameTextBox.Text;
            zoneNameTextBox.Text = string.Empty;
            aZoneManager.Save(aZone);
            LoadAllZone();
        }
        private void ZoneTypeEntryUI_Load(object sender, EventArgs e)
        {

            LoadAllZone();

        }
        private void LoadAllZone()
        {
            List<Zone> zones = aZoneManager.GetZone();
            showZoneNameListView.Items.Clear();
            foreach (Zone zone in zones)
            {
                ListViewItem item = new ListViewItem(zone.ZoneId.ToString());
                item.SubItems.Add(zone.ZoneName);
                showZoneNameListView.Items.Add(item);
            }
        }
    }
}
