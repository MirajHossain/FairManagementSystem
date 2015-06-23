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
    public partial class ZoneTypeWiseVisitorUI : Form
    {
        public ZoneTypeWiseVisitorUI()
        {
            InitializeComponent();
        }
        ZoneManager aZoneManager = new ZoneManager();
        VisitorZoneManager aVisitorZoneManager = new VisitorZoneManager();
        private void ZoneTypeWiseVisitorUI_Load(object sender, EventArgs e)
        {
            int sum = 0;
            List<Zone> zones = aZoneManager.GetZone();
            foreach (Zone zone in zones)
            {
                var noOfVisitor=  aVisitorZoneManager.SearchVisitorUnderZone(zone.ZoneId);
                ListViewItem aListViewItem = new ListViewItem(zone.ZoneName);
                aListViewItem.SubItems.Add(noOfVisitor.ToString());
                showZoneListView.Items.Add(aListViewItem);
                sum = sum + noOfVisitor;
            }
            totalTextBox.Text = sum.ToString();
        }

      
    }
}
