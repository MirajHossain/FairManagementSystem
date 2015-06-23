namespace FairManagementSystem.UI
{
    partial class MainUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneWiseDetailsVisitorInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneWiseVisitorNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.BackgroundImage = global::FairManagementSystem.Properties.Resources.Menubg;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitorToolStripMenuItem,
            this.steupToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visitorToolStripMenuItem
            // 
            this.visitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitorEntryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.visitorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.visitorToolStripMenuItem.Name = "visitorToolStripMenuItem";
            this.visitorToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.visitorToolStripMenuItem.Text = "Visitor";
            // 
            // steupToolStripMenuItem
            // 
            this.steupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneTypeToolStripMenuItem});
            this.steupToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steupToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.steupToolStripMenuItem.Name = "steupToolStripMenuItem";
            this.steupToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.steupToolStripMenuItem.Text = "Steup";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneWiseDetailsVisitorInformationToolStripMenuItem,
            this.zoneWiseVisitorNumberToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // zoneTypeToolStripMenuItem
            // 
            this.zoneTypeToolStripMenuItem.Name = "zoneTypeToolStripMenuItem";
            this.zoneTypeToolStripMenuItem.Size = new System.Drawing.Size(177, 30);
            this.zoneTypeToolStripMenuItem.Text = "Zone Type";
            this.zoneTypeToolStripMenuItem.Click += new System.EventHandler(this.zoneTypeToolStripMenuItem_Click);
            // 
            // visitorEntryToolStripMenuItem
            // 
            this.visitorEntryToolStripMenuItem.Name = "visitorEntryToolStripMenuItem";
            this.visitorEntryToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.visitorEntryToolStripMenuItem.Text = "Visitor Entry";
            this.visitorEntryToolStripMenuItem.Click += new System.EventHandler(this.visitorEntryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // zoneWiseDetailsVisitorInformationToolStripMenuItem
            // 
            this.zoneWiseDetailsVisitorInformationToolStripMenuItem.Name = "zoneWiseDetailsVisitorInformationToolStripMenuItem";
            this.zoneWiseDetailsVisitorInformationToolStripMenuItem.Size = new System.Drawing.Size(417, 30);
            this.zoneWiseDetailsVisitorInformationToolStripMenuItem.Text = "Zone Wise Details Visitor Information";
            this.zoneWiseDetailsVisitorInformationToolStripMenuItem.Click += new System.EventHandler(this.zoneWiseDetailsVisitorInformationToolStripMenuItem_Click);
            // 
            // zoneWiseVisitorNumberToolStripMenuItem
            // 
            this.zoneWiseVisitorNumberToolStripMenuItem.Name = "zoneWiseVisitorNumberToolStripMenuItem";
            this.zoneWiseVisitorNumberToolStripMenuItem.Size = new System.Drawing.Size(417, 30);
            this.zoneWiseVisitorNumberToolStripMenuItem.Text = "Zone Wise Visitor Number";
            this.zoneWiseVisitorNumberToolStripMenuItem.Click += new System.EventHandler(this.zoneWiseVisitorNumberToolStripMenuItem_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FairManagementSystem.Properties.Resources.Contentbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(455, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fair Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneWiseDetailsVisitorInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneWiseVisitorNumberToolStripMenuItem;
    }
}