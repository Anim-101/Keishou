namespace DemoBoxFirst
{
    partial class Pending
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
            this.pendingRequestLabel = new MetroFramework.Controls.MetroLabel();
            this.pendingNewListView = new MetroFramework.Controls.MetroListView();
            this.employeeIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currentRoleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roleLabel = new MetroFramework.Controls.MetroLabel();
            this.rolesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.statusLabel = new MetroFramework.Controls.MetroLabel();
            this.statusComboBox = new MetroFramework.Controls.MetroComboBox();
            this.newEmployeeButton = new MetroFramework.Controls.MetroButton();
            this.oldEmployeeButton = new MetroFramework.Controls.MetroButton();
            this.pendingToolTip = new MetroFramework.Components.MetroToolTip();
            this.pendingNewPanel = new MetroFramework.Controls.MetroPanel();
            this.pendingOldPanel = new MetroFramework.Controls.MetroPanel();
            this.pendingOldListView = new MetroFramework.Controls.MetroListView();
            this.empIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empCurrentStatusHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assignButton = new MetroFramework.Controls.MetroButton();
            this.pendingNewPanel.SuspendLayout();
            this.pendingOldPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pendingRequestLabel
            // 
            this.pendingRequestLabel.AutoSize = true;
            this.pendingRequestLabel.Location = new System.Drawing.Point(44, 39);
            this.pendingRequestLabel.Name = "pendingRequestLabel";
            this.pendingRequestLabel.Size = new System.Drawing.Size(112, 19);
            this.pendingRequestLabel.TabIndex = 0;
            this.pendingRequestLabel.Text = "Pending Requests";
            // 
            // pendingNewListView
            // 
            this.pendingNewListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employeeIdHeader,
            this.employeeNameHeader,
            this.currentRoleHeader});
            this.pendingNewListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pendingNewListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pendingNewListView.FullRowSelect = true;
            this.pendingNewListView.Location = new System.Drawing.Point(0, 0);
            this.pendingNewListView.Name = "pendingNewListView";
            this.pendingNewListView.OwnerDraw = true;
            this.pendingNewListView.Size = new System.Drawing.Size(367, 334);
            this.pendingNewListView.TabIndex = 1;
            this.pendingNewListView.UseCompatibleStateImageBehavior = false;
            this.pendingNewListView.UseSelectable = true;
            this.pendingNewListView.View = System.Windows.Forms.View.Details;
            this.pendingNewListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pendingNewListView_MouseClick);
            this.pendingNewListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pendingNewListView_MouseDoubleClick);
            // 
            // employeeIdHeader
            // 
            this.employeeIdHeader.Text = "Id";
            this.employeeIdHeader.Width = 110;
            // 
            // employeeNameHeader
            // 
            this.employeeNameHeader.Text = "Name";
            this.employeeNameHeader.Width = 120;
            // 
            // currentRoleHeader
            // 
            this.currentRoleHeader.Text = "Role";
            this.currentRoleHeader.Width = 150;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(470, 98);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(40, 19);
            this.roleLabel.TabIndex = 2;
            this.roleLabel.Text = "Roles";
            // 
            // rolesComboBox
            // 
            this.rolesComboBox.FormattingEnabled = true;
            this.rolesComboBox.ItemHeight = 23;
            this.rolesComboBox.Items.AddRange(new object[] {
            "Team Leader",
            "Analyst",
            "Designer",
            "Programmer",
            "Tester"});
            this.rolesComboBox.Location = new System.Drawing.Point(436, 133);
            this.rolesComboBox.Name = "rolesComboBox";
            this.rolesComboBox.Size = new System.Drawing.Size(113, 29);
            this.rolesComboBox.TabIndex = 3;
            this.pendingToolTip.SetToolTip(this.rolesComboBox, "Set Roles for new/existing Employee");
            this.rolesComboBox.UseSelectable = true;
            this.rolesComboBox.SelectedIndexChanged += new System.EventHandler(this.rolesComboBox_SelectedIndexChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(467, 198);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 19);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.ItemHeight = 23;
            this.statusComboBox.Items.AddRange(new object[] {
            "Active",
            "Non Active",
            "Working",
            "On Leave",
            "Left"});
            this.statusComboBox.Location = new System.Drawing.Point(436, 241);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(113, 29);
            this.statusComboBox.TabIndex = 5;
            this.pendingToolTip.SetToolTip(this.statusComboBox, "Set Status for new/existing Employee");
            this.statusComboBox.UseSelectable = true;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // newEmployeeButton
            // 
            this.newEmployeeButton.Location = new System.Drawing.Point(184, 35);
            this.newEmployeeButton.Name = "newEmployeeButton";
            this.newEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.newEmployeeButton.TabIndex = 6;
            this.newEmployeeButton.Text = "New";
            this.pendingToolTip.SetToolTip(this.newEmployeeButton, "Requests from New Employee");
            this.newEmployeeButton.UseSelectable = true;
            this.newEmployeeButton.Click += new System.EventHandler(this.newEmployeeButton_Click);
            // 
            // oldEmployeeButton
            // 
            this.oldEmployeeButton.Location = new System.Drawing.Point(299, 35);
            this.oldEmployeeButton.Name = "oldEmployeeButton";
            this.oldEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.oldEmployeeButton.TabIndex = 7;
            this.oldEmployeeButton.Text = "Old";
            this.pendingToolTip.SetToolTip(this.oldEmployeeButton, "Requests from Existing Employee");
            this.oldEmployeeButton.UseSelectable = true;
            this.oldEmployeeButton.Click += new System.EventHandler(this.oldEmployeeButton_Click);
            // 
            // pendingToolTip
            // 
            this.pendingToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.pendingToolTip.StyleManager = null;
            this.pendingToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pendingNewPanel
            // 
            this.pendingNewPanel.Controls.Add(this.pendingNewListView);
            this.pendingNewPanel.HorizontalScrollbarBarColor = true;
            this.pendingNewPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.pendingNewPanel.HorizontalScrollbarSize = 10;
            this.pendingNewPanel.Location = new System.Drawing.Point(44, 78);
            this.pendingNewPanel.Name = "pendingNewPanel";
            this.pendingNewPanel.Size = new System.Drawing.Size(367, 334);
            this.pendingNewPanel.TabIndex = 8;
            this.pendingNewPanel.VerticalScrollbarBarColor = true;
            this.pendingNewPanel.VerticalScrollbarHighlightOnWheel = false;
            this.pendingNewPanel.VerticalScrollbarSize = 10;
            // 
            // pendingOldPanel
            // 
            this.pendingOldPanel.Controls.Add(this.pendingOldListView);
            this.pendingOldPanel.HorizontalScrollbarBarColor = true;
            this.pendingOldPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.pendingOldPanel.HorizontalScrollbarSize = 10;
            this.pendingOldPanel.Location = new System.Drawing.Point(44, 78);
            this.pendingOldPanel.Name = "pendingOldPanel";
            this.pendingOldPanel.Size = new System.Drawing.Size(367, 334);
            this.pendingOldPanel.TabIndex = 9;
            this.pendingOldPanel.VerticalScrollbarBarColor = true;
            this.pendingOldPanel.VerticalScrollbarHighlightOnWheel = false;
            this.pendingOldPanel.VerticalScrollbarSize = 10;
            // 
            // pendingOldListView
            // 
            this.pendingOldListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.empIdHeader,
            this.empNameHeader,
            this.empCurrentStatusHeader});
            this.pendingOldListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pendingOldListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pendingOldListView.FullRowSelect = true;
            this.pendingOldListView.Location = new System.Drawing.Point(0, 0);
            this.pendingOldListView.Name = "pendingOldListView";
            this.pendingOldListView.OwnerDraw = true;
            this.pendingOldListView.Size = new System.Drawing.Size(367, 334);
            this.pendingOldListView.TabIndex = 2;
            this.pendingOldListView.UseCompatibleStateImageBehavior = false;
            this.pendingOldListView.UseSelectable = true;
            this.pendingOldListView.View = System.Windows.Forms.View.Details;
            this.pendingOldListView.SelectedIndexChanged += new System.EventHandler(this.pendingOldListView_SelectedIndexChanged);
            // 
            // empIdHeader
            // 
            this.empIdHeader.Text = "Id";
            this.empIdHeader.Width = 80;
            // 
            // empNameHeader
            // 
            this.empNameHeader.Text = "Name";
            this.empNameHeader.Width = 120;
            // 
            // empCurrentStatusHeader
            // 
            this.empCurrentStatusHeader.Text = "Current Status";
            this.empCurrentStatusHeader.Width = 170;
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(467, 326);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(63, 27);
            this.assignButton.TabIndex = 10;
            this.assignButton.Text = "Assign";
            this.assignButton.UseSelectable = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // Pending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 435);
            this.Controls.Add(this.pendingNewPanel);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.pendingOldPanel);
            this.Controls.Add(this.oldEmployeeButton);
            this.Controls.Add(this.newEmployeeButton);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.rolesComboBox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.pendingRequestLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pending";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Pending_Load);
            this.pendingNewPanel.ResumeLayout(false);
            this.pendingOldPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel pendingRequestLabel;
        private MetroFramework.Controls.MetroListView pendingNewListView;
        private System.Windows.Forms.ColumnHeader employeeIdHeader;
        private System.Windows.Forms.ColumnHeader employeeNameHeader;
        private System.Windows.Forms.ColumnHeader currentRoleHeader;
        private MetroFramework.Controls.MetroLabel roleLabel;
        private MetroFramework.Controls.MetroComboBox rolesComboBox;
        private MetroFramework.Controls.MetroLabel statusLabel;
        private MetroFramework.Controls.MetroComboBox statusComboBox;
        private MetroFramework.Controls.MetroButton newEmployeeButton;
        private MetroFramework.Controls.MetroButton oldEmployeeButton;
        private MetroFramework.Components.MetroToolTip pendingToolTip;
        private MetroFramework.Controls.MetroPanel pendingNewPanel;
        private MetroFramework.Controls.MetroPanel pendingOldPanel;
        private MetroFramework.Controls.MetroListView pendingOldListView;
        private System.Windows.Forms.ColumnHeader empIdHeader;
        private System.Windows.Forms.ColumnHeader empNameHeader;
        private System.Windows.Forms.ColumnHeader empCurrentStatusHeader;
        private MetroFramework.Controls.MetroButton assignButton;
    }
}