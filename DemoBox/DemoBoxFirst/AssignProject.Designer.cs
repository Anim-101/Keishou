namespace DemoBoxFirst
{
    partial class AssignProject
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
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.searchProjectPanel = new MetroFramework.Controls.MetroPanel();
            this.projectNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.projectNameLabel = new MetroFramework.Controls.MetroLabel();
            this.projectListView = new MetroFramework.Controls.MetroListView();
            this.projectIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projectHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamLeaderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeLineHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.availableEmployeePanel = new MetroFramework.Controls.MetroPanel();
            this.assignButton = new MetroFramework.Controls.MetroButton();
            this.infoPositionLabel = new MetroFramework.Controls.MetroLabel();
            this.setPossitionLabel = new MetroFramework.Controls.MetroLabel();
            this.possitionComboBox = new MetroFramework.Controls.MetroComboBox();
            this.availableEmployeeListView = new MetroFramework.Controls.MetroListView();
            this.employeeIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeRoleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.availableEmployeeLabel = new MetroFramework.Controls.MetroLabel();
            this.assignProjectToolTip = new MetroFramework.Components.MetroToolTip();
            this.searchProjectPanel.SuspendLayout();
            this.availableEmployeePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchProjectPanel
            // 
            this.searchProjectPanel.Controls.Add(this.projectNameTextBox);
            this.searchProjectPanel.Controls.Add(this.projectNameLabel);
            this.searchProjectPanel.Controls.Add(this.projectListView);
            this.searchProjectPanel.HorizontalScrollbarBarColor = true;
            this.searchProjectPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.searchProjectPanel.HorizontalScrollbarSize = 10;
            this.searchProjectPanel.Location = new System.Drawing.Point(3, 8);
            this.searchProjectPanel.Name = "searchProjectPanel";
            this.searchProjectPanel.Size = new System.Drawing.Size(519, 449);
            this.searchProjectPanel.TabIndex = 0;
            this.searchProjectPanel.VerticalScrollbarBarColor = true;
            this.searchProjectPanel.VerticalScrollbarHighlightOnWheel = false;
            this.searchProjectPanel.VerticalScrollbarSize = 10;
            // 
            // projectNameTextBox
            // 
            // 
            // 
            // 
            this.projectNameTextBox.CustomButton.Image = null;
            this.projectNameTextBox.CustomButton.Location = new System.Drawing.Point(297, 1);
            this.projectNameTextBox.CustomButton.Name = "";
            this.projectNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.projectNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.projectNameTextBox.CustomButton.TabIndex = 1;
            this.projectNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.projectNameTextBox.CustomButton.UseSelectable = true;
            this.projectNameTextBox.CustomButton.Visible = false;
            this.projectNameTextBox.Lines = new string[0];
            this.projectNameTextBox.Location = new System.Drawing.Point(118, 12);
            this.projectNameTextBox.MaxLength = 32767;
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.PasswordChar = '\0';
            this.projectNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.projectNameTextBox.SelectedText = "";
            this.projectNameTextBox.SelectionLength = 0;
            this.projectNameTextBox.SelectionStart = 0;
            this.projectNameTextBox.ShortcutsEnabled = true;
            this.projectNameTextBox.Size = new System.Drawing.Size(319, 23);
            this.projectNameTextBox.TabIndex = 2;
            this.assignProjectToolTip.SetToolTip(this.projectNameTextBox, "Search for Projects here.");
            this.projectNameTextBox.UseSelectable = true;
            this.projectNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.projectNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.projectNameTextBox.Enter += new System.EventHandler(this.projectNameTextBox_Enter);
            this.projectNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.projectNameTextBox_KeyDown);
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(20, 12);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(50, 19);
            this.projectNameLabel.TabIndex = 1;
            this.projectNameLabel.Text = "Project";
            // 
            // projectListView
            // 
            this.projectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projectIdHeader,
            this.projectHeader,
            this.processingHeader,
            this.teamLeaderHeader,
            this.timeLineHeader});
            this.projectListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.projectListView.FullRowSelect = true;
            this.projectListView.Location = new System.Drawing.Point(20, 75);
            this.projectListView.Name = "projectListView";
            this.projectListView.OwnerDraw = true;
            this.projectListView.Size = new System.Drawing.Size(482, 355);
            this.projectListView.TabIndex = 2;
            this.projectListView.UseCompatibleStateImageBehavior = false;
            this.projectListView.UseSelectable = true;
            this.projectListView.View = System.Windows.Forms.View.Details;
            this.projectListView.SelectedIndexChanged += new System.EventHandler(this.projectListView_SelectedIndexChanged);
            this.projectListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.projectListView_MouseClick);
            this.projectListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.projectListView_MouseDoubleClick);
            // 
            // projectIdHeader
            // 
            this.projectIdHeader.Text = "Id";
            this.projectIdHeader.Width = 70;
            // 
            // projectHeader
            // 
            this.projectHeader.Text = "Project";
            this.projectHeader.Width = 150;
            // 
            // processingHeader
            // 
            this.processingHeader.Text = "Processing";
            this.processingHeader.Width = 100;
            // 
            // teamLeaderHeader
            // 
            this.teamLeaderHeader.Text = "Team Leader";
            this.teamLeaderHeader.Width = 120;
            // 
            // timeLineHeader
            // 
            this.timeLineHeader.Text = "Time Line";
            this.timeLineHeader.Width = 100;
            // 
            // availableEmployeePanel
            // 
            this.availableEmployeePanel.Controls.Add(this.assignButton);
            this.availableEmployeePanel.Controls.Add(this.infoPositionLabel);
            this.availableEmployeePanel.Controls.Add(this.setPossitionLabel);
            this.availableEmployeePanel.Controls.Add(this.possitionComboBox);
            this.availableEmployeePanel.Controls.Add(this.availableEmployeeListView);
            this.availableEmployeePanel.Controls.Add(this.availableEmployeeLabel);
            this.availableEmployeePanel.HorizontalScrollbarBarColor = true;
            this.availableEmployeePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.availableEmployeePanel.HorizontalScrollbarSize = 10;
            this.availableEmployeePanel.Location = new System.Drawing.Point(538, 20);
            this.availableEmployeePanel.Name = "availableEmployeePanel";
            this.availableEmployeePanel.Size = new System.Drawing.Size(356, 437);
            this.availableEmployeePanel.TabIndex = 1;
            this.availableEmployeePanel.VerticalScrollbarBarColor = true;
            this.availableEmployeePanel.VerticalScrollbarHighlightOnWheel = false;
            this.availableEmployeePanel.VerticalScrollbarSize = 10;
            this.availableEmployeePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.availableEmployeePanel_Paint);
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(137, 395);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(62, 23);
            this.assignButton.TabIndex = 5;
            this.assignButton.Text = "Assign";
            this.assignButton.UseSelectable = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // infoPositionLabel
            // 
            this.infoPositionLabel.AutoSize = true;
            this.infoPositionLabel.Location = new System.Drawing.Point(55, 297);
            this.infoPositionLabel.Name = "infoPositionLabel";
            this.infoPositionLabel.Size = new System.Drawing.Size(260, 19);
            this.infoPositionLabel.TabIndex = 4;
            this.infoPositionLabel.Text = "Set Possition for Selected Employee below.";
            // 
            // setPossitionLabel
            // 
            this.setPossitionLabel.AutoSize = true;
            this.setPossitionLabel.Location = new System.Drawing.Point(73, 342);
            this.setPossitionLabel.Name = "setPossitionLabel";
            this.setPossitionLabel.Size = new System.Drawing.Size(60, 19);
            this.setPossitionLabel.TabIndex = 4;
            this.setPossitionLabel.Text = "Possition";
            this.assignProjectToolTip.SetToolTip(this.setPossitionLabel, "Available Possitions");
            // 
            // possitionComboBox
            // 
            this.possitionComboBox.FormattingEnabled = true;
            this.possitionComboBox.ItemHeight = 23;
            this.possitionComboBox.Items.AddRange(new object[] {
            "Team Leader",
            "Analyst",
            "Designer",
            "Programmer",
            "Tester"});
            this.possitionComboBox.Location = new System.Drawing.Point(178, 342);
            this.possitionComboBox.Name = "possitionComboBox";
            this.possitionComboBox.Size = new System.Drawing.Size(128, 29);
            this.possitionComboBox.TabIndex = 0;
            this.possitionComboBox.UseSelectable = true;
            this.possitionComboBox.SelectedIndexChanged += new System.EventHandler(this.possitionComboBox_SelectedIndexChanged);
            // 
            // availableEmployeeListView
            // 
            this.availableEmployeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employeeIdHeader,
            this.employeeNameHeader,
            this.employeeRoleHeader});
            this.availableEmployeeListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.availableEmployeeListView.FullRowSelect = true;
            listViewGroup7.Header = "ListViewGroup";
            listViewGroup7.Name = "listViewGroup1";
            listViewGroup8.Header = "ListViewGroup";
            listViewGroup8.Name = "listViewGroup2";
            listViewGroup9.Header = "ListViewGroup";
            listViewGroup9.Name = "listViewGroup3";
            listViewGroup10.Header = "ListViewGroup";
            listViewGroup10.Name = "listViewGroup4";
            listViewGroup11.Header = "ListViewGroup";
            listViewGroup11.Name = "listViewGroup5";
            listViewGroup12.Header = "ListViewGroup";
            listViewGroup12.Name = "listViewGroup6";
            this.availableEmployeeListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup7,
            listViewGroup8,
            listViewGroup9,
            listViewGroup10,
            listViewGroup11,
            listViewGroup12});
            this.availableEmployeeListView.Location = new System.Drawing.Point(16, 63);
            this.availableEmployeeListView.Name = "availableEmployeeListView";
            this.availableEmployeeListView.OwnerDraw = true;
            this.availableEmployeeListView.Size = new System.Drawing.Size(329, 209);
            this.availableEmployeeListView.TabIndex = 3;
            this.availableEmployeeListView.UseCompatibleStateImageBehavior = false;
            this.availableEmployeeListView.UseSelectable = true;
            this.availableEmployeeListView.View = System.Windows.Forms.View.Details;
            this.availableEmployeeListView.SelectedIndexChanged += new System.EventHandler(this.availableEmployeeListView_SelectedIndexChanged);
            // 
            // employeeIdHeader
            // 
            this.employeeIdHeader.Text = "Id";
            this.employeeIdHeader.Width = 120;
            // 
            // employeeNameHeader
            // 
            this.employeeNameHeader.Text = "Name";
            this.employeeNameHeader.Width = 120;
            // 
            // employeeRoleHeader
            // 
            this.employeeRoleHeader.Text = "Role";
            this.employeeRoleHeader.Width = 100;
            // 
            // availableEmployeeLabel
            // 
            this.availableEmployeeLabel.AutoSize = true;
            this.availableEmployeeLabel.Location = new System.Drawing.Point(109, 30);
            this.availableEmployeeLabel.Name = "availableEmployeeLabel";
            this.availableEmployeeLabel.Size = new System.Drawing.Size(124, 19);
            this.availableEmployeeLabel.TabIndex = 2;
            this.availableEmployeeLabel.Text = "Available Employee";
            // 
            // assignProjectToolTip
            // 
            this.assignProjectToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.assignProjectToolTip.StyleManager = null;
            this.assignProjectToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // AssignProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 465);
            this.Controls.Add(this.availableEmployeePanel);
            this.Controls.Add(this.searchProjectPanel);
            this.MaximizeBox = false;
            this.Name = "AssignProject";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssignProject_FormClosing);
            this.Load += new System.EventHandler(this.AssignProject_Load);
            this.searchProjectPanel.ResumeLayout(false);
            this.searchProjectPanel.PerformLayout();
            this.availableEmployeePanel.ResumeLayout(false);
            this.availableEmployeePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel searchProjectPanel;
        private MetroFramework.Controls.MetroLabel projectNameLabel;
        private MetroFramework.Controls.MetroListView projectListView;
        private MetroFramework.Controls.MetroTextBox projectNameTextBox;
        private System.Windows.Forms.ColumnHeader projectHeader;
        private System.Windows.Forms.ColumnHeader teamLeaderHeader;
        private System.Windows.Forms.ColumnHeader processingHeader;
        private System.Windows.Forms.ColumnHeader timeLineHeader;
        private MetroFramework.Controls.MetroPanel availableEmployeePanel;
        private MetroFramework.Controls.MetroLabel availableEmployeeLabel;
        private MetroFramework.Controls.MetroListView availableEmployeeListView;
        private System.Windows.Forms.ColumnHeader employeeNameHeader;
        private System.Windows.Forms.ColumnHeader employeeRoleHeader;
        private System.Windows.Forms.ColumnHeader employeeIdHeader;
        private MetroFramework.Controls.MetroLabel infoPositionLabel;
        private MetroFramework.Controls.MetroLabel setPossitionLabel;
        private MetroFramework.Controls.MetroComboBox possitionComboBox;
        private MetroFramework.Components.MetroToolTip assignProjectToolTip;
        private System.Windows.Forms.ColumnHeader projectIdHeader;
        private MetroFramework.Controls.MetroButton assignButton;
    }
}