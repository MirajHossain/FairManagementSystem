using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementSystem.BLL;
using FairManagementSystem.DAL.DAO;
using Excel= Microsoft.Office.Interop.Excel;

namespace FairManagementSystem.UI
{
    public partial class ZoneSpecificVistorDetailsUI : Form
    {
        Zone aZone = new Zone();
        ZoneManager aZoneManager = new ZoneManager();
        Visitor aVisitor = new Visitor();
        VisitorManager aVisitorManager = new VisitorManager();
        VisitorZoneManager aVisitorZoneManager = new VisitorZoneManager();
        public ZoneSpecificVistorDetailsUI()
        {
            InitializeComponent();
        }

        private void ZoneSpecificVistorDetailsUI_Load(object sender, EventArgs e)
        {
            LoadZoneInComboBox();
            List<Visitor> visitors = aVisitorManager.GetAllVisitor(aVisitor);
            visitorInfoListView.Items.Clear();
            foreach (Visitor visitor in visitors)
            {
                ListViewItem item = new ListViewItem(visitor.Name);
              
                item.SubItems.Add(visitor.Email);
                item.SubItems.Add(visitor.ContactNumber);
                visitorInfoListView.Items.Add(item);
                totalTextBox.Text = visitors.Count.ToString();
            } 

        }

        private void LoadZoneInComboBox()
        {
            List<Zone> zoneList = aZoneManager.GetZone();
            selectZoneCombobox.DisplayMember = "ZoneName";
            selectZoneCombobox.ValueMember = "ZoneId";
            selectZoneCombobox.DataSource = null;
            selectZoneCombobox.DataSource = zoneList;
        }

        private void exportDataButton_Click(object sender, EventArgs e)
        {
            Excel.Application aExcelApplication = new Excel.Application();
            Excel.Workbook workbook = null;
            Excel.Workbooks workbooks = null;
            Excel._Worksheet worksheet = null;
            workbooks = aExcelApplication.Workbooks;
            workbook = workbooks.Add(1);
            worksheet = (Excel.Worksheet)workbook.Sheets[1];
            aExcelApplication.Visible = true;
            worksheet.Cells[1, 1] = "Name";
            worksheet.Cells[1, 2] = "Email";
            worksheet.Cells[1, 3] = "Contact Number";
            int i = 1;
            int zoneId = int.Parse(selectZoneCombobox.SelectedValue.ToString());
            List<Visitor> visitors = aVisitorManager.GetAllVisitor(zoneId);
            foreach (Visitor visitor in visitors)
            {
                i++;
               
                worksheet.Cells[i, 1] = visitor.Name;
                worksheet.Cells[i, 2] = visitor.Email;
                worksheet.Cells[i, 3] = visitor.ContactNumber;
                worksheet.Cells.Rows.AutoFit();
                worksheet.Cells.Columns.AutoFit();
            }
          
        }

        private void showVisitorDetailsButton_Click(object sender, EventArgs e)
        {
            totalTextBox.Text = string.Empty;
            visitorInfoListView.Items.Clear();
            int zoneId = int.Parse(selectZoneCombobox.SelectedValue.ToString());
            List<VisitorZone> visitors = aVisitorZoneManager.SearchByZoneId(zoneId);
            foreach (VisitorZone visitor in visitors)
            {
                ListViewItem aListViewItem = new ListViewItem(visitor.Name);
                aListViewItem.SubItems.Add(visitor.Email);
                aListViewItem.SubItems.Add(visitor.ContactNumber);
                visitorInfoListView.Items.Add(aListViewItem);
                totalTextBox.Text = visitors.Count.ToString();
            }
           
        }

        
    }
}
