namespace FairManagementSystem.UI
{
    partial class ZoneSpecificVistorDetailsUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectZoneCombobox = new System.Windows.Forms.ComboBox();
            this.showVisitorDetailsButton = new System.Windows.Forms.Button();
            this.exportDataButton = new System.Windows.Forms.Button();
            this.visitorInfoListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Zone";
            // 
            // selectZoneCombobox
            // 
            this.selectZoneCombobox.FormattingEnabled = true;
            this.selectZoneCombobox.Location = new System.Drawing.Point(180, 47);
            this.selectZoneCombobox.Name = "selectZoneCombobox";
            this.selectZoneCombobox.Size = new System.Drawing.Size(270, 21);
            this.selectZoneCombobox.TabIndex = 2;
            // 
            // showVisitorDetailsButton
            // 
            this.showVisitorDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showVisitorDetailsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showVisitorDetailsButton.Location = new System.Drawing.Point(456, 45);
            this.showVisitorDetailsButton.Name = "showVisitorDetailsButton";
            this.showVisitorDetailsButton.Size = new System.Drawing.Size(118, 27);
            this.showVisitorDetailsButton.TabIndex = 3;
            this.showVisitorDetailsButton.Text = "Show";
            this.showVisitorDetailsButton.UseVisualStyleBackColor = true;
            this.showVisitorDetailsButton.Click += new System.EventHandler(this.showVisitorDetailsButton_Click);
            // 
            // exportDataButton
            // 
            this.exportDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportDataButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exportDataButton.Location = new System.Drawing.Point(433, 472);
            this.exportDataButton.Name = "exportDataButton";
            this.exportDataButton.Size = new System.Drawing.Size(141, 27);
            this.exportDataButton.TabIndex = 4;
            this.exportDataButton.Text = "Import to Excel";
            this.exportDataButton.UseVisualStyleBackColor = true;
            this.exportDataButton.Click += new System.EventHandler(this.exportDataButton_Click);
            // 
            // visitorInfoListView
            // 
            this.visitorInfoListView.BackColor = System.Drawing.SystemColors.GrayText;
            this.visitorInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.visitorInfoListView.ForeColor = System.Drawing.SystemColors.Control;
            this.visitorInfoListView.GridLines = true;
            this.visitorInfoListView.Location = new System.Drawing.Point(58, 94);
            this.visitorInfoListView.Name = "visitorInfoListView";
            this.visitorInfoListView.Size = new System.Drawing.Size(516, 292);
            this.visitorInfoListView.TabIndex = 5;
            this.visitorInfoListView.UseCompatibleStateImageBehavior = false;
            this.visitorInfoListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 169;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Contact";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 202;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(434, 415);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(140, 20);
            this.totalTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total";
            // 
            // ZoneSpecificVistorDetailsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::FairManagementSystem.Properties.Resources.Contentbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 522);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.visitorInfoListView);
            this.Controls.Add(this.exportDataButton);
            this.Controls.Add(this.showVisitorDetailsButton);
            this.Controls.Add(this.selectZoneCombobox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "ZoneSpecificVistorDetailsUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zone Wise Visitor Information Report";
            this.Load += new System.EventHandler(this.ZoneSpecificVistorDetailsUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectZoneCombobox;
        private System.Windows.Forms.Button showVisitorDetailsButton;
        private System.Windows.Forms.Button exportDataButton;
        private System.Windows.Forms.ListView visitorInfoListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label2;
    }
}