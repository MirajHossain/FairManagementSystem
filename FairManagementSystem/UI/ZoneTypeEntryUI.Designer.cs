namespace FairManagementSystem.UI
{
    partial class ZoneTypeEntryUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.GrayText, null);
            this.zoneTypeSaveButton = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.zoneNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showZoneNameListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zoneTypeSaveButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // zoneTypeSaveButton
            // 
            this.zoneTypeSaveButton.Controls.Add(this.saveButton);
            this.zoneTypeSaveButton.Controls.Add(this.zoneNameTextBox);
            this.zoneTypeSaveButton.Controls.Add(this.label1);
            this.zoneTypeSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneTypeSaveButton.Location = new System.Drawing.Point(88, 75);
            this.zoneTypeSaveButton.Name = "zoneTypeSaveButton";
            this.zoneTypeSaveButton.Size = new System.Drawing.Size(449, 132);
            this.zoneTypeSaveButton.TabIndex = 0;
            this.zoneTypeSaveButton.TabStop = false;
            this.zoneTypeSaveButton.Text = "Zone Type";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(329, 76);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 29);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // zoneNameTextBox
            // 
            this.zoneNameTextBox.Location = new System.Drawing.Point(150, 34);
            this.zoneNameTextBox.Name = "zoneNameTextBox";
            this.zoneNameTextBox.Size = new System.Drawing.Size(254, 26);
            this.zoneNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name";
            // 
            // showZoneNameListView
            // 
            this.showZoneNameListView.BackColor = System.Drawing.SystemColors.GrayText;
            this.showZoneNameListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.showZoneNameListView.FullRowSelect = true;
            this.showZoneNameListView.GridLines = true;
            listViewItem1.UseItemStyleForSubItems = false;
            this.showZoneNameListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.showZoneNameListView.Location = new System.Drawing.Point(88, 281);
            this.showZoneNameListView.Name = "showZoneNameListView";
            this.showZoneNameListView.Size = new System.Drawing.Size(449, 203);
            this.showZoneNameListView.TabIndex = 1;
            this.showZoneNameListView.UseCompatibleStateImageBehavior = false;
            this.showZoneNameListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 385;
            // 
            // ZoneTypeEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::FairManagementSystem.Properties.Resources.Contentbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 522);
            this.Controls.Add(this.showZoneNameListView);
            this.Controls.Add(this.zoneTypeSaveButton);
            this.Name = "ZoneTypeEntryUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zone Type Entry";
            this.Load += new System.EventHandler(this.ZoneTypeEntryUI_Load);
            this.zoneTypeSaveButton.ResumeLayout(false);
            this.zoneTypeSaveButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox zoneTypeSaveButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox zoneNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView showZoneNameListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}