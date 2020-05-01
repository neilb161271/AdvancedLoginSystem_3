namespace AdvancedLoginSystem
{
    partial class frmAdmin
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
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addJobToTheSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEstimateToTheSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteJobFromTheSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finishJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeKeepingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoisInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendenceRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holidaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkEmployeesHolidayEntitlementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHolidayForEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sickDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.AdminSettBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.AddCustCartoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.jobsToolStripMenuItem,
            this.timeKeepingToolStripMenuItem,
            this.addCustomerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 48);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userRegistrationToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.masterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(124, 42);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // userRegistrationToolStripMenuItem
            // 
            this.userRegistrationToolStripMenuItem.Name = "userRegistrationToolStripMenuItem";
            this.userRegistrationToolStripMenuItem.Size = new System.Drawing.Size(365, 46);
            this.userRegistrationToolStripMenuItem.Text = "User Registration";
            this.userRegistrationToolStripMenuItem.Click += new System.EventHandler(this.UserRegistrationToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(365, 46);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(365, 46);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.UserManagementToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(138, 42);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // jobsToolStripMenuItem
            // 
            this.jobsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addJobToTheSystemToolStripMenuItem,
            this.addEstimateToTheSystemToolStripMenuItem,
            this.deleteJobFromTheSystemToolStripMenuItem,
            this.finishJobToolStripMenuItem,
            this.AddCustCartoolStripMenuItem});
            this.jobsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.jobsToolStripMenuItem.Name = "jobsToolStripMenuItem";
            this.jobsToolStripMenuItem.Size = new System.Drawing.Size(91, 42);
            this.jobsToolStripMenuItem.Text = "Jobs";
            // 
            // addJobToTheSystemToolStripMenuItem
            // 
            this.addJobToTheSystemToolStripMenuItem.Name = "addJobToTheSystemToolStripMenuItem";
            this.addJobToTheSystemToolStripMenuItem.Size = new System.Drawing.Size(492, 46);
            this.addJobToTheSystemToolStripMenuItem.Text = "Add-Job to the System";
            // 
            // addEstimateToTheSystemToolStripMenuItem
            // 
            this.addEstimateToTheSystemToolStripMenuItem.Name = "addEstimateToTheSystemToolStripMenuItem";
            this.addEstimateToTheSystemToolStripMenuItem.Size = new System.Drawing.Size(492, 46);
            this.addEstimateToTheSystemToolStripMenuItem.Text = "Add-Estimate to the System";
            // 
            // deleteJobFromTheSystemToolStripMenuItem
            // 
            this.deleteJobFromTheSystemToolStripMenuItem.Name = "deleteJobFromTheSystemToolStripMenuItem";
            this.deleteJobFromTheSystemToolStripMenuItem.Size = new System.Drawing.Size(492, 46);
            this.deleteJobFromTheSystemToolStripMenuItem.Text = "Delete-Job from the System";
            // 
            // finishJobToolStripMenuItem
            // 
            this.finishJobToolStripMenuItem.Name = "finishJobToolStripMenuItem";
            this.finishJobToolStripMenuItem.Size = new System.Drawing.Size(492, 46);
            this.finishJobToolStripMenuItem.Text = "Finish-Job";
            // 
            // timeKeepingToolStripMenuItem
            // 
            this.timeKeepingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whoisInToolStripMenuItem,
            this.attendenceRecordToolStripMenuItem,
            this.holidaysToolStripMenuItem});
            this.timeKeepingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.timeKeepingToolStripMenuItem.Name = "timeKeepingToolStripMenuItem";
            this.timeKeepingToolStripMenuItem.Size = new System.Drawing.Size(216, 42);
            this.timeKeepingToolStripMenuItem.Text = "Time-Keeping";
            // 
            // whoisInToolStripMenuItem
            // 
            this.whoisInToolStripMenuItem.Name = "whoisInToolStripMenuItem";
            this.whoisInToolStripMenuItem.Size = new System.Drawing.Size(375, 46);
            this.whoisInToolStripMenuItem.Text = "Who-is-In";
            // 
            // attendenceRecordToolStripMenuItem
            // 
            this.attendenceRecordToolStripMenuItem.Name = "attendenceRecordToolStripMenuItem";
            this.attendenceRecordToolStripMenuItem.Size = new System.Drawing.Size(375, 46);
            this.attendenceRecordToolStripMenuItem.Text = "Attendence-Record";
            // 
            // holidaysToolStripMenuItem
            // 
            this.holidaysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkEmployeesHolidayEntitlementToolStripMenuItem,
            this.addHolidayForEmployeeToolStripMenuItem,
            this.sickDaysToolStripMenuItem});
            this.holidaysToolStripMenuItem.Name = "holidaysToolStripMenuItem";
            this.holidaysToolStripMenuItem.Size = new System.Drawing.Size(375, 46);
            this.holidaysToolStripMenuItem.Text = "Holidays";
            // 
            // checkEmployeesHolidayEntitlementToolStripMenuItem
            // 
            this.checkEmployeesHolidayEntitlementToolStripMenuItem.Name = "checkEmployeesHolidayEntitlementToolStripMenuItem";
            this.checkEmployeesHolidayEntitlementToolStripMenuItem.Size = new System.Drawing.Size(621, 46);
            this.checkEmployeesHolidayEntitlementToolStripMenuItem.Text = "Check Employees Holiday Entitlement";
            // 
            // addHolidayForEmployeeToolStripMenuItem
            // 
            this.addHolidayForEmployeeToolStripMenuItem.Name = "addHolidayForEmployeeToolStripMenuItem";
            this.addHolidayForEmployeeToolStripMenuItem.Size = new System.Drawing.Size(621, 46);
            this.addHolidayForEmployeeToolStripMenuItem.Text = "Add A Holiday for A Employee";
            // 
            // sickDaysToolStripMenuItem
            // 
            this.sickDaysToolStripMenuItem.Name = "sickDaysToolStripMenuItem";
            this.sickDaysToolStripMenuItem.Size = new System.Drawing.Size(621, 46);
            this.sickDaysToolStripMenuItem.Text = "Sick Days";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem1,
            this.searchCustomerToolStripMenuItem,
            this.addCustomerCarToolStripMenuItem});
            this.addCustomerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(159, 42);
            this.addCustomerToolStripMenuItem.Text = "Customer";
            // 
            // addCustomerToolStripMenuItem1
            // 
            this.addCustomerToolStripMenuItem1.Name = "addCustomerToolStripMenuItem1";
            this.addCustomerToolStripMenuItem1.Size = new System.Drawing.Size(363, 46);
            this.addCustomerToolStripMenuItem1.Text = "Add Customer";
            this.addCustomerToolStripMenuItem1.Click += new System.EventHandler(this.AddCustomerToolStripMenuItem1_Click);
            // 
            // searchCustomerToolStripMenuItem
            // 
            this.searchCustomerToolStripMenuItem.Name = "searchCustomerToolStripMenuItem";
            this.searchCustomerToolStripMenuItem.Size = new System.Drawing.Size(363, 46);
            this.searchCustomerToolStripMenuItem.Text = "Search Customer";
            // 
            // addCustomerCarToolStripMenuItem
            // 
            this.addCustomerCarToolStripMenuItem.Name = "addCustomerCarToolStripMenuItem";
            this.addCustomerCarToolStripMenuItem.Size = new System.Drawing.Size(363, 46);
            this.addCustomerCarToolStripMenuItem.Text = "Add Customer Car";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 86);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::AdvancedLoginSystem.Properties.Resources.mygraphbutton;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(69, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 129);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::AdvancedLoginSystem.Properties.Resources.shutdown_button;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(33, 495);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 129);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::AdvancedLoginSystem.Properties.Resources._21_215199_download_calendar_png_clipart_calendar_icon_png_blue1;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(450, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 129);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // AdminSettBtn
            // 
            this.AdminSettBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AdminSettBtn.BackColor = System.Drawing.Color.Transparent;
            this.AdminSettBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdminSettBtn.Image = global::AdvancedLoginSystem.Properties.Resources.mysettingsbutton;
            this.AdminSettBtn.Location = new System.Drawing.Point(194, 495);
            this.AdminSettBtn.Name = "AdminSettBtn";
            this.AdminSettBtn.Size = new System.Drawing.Size(124, 129);
            this.AdminSettBtn.TabIndex = 5;
            this.AdminSettBtn.UseVisualStyleBackColor = false;
            this.AdminSettBtn.Click += new System.EventHandler(this.AdminSettBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Message";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Load);
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLbl.Location = new System.Drawing.Point(336, 67);
            this.UserNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(251, 37);
            this.UserNameLbl.TabIndex = 6;
            this.UserNameLbl.Text = "Welcome name";
            this.UserNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UserNameLbl.Click += new System.EventHandler(this.UserNameLbl_Load);
            // 
            // AddCustCartoolStripMenuItem
            // 
            this.AddCustCartoolStripMenuItem.Name = "AddCustCartoolStripMenuItem";
            this.AddCustCartoolStripMenuItem.Size = new System.Drawing.Size(492, 46);
            this.AddCustCartoolStripMenuItem.Text = "Add Customer Car";
            this.AddCustCartoolStripMenuItem.Click += new System.EventHandler(this.AddCustCartoolStripMenuItem_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdvancedLoginSystem.Properties.Resources.black_white_glow_gradient_hexagon_green_1920x1080_c4_000000_ffffff_556b2f_000000_l2_2_35_a_30_f_6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.AdminSettBtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addJobToTheSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEstimateToTheSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteJobFromTheSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finishJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeKeepingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whoisInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendenceRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holidaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkEmployeesHolidayEntitlementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHolidayForEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sickDaysToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button AdminSettBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchCustomerToolStripMenuItem;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.ToolStripMenuItem addCustomerCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCustCartoolStripMenuItem;
    }

}