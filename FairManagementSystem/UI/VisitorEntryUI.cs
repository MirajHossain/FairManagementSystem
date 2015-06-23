using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FairManagementSystem.BLL;
using FairManagementSystem.DAL.DAO;

namespace FairManagementSystem.UI
{
    public partial class VisitorEntryUI : Form
    {
        public VisitorEntryUI()
        {
            InitializeComponent();

        }
        ZoneManager aZoneManager = new ZoneManager();
        VisitorManager aVisitorManager = new VisitorManager();
        VisitorZoneManager avVisitorZoneManager = new VisitorZoneManager();
        Visitor aVisitor = new Visitor();
        private CheckBox aCheckBox;
        private GroupBox aGroupBox;
       
        private void VisitorEntryUI_Load_1(object sender, EventArgs e)
        {
            this.AutoSize = false;
            aGroupBox = new GroupBox();
            aGroupBox.Name = "GroupBox";
            aGroupBox.Text = "Select Zone";
            aGroupBox.Width = 548;
            aGroupBox.Height = 230;
            aGroupBox.BackColor = Color.Gray;
            aGroupBox.ForeColor = Color.GhostWhite;
            aGroupBox.Location = new Point(50, 240);
            aGroupBox.AutoSize = true;
            this.Controls.Add(aGroupBox);
            int innitialOffset = 0;
            int xDistance = 120;
            int yDistance = 10;
            List<Zone> listZone = aZoneManager.GetZone();
            int i = 0;
            foreach (Zone zone in listZone)
            {
                i=i+2;

                aCheckBox = new CheckBox();
                aCheckBox.Tag = zone.ZoneId;
                aCheckBox.Text = zone.ZoneName;
                aCheckBox.AutoSize = true;
                aCheckBox.Checked = true;
                aCheckBox.Location = new Point(innitialOffset + xDistance, (xDistance-100) + i * yDistance);
                aGroupBox.Controls.Add(aCheckBox);

            }

        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            aVisitor.Name = nameTextBox.Text;
            aVisitor.Email = emailTextBox.Text;
            aVisitor.ContactNumber = numberTextBox.Text;
            int id = aVisitorManager.Save(aVisitor);
            List<Zone> listZone = aZoneManager.GetZone();
            if (aCheckBox.Checked == true)
            {
                foreach (Zone zone in listZone)
                {
                    VisitorZone aVisitorZone = new VisitorZone();
                    aVisitorZone.ZoneId = zone.ZoneId;
                    aVisitorZone.VistorId = id;
                    avVisitorZoneManager.Save(aVisitorZone);

                }
                MessageBox.Show("Saved visitor");
            }
                
          
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            nameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            numberTextBox.Text = string.Empty;
        }

        


    }

}
