namespace DemoBoxFirst
{
    partial class ProjectHub
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
            this.projectNameLabel = new MetroFramework.Controls.MetroLabel();
            this.projectNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.timeRemainingLabel = new MetroFramework.Controls.MetroLabel();
            this.projectDetailsListView = new MetroFramework.Controls.MetroListView();
            this.fileNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editedByHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.positionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deliveryDateLabel = new MetroFramework.Controls.MetroLabel();
            this.statusLabel = new MetroFramework.Controls.MetroLabel();
            this.clientLabel = new MetroFramework.Controls.MetroLabel();
            this.deliveryDateShowLabel = new MetroFramework.Controls.MetroLabel();
            this.showStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.clientShowLabel = new MetroFramework.Controls.MetroLabel();
            this.timeRemainingShowLabel = new MetroFramework.Controls.MetroLabel();
            this.projectRolesLabel = new MetroFramework.Controls.MetroLabel();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.employeeNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projectPosstionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projectTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projectHubToolTip = new MetroFramework.Components.MetroToolTip();
            this.goBackLink = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(23, 32);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(90, 19);
            this.projectNameLabel.TabIndex = 0;
            this.projectNameLabel.Text = "Project Name";
            // 
            // projectNameTextBox
            // 
            // 
            // 
            // 
            this.projectNameTextBox.CustomButton.Image = null;
            this.projectNameTextBox.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.projectNameTextBox.CustomButton.Name = "";
            this.projectNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.projectNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.projectNameTextBox.CustomButton.TabIndex = 1;
            this.projectNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.projectNameTextBox.CustomButton.UseSelectable = true;
            this.projectNameTextBox.CustomButton.Visible = false;
            this.projectNameTextBox.Lines = new string[0];
            this.projectNameTextBox.Location = new System.Drawing.Point(139, 32);
            this.projectNameTextBox.MaxLength = 32767;
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.PasswordChar = '\0';
            this.projectNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.projectNameTextBox.SelectedText = "";
            this.projectNameTextBox.SelectionLength = 0;
            this.projectNameTextBox.SelectionStart = 0;
            this.projectNameTextBox.ShortcutsEnabled = true;
            this.projectNameTextBox.Size = new System.Drawing.Size(282, 23);
            this.projectNameTextBox.TabIndex = 1;
            this.projectHubToolTip.SetToolTip(this.projectNameTextBox, "Search for a Project.");
            this.projectNameTextBox.UseSelectable = true;
            this.projectNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.projectNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.projectNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.projectNameTextBox_KeyDown);
            // 
            // timeRemainingLabel
            // 
            this.timeRemainingLabel.AutoSize = true;
            this.timeRemainingLabel.Location = new System.Drawing.Point(496, 32);
            this.timeRemainingLabel.Name = "timeRemainingLabel";
            this.timeRemainingLabel.Size = new System.Drawing.Size(104, 19);
            this.timeRemainingLabel.TabIndex = 2;
            this.timeRemainingLabel.Text = "Time Remaining";
            // 
            // projectDetailsListView
            // 
            this.projectDetailsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameHeader,
            this.editedByHeader,
            this.positionHeader});
            this.projectDetailsListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.projectDetailsListView.FullRowSelect = true;
            this.projectDetailsListView.Location = new System.Drawing.Point(23, 109);
            this.projectDetailsListView.Name = "projectDetailsListView";
            this.projectDetailsListView.OwnerDraw = true;
            this.projectDetailsListView.Size = new System.Drawing.Size(434, 164);
            this.projectDetailsListView.TabIndex = 4;
            this.projectDetailsListView.UseCompatibleStateImageBehavior = false;
            this.projectDetailsListView.UseSelectable = true;
            this.projectDetailsListView.View = System.Windows.Forms.View.Details;
            this.projectDetailsListView.SelectedIndexChanged += new System.EventHandler(this.projectDetailsListView_SelectedIndexChanged);
            // 
            // fileNameHeader
            // 
            this.fileNameHeader.Text = "File Name";
            this.fileNameHeader.Width = 160;
            // 
            // editedByHeader
            // 
            this.editedByHeader.Text = "Edited By";
            this.editedByHeader.Width = 150;
            // 
            // positionHeader
            // 
            this.positionHeader.Text = "Possition";
            this.positionHeader.Width = 120;
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.AutoSize = true;
            this.deliveryDateLabel.Location = new System.Drawing.Point(27, 322);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(86, 19);
            this.deliveryDateLabel.TabIndex = 5;
            this.deliveryDateLabel.Text = "Delivery Date";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(27, 360);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 19);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Status";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(27, 398);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(42, 19);
            this.clientLabel.TabIndex = 9;
            this.clientLabel.Text = "Client";
            // 
            // deliveryDateShowLabel
            // 
            this.deliveryDateShowLabel.AutoSize = true;
            this.deliveryDateShowLabel.Location = new System.Drawing.Point(142, 322);
            this.deliveryDateShowLabel.Name = "deliveryDateShowLabel";
            this.deliveryDateShowLabel.Size = new System.Drawing.Size(28, 19);
            this.deliveryDateShowLabel.TabIndex = 10;
            this.deliveryDateShowLabel.Text = "NIll";
            this.projectHubToolTip.SetToolTip(this.deliveryDateShowLabel, "Final Delivery Date.");
            // 
            // showStatusLabel
            // 
            this.showStatusLabel.AutoSize = true;
            this.showStatusLabel.Location = new System.Drawing.Point(139, 360);
            this.showStatusLabel.Name = "showStatusLabel";
            this.showStatusLabel.Size = new System.Drawing.Size(34, 19);
            this.showStatusLabel.TabIndex = 11;
            this.showStatusLabel.Text = "NILL";
            this.projectHubToolTip.SetToolTip(this.showStatusLabel, "Current Status of this Project.");
            // 
            // clientShowLabel
            // 
            this.clientShowLabel.AutoSize = true;
            this.clientShowLabel.Location = new System.Drawing.Point(139, 398);
            this.clientShowLabel.Name = "clientShowLabel";
            this.clientShowLabel.Size = new System.Drawing.Size(34, 19);
            this.clientShowLabel.TabIndex = 12;
            this.clientShowLabel.Text = "NILL";
            this.projectHubToolTip.SetToolTip(this.clientShowLabel, "Client of this Project.");
            // 
            // timeRemainingShowLabel
            // 
            this.timeRemainingShowLabel.AutoSize = true;
            this.timeRemainingShowLabel.Location = new System.Drawing.Point(626, 32);
            this.timeRemainingShowLabel.Name = "timeRemainingShowLabel";
            this.timeRemainingShowLabel.Size = new System.Drawing.Size(34, 19);
            this.timeRemainingShowLabel.TabIndex = 13;
            this.timeRemainingShowLabel.Text = "NILL";
            this.projectHubToolTip.SetToolTip(this.timeRemainingShowLabel, "Time Remains for this Project.");
            // 
            // projectRolesLabel
            // 
            this.projectRolesLabel.AutoSize = true;
            this.projectRolesLabel.Location = new System.Drawing.Point(575, 75);
            this.projectRolesLabel.Name = "projectRolesLabel";
            this.projectRolesLabel.Size = new System.Drawing.Size(85, 19);
            this.projectRolesLabel.TabIndex = 14;
            this.projectRolesLabel.Text = "Project Roles";
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employeeNameHeader,
            this.projectPosstionHeader,
            this.projectTimeHeader});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(496, 109);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(261, 270);
            this.metroListView1.TabIndex = 15;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // employeeNameHeader
            // 
            this.employeeNameHeader.Text = "Name";
            this.employeeNameHeader.Width = 100;
            // 
            // projectPosstionHeader
            // 
            this.projectPosstionHeader.Text = "Possition";
            this.projectPosstionHeader.Width = 80;
            // 
            // projectTimeHeader
            // 
            this.projectTimeHeader.Text = "Time";
            this.projectTimeHeader.Width = 90;
            // 
            // projectHubToolTip
            // 
            this.projectHubToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.projectHubToolTip.StyleManager = null;
            this.projectHubToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // goBackLink
            // 
            this.goBackLink.Image = global::DemoBoxFirst.Properties.Resources.circle_back_arrow_glyph_1281;
            this.goBackLink.Location = new System.Drawing.Point(11, 9);
            this.goBackLink.Name = "goBackLink";
            this.goBackLink.Size = new System.Drawing.Size(32, 20);
            this.goBackLink.TabIndex = 16;
            this.goBackLink.UseSelectable = true;
            this.goBackLink.Click += new System.EventHandler(this.goBackLink_Click);
            // 
            // ProjectHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 464);
            this.Controls.Add(this.goBackLink);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.projectRolesLabel);
            this.Controls.Add(this.timeRemainingShowLabel);
            this.Controls.Add(this.clientShowLabel);
            this.Controls.Add(this.showStatusLabel);
            this.Controls.Add(this.deliveryDateShowLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.deliveryDateLabel);
            this.Controls.Add(this.projectDetailsListView);
            this.Controls.Add(this.timeRemainingLabel);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(this.projectNameLabel);
            this.MaximizeBox = false;
            this.Name = "ProjectHub";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectHub_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProjectHub_FormClosed);
            this.Load += new System.EventHandler(this.ProjectHub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel projectNameLabel;
        private MetroFramework.Controls.MetroTextBox projectNameTextBox;
        private MetroFramework.Controls.MetroLabel timeRemainingLabel;
        private MetroFramework.Controls.MetroListView projectDetailsListView;
        private System.Windows.Forms.ColumnHeader fileNameHeader;
        private System.Windows.Forms.ColumnHeader editedByHeader;
        private System.Windows.Forms.ColumnHeader positionHeader;
        private MetroFramework.Controls.MetroLabel deliveryDateLabel;
        private MetroFramework.Controls.MetroLabel statusLabel;
        private MetroFramework.Controls.MetroLabel clientLabel;
        private MetroFramework.Controls.MetroLabel deliveryDateShowLabel;
        private MetroFramework.Controls.MetroLabel showStatusLabel;
        private MetroFramework.Controls.MetroLabel clientShowLabel;
        private MetroFramework.Controls.MetroLabel timeRemainingShowLabel;
        private MetroFramework.Controls.MetroLabel projectRolesLabel;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader employeeNameHeader;
        private System.Windows.Forms.ColumnHeader projectPosstionHeader;
        private System.Windows.Forms.ColumnHeader projectTimeHeader;
        private MetroFramework.Components.MetroToolTip projectHubToolTip;
        private MetroFramework.Controls.MetroLink goBackLink;
    }
}