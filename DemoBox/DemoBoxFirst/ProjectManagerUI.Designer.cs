namespace DemoBoxFirst
{
    partial class ProjectManagerUI
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
            this.projectManagerNameLabel = new MetroFramework.Controls.MetroLabel();
            this.projectEntryButton = new MetroFramework.Controls.MetroButton();
            this.sendEmailButton = new MetroFramework.Controls.MetroButton();
            this.projectManagerDateTime = new MetroFramework.Controls.MetroDateTime();
            this.assignProjectButton = new MetroFramework.Controls.MetroButton();
            this.onLeaveEIButton = new MetroFramework.Controls.MetroButton();
            this.currentEIButton = new MetroFramework.Controls.MetroButton();
            this.pendingProjectButton = new MetroFramework.Controls.MetroButton();
            this.completedProjectButton = new MetroFramework.Controls.MetroButton();
            this.availableEIButton = new MetroFramework.Controls.MetroButton();
            this.employeeInformationLabel = new MetroFramework.Controls.MetroLabel();
            this.currentEIPanel = new MetroFramework.Controls.MetroPanel();
            this.currentEIListView = new MetroFramework.Controls.MetroListView();
            this.nameCEIHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roleCEIHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projectCEIHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.onLeaveEIPanel = new MetroFramework.Controls.MetroPanel();
            this.onLeaveEIListView = new MetroFramework.Controls.MetroListView();
            this.nameOLEIHeder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roleOLEIHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.availableEIPanel = new MetroFramework.Controls.MetroPanel();
            this.avaiableEIListView = new MetroFramework.Controls.MetroListView();
            this.nameAEIHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roleAEIHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pendingProjectPanel = new MetroFramework.Controls.MetroPanel();
            this.pendingProjectListView = new MetroFramework.Controls.MetroListView();
            this.projectNamePPHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamLeaderPPHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remainingTimePPHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.completedProjectPanel = new MetroFramework.Controls.MetroPanel();
            this.completedProjectListView = new MetroFramework.Controls.MetroListView();
            this.projectNameCCHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamLeaderCCHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dueDateCCHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projectHubButton = new MetroFramework.Controls.MetroButton();
            this.projectManagerToolTip = new MetroFramework.Components.MetroToolTip();
            this.projectManagerlogutLink = new MetroFramework.Controls.MetroLink();
            this.employeePendingButton = new MetroFramework.Controls.MetroButton();
            this.currentEIPanel.SuspendLayout();
            this.onLeaveEIPanel.SuspendLayout();
            this.availableEIPanel.SuspendLayout();
            this.pendingProjectPanel.SuspendLayout();
            this.completedProjectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectManagerNameLabel
            // 
            this.projectManagerNameLabel.AutoSize = true;
            this.projectManagerNameLabel.Location = new System.Drawing.Point(53, 25);
            this.projectManagerNameLabel.Name = "projectManagerNameLabel";
            this.projectManagerNameLabel.Size = new System.Drawing.Size(40, 19);
            this.projectManagerNameLabel.TabIndex = 1;
            this.projectManagerNameLabel.Text = "Anim";
            // 
            // projectEntryButton
            // 
            this.projectEntryButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.projectEntryButton.Location = new System.Drawing.Point(75, 138);
            this.projectEntryButton.Name = "projectEntryButton";
            this.projectEntryButton.Size = new System.Drawing.Size(107, 23);
            this.projectEntryButton.TabIndex = 3;
            this.projectEntryButton.Text = "Enter Project";
            this.projectManagerToolTip.SetToolTip(this.projectEntryButton, "Enter new Project");
            this.projectEntryButton.UseSelectable = true;
            this.projectEntryButton.Click += new System.EventHandler(this.projectEntryButton_Click);
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sendEmailButton.Location = new System.Drawing.Point(75, 96);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(107, 23);
            this.sendEmailButton.TabIndex = 2;
            this.sendEmailButton.Text = "Send Email";
            this.projectManagerToolTip.SetToolTip(this.sendEmailButton, "Send an Email ?");
            this.sendEmailButton.UseSelectable = true;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // projectManagerDateTime
            // 
            this.projectManagerDateTime.Location = new System.Drawing.Point(684, 25);
            this.projectManagerDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.projectManagerDateTime.Name = "projectManagerDateTime";
            this.projectManagerDateTime.Size = new System.Drawing.Size(200, 29);
            this.projectManagerDateTime.TabIndex = 12;
            // 
            // assignProjectButton
            // 
            this.assignProjectButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.assignProjectButton.Location = new System.Drawing.Point(75, 180);
            this.assignProjectButton.Name = "assignProjectButton";
            this.assignProjectButton.Size = new System.Drawing.Size(107, 23);
            this.assignProjectButton.TabIndex = 4;
            this.assignProjectButton.Text = "Assign Project";
            this.projectManagerToolTip.SetToolTip(this.assignProjectButton, "Assign Project to a Team Leader");
            this.assignProjectButton.UseSelectable = true;
            this.assignProjectButton.Click += new System.EventHandler(this.assignProjectButton_Click);
            // 
            // onLeaveEIButton
            // 
            this.onLeaveEIButton.Location = new System.Drawing.Point(523, 138);
            this.onLeaveEIButton.Name = "onLeaveEIButton";
            this.onLeaveEIButton.Size = new System.Drawing.Size(85, 23);
            this.onLeaveEIButton.TabIndex = 8;
            this.onLeaveEIButton.Text = "On Leave";
            this.projectManagerToolTip.SetToolTip(this.onLeaveEIButton, "Employees are on Leave");
            this.onLeaveEIButton.UseSelectable = true;
            this.onLeaveEIButton.Click += new System.EventHandler(this.onLeaveEIButton_Click);
            // 
            // currentEIButton
            // 
            this.currentEIButton.Location = new System.Drawing.Point(523, 96);
            this.currentEIButton.Name = "currentEIButton";
            this.currentEIButton.Size = new System.Drawing.Size(85, 23);
            this.currentEIButton.TabIndex = 7;
            this.currentEIButton.Text = "Current";
            this.projectManagerToolTip.SetToolTip(this.currentEIButton, "Current employee in this Organization");
            this.currentEIButton.UseSelectable = true;
            this.currentEIButton.Click += new System.EventHandler(this.currentEIButton_Click);
            // 
            // pendingProjectButton
            // 
            this.pendingProjectButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pendingProjectButton.Location = new System.Drawing.Point(75, 222);
            this.pendingProjectButton.Name = "pendingProjectButton";
            this.pendingProjectButton.Size = new System.Drawing.Size(107, 23);
            this.pendingProjectButton.TabIndex = 5;
            this.pendingProjectButton.Text = "Pending Project";
            this.projectManagerToolTip.SetToolTip(this.pendingProjectButton, "Pending Projects");
            this.pendingProjectButton.UseSelectable = true;
            this.pendingProjectButton.Click += new System.EventHandler(this.pendingProjectButton_Click);
            // 
            // completedProjectButton
            // 
            this.completedProjectButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.completedProjectButton.Location = new System.Drawing.Point(75, 264);
            this.completedProjectButton.Name = "completedProjectButton";
            this.completedProjectButton.Size = new System.Drawing.Size(107, 23);
            this.completedProjectButton.TabIndex = 6;
            this.completedProjectButton.Text = "Completed Project";
            this.projectManagerToolTip.SetToolTip(this.completedProjectButton, "Completed Projects");
            this.completedProjectButton.UseSelectable = true;
            this.completedProjectButton.Click += new System.EventHandler(this.completedProjectButton_Click);
            // 
            // availableEIButton
            // 
            this.availableEIButton.Location = new System.Drawing.Point(523, 180);
            this.availableEIButton.Name = "availableEIButton";
            this.availableEIButton.Size = new System.Drawing.Size(85, 23);
            this.availableEIButton.TabIndex = 9;
            this.availableEIButton.Text = "Available";
            this.projectManagerToolTip.SetToolTip(this.availableEIButton, "Available Employees to Assign Project");
            this.availableEIButton.UseSelectable = true;
            this.availableEIButton.Click += new System.EventHandler(this.availableEIButton_Click);
            // 
            // employeeInformationLabel
            // 
            this.employeeInformationLabel.AutoSize = true;
            this.employeeInformationLabel.Location = new System.Drawing.Point(498, 60);
            this.employeeInformationLabel.Name = "employeeInformationLabel";
            this.employeeInformationLabel.Size = new System.Drawing.Size(139, 19);
            this.employeeInformationLabel.TabIndex = 10;
            this.employeeInformationLabel.Text = "Employee Information";
            // 
            // currentEIPanel
            // 
            this.currentEIPanel.Controls.Add(this.currentEIListView);
            this.currentEIPanel.HorizontalScrollbarBarColor = true;
            this.currentEIPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.currentEIPanel.HorizontalScrollbarSize = 10;
            this.currentEIPanel.Location = new System.Drawing.Point(643, 99);
            this.currentEIPanel.Name = "currentEIPanel";
            this.currentEIPanel.Size = new System.Drawing.Size(256, 256);
            this.currentEIPanel.TabIndex = 12;
            this.currentEIPanel.VerticalScrollbarBarColor = true;
            this.currentEIPanel.VerticalScrollbarHighlightOnWheel = false;
            this.currentEIPanel.VerticalScrollbarSize = 10;
            // 
            // currentEIListView
            // 
            this.currentEIListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCEIHeader,
            this.roleCEIHeader,
            this.projectCEIHeader});
            this.currentEIListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentEIListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.currentEIListView.FullRowSelect = true;
            this.currentEIListView.Location = new System.Drawing.Point(0, 0);
            this.currentEIListView.Name = "currentEIListView";
            this.currentEIListView.OwnerDraw = true;
            this.currentEIListView.Size = new System.Drawing.Size(256, 256);
            this.currentEIListView.TabIndex = 2;
            this.currentEIListView.UseCompatibleStateImageBehavior = false;
            this.currentEIListView.UseSelectable = true;
            this.currentEIListView.View = System.Windows.Forms.View.Details;
            // 
            // nameCEIHeader
            // 
            this.nameCEIHeader.Text = "Name";
            this.nameCEIHeader.Width = 80;
            // 
            // roleCEIHeader
            // 
            this.roleCEIHeader.Text = "Role";
            this.roleCEIHeader.Width = 80;
            // 
            // projectCEIHeader
            // 
            this.projectCEIHeader.Text = "Project";
            this.projectCEIHeader.Width = 120;
            // 
            // onLeaveEIPanel
            // 
            this.onLeaveEIPanel.Controls.Add(this.onLeaveEIListView);
            this.onLeaveEIPanel.HorizontalScrollbarBarColor = true;
            this.onLeaveEIPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.onLeaveEIPanel.HorizontalScrollbarSize = 10;
            this.onLeaveEIPanel.Location = new System.Drawing.Point(646, 96);
            this.onLeaveEIPanel.Name = "onLeaveEIPanel";
            this.onLeaveEIPanel.Size = new System.Drawing.Size(256, 256);
            this.onLeaveEIPanel.TabIndex = 13;
            this.onLeaveEIPanel.VerticalScrollbarBarColor = true;
            this.onLeaveEIPanel.VerticalScrollbarHighlightOnWheel = false;
            this.onLeaveEIPanel.VerticalScrollbarSize = 10;
            // 
            // onLeaveEIListView
            // 
            this.onLeaveEIListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameOLEIHeder,
            this.roleOLEIHeader});
            this.onLeaveEIListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onLeaveEIListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.onLeaveEIListView.FullRowSelect = true;
            this.onLeaveEIListView.Location = new System.Drawing.Point(0, 0);
            this.onLeaveEIListView.Name = "onLeaveEIListView";
            this.onLeaveEIListView.OwnerDraw = true;
            this.onLeaveEIListView.Size = new System.Drawing.Size(256, 256);
            this.onLeaveEIListView.TabIndex = 2;
            this.onLeaveEIListView.UseCompatibleStateImageBehavior = false;
            this.onLeaveEIListView.UseSelectable = true;
            this.onLeaveEIListView.View = System.Windows.Forms.View.Details;
            // 
            // nameOLEIHeder
            // 
            this.nameOLEIHeder.Text = "Name";
            this.nameOLEIHeder.Width = 140;
            // 
            // roleOLEIHeader
            // 
            this.roleOLEIHeader.Text = "Role";
            this.roleOLEIHeader.Width = 140;
            // 
            // availableEIPanel
            // 
            this.availableEIPanel.Controls.Add(this.avaiableEIListView);
            this.availableEIPanel.HorizontalScrollbarBarColor = true;
            this.availableEIPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.availableEIPanel.HorizontalScrollbarSize = 10;
            this.availableEIPanel.Location = new System.Drawing.Point(643, 96);
            this.availableEIPanel.Name = "availableEIPanel";
            this.availableEIPanel.Size = new System.Drawing.Size(256, 256);
            this.availableEIPanel.TabIndex = 13;
            this.availableEIPanel.VerticalScrollbarBarColor = true;
            this.availableEIPanel.VerticalScrollbarHighlightOnWheel = false;
            this.availableEIPanel.VerticalScrollbarSize = 10;
            // 
            // avaiableEIListView
            // 
            this.avaiableEIListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameAEIHeader,
            this.roleAEIHeader});
            this.avaiableEIListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.avaiableEIListView.FullRowSelect = true;
            this.avaiableEIListView.Location = new System.Drawing.Point(0, 0);
            this.avaiableEIListView.Name = "avaiableEIListView";
            this.avaiableEIListView.OwnerDraw = true;
            this.avaiableEIListView.Size = new System.Drawing.Size(256, 256);
            this.avaiableEIListView.TabIndex = 0;
            this.avaiableEIListView.UseCompatibleStateImageBehavior = false;
            this.avaiableEIListView.UseSelectable = true;
            this.avaiableEIListView.View = System.Windows.Forms.View.Details;
            // 
            // nameAEIHeader
            // 
            this.nameAEIHeader.Text = "Name";
            this.nameAEIHeader.Width = 140;
            // 
            // roleAEIHeader
            // 
            this.roleAEIHeader.Text = "Role";
            this.roleAEIHeader.Width = 140;
            // 
            // pendingProjectPanel
            // 
            this.pendingProjectPanel.Controls.Add(this.pendingProjectListView);
            this.pendingProjectPanel.HorizontalScrollbarBarColor = true;
            this.pendingProjectPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.pendingProjectPanel.HorizontalScrollbarSize = 10;
            this.pendingProjectPanel.Location = new System.Drawing.Point(205, 207);
            this.pendingProjectPanel.Name = "pendingProjectPanel";
            this.pendingProjectPanel.Size = new System.Drawing.Size(304, 130);
            this.pendingProjectPanel.TabIndex = 14;
            this.pendingProjectPanel.VerticalScrollbarBarColor = true;
            this.pendingProjectPanel.VerticalScrollbarHighlightOnWheel = false;
            this.pendingProjectPanel.VerticalScrollbarSize = 10;
            // 
            // pendingProjectListView
            // 
            this.pendingProjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projectNamePPHeader,
            this.teamLeaderPPHeader,
            this.remainingTimePPHeader});
            this.pendingProjectListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pendingProjectListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pendingProjectListView.FullRowSelect = true;
            this.pendingProjectListView.Location = new System.Drawing.Point(0, 0);
            this.pendingProjectListView.Name = "pendingProjectListView";
            this.pendingProjectListView.OwnerDraw = true;
            this.pendingProjectListView.Size = new System.Drawing.Size(304, 130);
            this.pendingProjectListView.TabIndex = 2;
            this.pendingProjectListView.UseCompatibleStateImageBehavior = false;
            this.pendingProjectListView.UseSelectable = true;
            this.pendingProjectListView.View = System.Windows.Forms.View.Details;
            // 
            // projectNamePPHeader
            // 
            this.projectNamePPHeader.Text = "Project Name";
            this.projectNamePPHeader.Width = 100;
            // 
            // teamLeaderPPHeader
            // 
            this.teamLeaderPPHeader.Text = "Team Leader";
            this.teamLeaderPPHeader.Width = 100;
            // 
            // remainingTimePPHeader
            // 
            this.remainingTimePPHeader.Text = "Remaining Time";
            this.remainingTimePPHeader.Width = 120;
            // 
            // completedProjectPanel
            // 
            this.completedProjectPanel.Controls.Add(this.completedProjectListView);
            this.completedProjectPanel.HorizontalScrollbarBarColor = true;
            this.completedProjectPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.completedProjectPanel.HorizontalScrollbarSize = 10;
            this.completedProjectPanel.Location = new System.Drawing.Point(205, 231);
            this.completedProjectPanel.Name = "completedProjectPanel";
            this.completedProjectPanel.Size = new System.Drawing.Size(304, 130);
            this.completedProjectPanel.TabIndex = 15;
            this.completedProjectPanel.VerticalScrollbarBarColor = true;
            this.completedProjectPanel.VerticalScrollbarHighlightOnWheel = false;
            this.completedProjectPanel.VerticalScrollbarSize = 10;
            // 
            // completedProjectListView
            // 
            this.completedProjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projectNameCCHeader,
            this.teamLeaderCCHeader,
            this.dueDateCCHeader});
            this.completedProjectListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.completedProjectListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.completedProjectListView.FullRowSelect = true;
            this.completedProjectListView.Location = new System.Drawing.Point(0, 0);
            this.completedProjectListView.Name = "completedProjectListView";
            this.completedProjectListView.OwnerDraw = true;
            this.completedProjectListView.Size = new System.Drawing.Size(304, 130);
            this.completedProjectListView.TabIndex = 2;
            this.completedProjectListView.UseCompatibleStateImageBehavior = false;
            this.completedProjectListView.UseSelectable = true;
            this.completedProjectListView.View = System.Windows.Forms.View.Details;
            // 
            // projectNameCCHeader
            // 
            this.projectNameCCHeader.Text = "Project Name";
            this.projectNameCCHeader.Width = 100;
            // 
            // teamLeaderCCHeader
            // 
            this.teamLeaderCCHeader.Text = "Team Leader";
            this.teamLeaderCCHeader.Width = 100;
            // 
            // dueDateCCHeader
            // 
            this.dueDateCCHeader.Text = "Due Date";
            this.dueDateCCHeader.Width = 100;
            // 
            // projectHubButton
            // 
            this.projectHubButton.Location = new System.Drawing.Point(87, 446);
            this.projectHubButton.Name = "projectHubButton";
            this.projectHubButton.Size = new System.Drawing.Size(75, 23);
            this.projectHubButton.TabIndex = 11;
            this.projectHubButton.Text = "Hub";
            this.projectManagerToolTip.SetToolTip(this.projectHubButton, "Project Hub");
            this.projectHubButton.UseSelectable = true;
            this.projectHubButton.Click += new System.EventHandler(this.projectHubButton_Click);
            // 
            // projectManagerToolTip
            // 
            this.projectManagerToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.projectManagerToolTip.StyleManager = null;
            this.projectManagerToolTip.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // projectManagerlogutLink
            // 
            this.projectManagerlogutLink.Image = global::DemoBoxFirst.Properties.Resources.circle_back_arrow_glyph_128;
            this.projectManagerlogutLink.Location = new System.Drawing.Point(9, 21);
            this.projectManagerlogutLink.Name = "projectManagerlogutLink";
            this.projectManagerlogutLink.Size = new System.Drawing.Size(29, 23);
            this.projectManagerlogutLink.TabIndex = 0;
            this.projectManagerToolTip.SetToolTip(this.projectManagerlogutLink, "Logut");
            this.projectManagerlogutLink.UseSelectable = true;
            this.projectManagerlogutLink.Click += new System.EventHandler(this.projectManagerlogutLink_Click_1);
            // 
            // employeePendingButton
            // 
            this.employeePendingButton.Location = new System.Drawing.Point(535, 446);
            this.employeePendingButton.Name = "employeePendingButton";
            this.employeePendingButton.Size = new System.Drawing.Size(61, 23);
            this.employeePendingButton.TabIndex = 16;
            this.employeePendingButton.Text = "Pending";
            this.employeePendingButton.UseSelectable = true;
            this.employeePendingButton.Click += new System.EventHandler(this.employeePendingButton_Click);
            // 
            // ProjectManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 532);
            this.Controls.Add(this.employeePendingButton);
            this.Controls.Add(this.projectHubButton);
            this.Controls.Add(this.completedProjectPanel);
            this.Controls.Add(this.availableEIPanel);
            this.Controls.Add(this.onLeaveEIPanel);
            this.Controls.Add(this.pendingProjectPanel);
            this.Controls.Add(this.currentEIPanel);
            this.Controls.Add(this.projectManagerlogutLink);
            this.Controls.Add(this.employeeInformationLabel);
            this.Controls.Add(this.availableEIButton);
            this.Controls.Add(this.currentEIButton);
            this.Controls.Add(this.onLeaveEIButton);
            this.Controls.Add(this.projectManagerDateTime);
            this.Controls.Add(this.projectManagerNameLabel);
            this.Controls.Add(this.completedProjectButton);
            this.Controls.Add(this.pendingProjectButton);
            this.Controls.Add(this.assignProjectButton);
            this.Controls.Add(this.sendEmailButton);
            this.Controls.Add(this.projectEntryButton);
            this.MaximizeBox = false;
            this.Name = "ProjectManagerUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectManagerUI_FormClosing);
            this.Load += new System.EventHandler(this.ProjectManagerUI_Load);
            this.currentEIPanel.ResumeLayout(false);
            this.onLeaveEIPanel.ResumeLayout(false);
            this.availableEIPanel.ResumeLayout(false);
            this.pendingProjectPanel.ResumeLayout(false);
            this.completedProjectPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel projectManagerNameLabel;
        private MetroFramework.Controls.MetroButton projectEntryButton;
        private MetroFramework.Controls.MetroButton sendEmailButton;
        private MetroFramework.Controls.MetroDateTime projectManagerDateTime;
        private MetroFramework.Controls.MetroButton assignProjectButton;
        private MetroFramework.Controls.MetroButton onLeaveEIButton;
        private MetroFramework.Controls.MetroButton currentEIButton;
        private MetroFramework.Controls.MetroButton pendingProjectButton;
        private MetroFramework.Controls.MetroButton completedProjectButton;
        private MetroFramework.Controls.MetroButton availableEIButton;
        private MetroFramework.Controls.MetroLabel employeeInformationLabel;
        private MetroFramework.Controls.MetroLink projectManagerlogutLink;
        private MetroFramework.Controls.MetroPanel currentEIPanel;
        private MetroFramework.Controls.MetroPanel onLeaveEIPanel;
        private MetroFramework.Controls.MetroPanel availableEIPanel;
        private MetroFramework.Controls.MetroListView currentEIListView;
        private System.Windows.Forms.ColumnHeader nameCEIHeader;
        private System.Windows.Forms.ColumnHeader roleCEIHeader;
        private System.Windows.Forms.ColumnHeader projectCEIHeader;
        private MetroFramework.Controls.MetroListView onLeaveEIListView;
        private System.Windows.Forms.ColumnHeader nameOLEIHeder;
        private System.Windows.Forms.ColumnHeader roleOLEIHeader;
        private MetroFramework.Controls.MetroListView avaiableEIListView;
        private System.Windows.Forms.ColumnHeader nameAEIHeader;
        private System.Windows.Forms.ColumnHeader roleAEIHeader;
        private MetroFramework.Controls.MetroPanel pendingProjectPanel;
        private MetroFramework.Controls.MetroListView pendingProjectListView;
        private System.Windows.Forms.ColumnHeader projectNamePPHeader;
        private System.Windows.Forms.ColumnHeader teamLeaderPPHeader;
        private System.Windows.Forms.ColumnHeader remainingTimePPHeader;
        private MetroFramework.Controls.MetroPanel completedProjectPanel;
        private MetroFramework.Controls.MetroListView completedProjectListView;
        private System.Windows.Forms.ColumnHeader projectNameCCHeader;
        private System.Windows.Forms.ColumnHeader teamLeaderCCHeader;
        private System.Windows.Forms.ColumnHeader dueDateCCHeader;
        private MetroFramework.Controls.MetroButton projectHubButton;
        private MetroFramework.Components.MetroToolTip projectManagerToolTip;
        private MetroFramework.Controls.MetroButton employeePendingButton;
    }
}