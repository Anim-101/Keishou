namespace DemoBoxFirst
{
    partial class EmployeeManagement
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
            this.empNameLabel = new MetroFramework.Controls.MetroLabel();
            this.empDateTime = new MetroFramework.Controls.MetroDateTime();
            this.pendingRequestToolTip = new MetroFramework.Components.MetroToolTip();
            this.empInfoButton = new MetroFramework.Controls.MetroButton();
            this.empSendEmailButton = new MetroFramework.Controls.MetroButton();
            this.projectHubButton = new MetroFramework.Controls.MetroButton();
            this.joinedAsTextLabel = new MetroFramework.Controls.MetroLabel();
            this.browseButton = new MetroFramework.Controls.MetroButton();
            this.downloadFileButton = new MetroFramework.Controls.MetroButton();
            this.pendingRequestLink = new MetroFramework.Controls.MetroLink();
            this.empLogoutLink = new MetroFramework.Controls.MetroLink();
            this.employeeIdLabel = new MetroFramework.Controls.MetroLabel();
            this.joinedAsLabel = new MetroFramework.Controls.MetroLabel();
            this.statusLabel = new MetroFramework.Controls.MetroLabel();
            this.empProjectStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.empProjectStatusTextLabel = new MetroFramework.Controls.MetroLabel();
            this.uploadLabel = new MetroFramework.Controls.MetroLabel();
            this.uploadingFileTextBox = new MetroFramework.Controls.MetroTextBox();
            this.uploadDownloadPanel = new MetroFramework.Controls.MetroPanel();
            this.downloadLabel = new MetroFramework.Controls.MetroLabel();
            this.projectOnWorkListView = new MetroFramework.Controls.MetroListView();
            this.projectNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileUploadedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.commitHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.presentLabel = new MetroFramework.Controls.MetroLabel();
            this.empStatusTextLabel = new MetroFramework.Controls.MetroLabel();
            this.uploadButton = new MetroFramework.Controls.MetroButton();
            this.uploadDownloadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // empNameLabel
            // 
            this.empNameLabel.AutoSize = true;
            this.empNameLabel.Location = new System.Drawing.Point(86, 28);
            this.empNameLabel.Name = "empNameLabel";
            this.empNameLabel.Size = new System.Drawing.Size(43, 19);
            this.empNameLabel.TabIndex = 0;
            this.empNameLabel.Text = "Akash";
            this.pendingRequestToolTip.SetToolTip(this.empNameLabel, "Name");
            // 
            // empDateTime
            // 
            this.empDateTime.Location = new System.Drawing.Point(527, 18);
            this.empDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.empDateTime.Name = "empDateTime";
            this.empDateTime.Size = new System.Drawing.Size(213, 29);
            this.empDateTime.TabIndex = 1;
            // 
            // pendingRequestToolTip
            // 
            this.pendingRequestToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.pendingRequestToolTip.StyleManager = null;
            this.pendingRequestToolTip.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pendingRequestToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.pendingRequestToolTip_Popup);
            // 
            // empInfoButton
            // 
            this.empInfoButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.empInfoButton.Location = new System.Drawing.Point(47, 63);
            this.empInfoButton.Name = "empInfoButton";
            this.empInfoButton.Size = new System.Drawing.Size(75, 23);
            this.empInfoButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.empInfoButton.TabIndex = 3;
            this.empInfoButton.Text = "Info";
            this.pendingRequestToolTip.SetToolTip(this.empInfoButton, "Check your Informations");
            this.empInfoButton.UseSelectable = true;
            this.empInfoButton.Click += new System.EventHandler(this.empInfoButton_Click);
            // 
            // empSendEmailButton
            // 
            this.empSendEmailButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.empSendEmailButton.Location = new System.Drawing.Point(47, 104);
            this.empSendEmailButton.Name = "empSendEmailButton";
            this.empSendEmailButton.Size = new System.Drawing.Size(75, 23);
            this.empSendEmailButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.empSendEmailButton.TabIndex = 4;
            this.empSendEmailButton.Text = "Email";
            this.pendingRequestToolTip.SetToolTip(this.empSendEmailButton, "Send An Email ?");
            this.empSendEmailButton.UseSelectable = true;
            this.empSendEmailButton.Click += new System.EventHandler(this.empSendEmailButton_Click);
            // 
            // projectHubButton
            // 
            this.projectHubButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.projectHubButton.Location = new System.Drawing.Point(47, 149);
            this.projectHubButton.Name = "projectHubButton";
            this.projectHubButton.Size = new System.Drawing.Size(75, 23);
            this.projectHubButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.projectHubButton.TabIndex = 6;
            this.projectHubButton.Text = "Hub";
            this.pendingRequestToolTip.SetToolTip(this.projectHubButton, "Project Hub");
            this.projectHubButton.UseSelectable = true;
            this.projectHubButton.Click += new System.EventHandler(this.projectHubButton_Click);
            // 
            // joinedAsTextLabel
            // 
            this.joinedAsTextLabel.AutoSize = true;
            this.joinedAsTextLabel.Location = new System.Drawing.Point(583, 67);
            this.joinedAsTextLabel.Name = "joinedAsTextLabel";
            this.joinedAsTextLabel.Size = new System.Drawing.Size(86, 19);
            this.joinedAsTextLabel.TabIndex = 7;
            this.joinedAsTextLabel.Text = "Team Leader";
            this.pendingRequestToolTip.SetToolTip(this.joinedAsTextLabel, "You joined position in this company.");
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(591, 139);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(56, 23);
            this.browseButton.TabIndex = 14;
            this.browseButton.Text = "Browse";
            this.pendingRequestToolTip.SetToolTip(this.browseButton, "Browse File from your Device to Upload");
            this.browseButton.UseSelectable = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // downloadFileButton
            // 
            this.downloadFileButton.Location = new System.Drawing.Point(450, 196);
            this.downloadFileButton.Name = "downloadFileButton";
            this.downloadFileButton.Size = new System.Drawing.Size(107, 23);
            this.downloadFileButton.TabIndex = 18;
            this.downloadFileButton.Text = "Download";
            this.pendingRequestToolTip.SetToolTip(this.downloadFileButton, "Download FILE");
            this.downloadFileButton.UseSelectable = true;
            // 
            // pendingRequestLink
            // 
            this.pendingRequestLink.Image = global::DemoBoxFirst.Properties.Resources.health_fitness_35_128;
            this.pendingRequestLink.Location = new System.Drawing.Point(490, 16);
            this.pendingRequestLink.Name = "pendingRequestLink";
            this.pendingRequestLink.Size = new System.Drawing.Size(31, 31);
            this.pendingRequestLink.TabIndex = 2;
            this.pendingRequestToolTip.SetToolTip(this.pendingRequestLink, "Pending Requests !!");
            this.pendingRequestLink.UseSelectable = true;
            // 
            // empLogoutLink
            // 
            this.empLogoutLink.Image = global::DemoBoxFirst.Properties.Resources.circle_back_arrow_glyph_1281;
            this.empLogoutLink.Location = new System.Drawing.Point(8, 7);
            this.empLogoutLink.Name = "empLogoutLink";
            this.empLogoutLink.Size = new System.Drawing.Size(33, 30);
            this.empLogoutLink.TabIndex = 16;
            this.empLogoutLink.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pendingRequestToolTip.SetToolTip(this.empLogoutLink, "Logout.");
            this.empLogoutLink.UseSelectable = true;
            this.empLogoutLink.Click += new System.EventHandler(this.empLogoutLink_Click);
            // 
            // employeeIdLabel
            // 
            this.employeeIdLabel.AutoSize = true;
            this.employeeIdLabel.Location = new System.Drawing.Point(60, 28);
            this.employeeIdLabel.Name = "employeeIdLabel";
            this.employeeIdLabel.Size = new System.Drawing.Size(20, 19);
            this.employeeIdLabel.TabIndex = 17;
            this.employeeIdLabel.Text = "Id";
            this.pendingRequestToolTip.SetToolTip(this.employeeIdLabel, "Id");
            // 
            // joinedAsLabel
            // 
            this.joinedAsLabel.AutoSize = true;
            this.joinedAsLabel.Location = new System.Drawing.Point(456, 67);
            this.joinedAsLabel.Name = "joinedAsLabel";
            this.joinedAsLabel.Size = new System.Drawing.Size(65, 19);
            this.joinedAsLabel.Style = MetroFramework.MetroColorStyle.White;
            this.joinedAsLabel.TabIndex = 5;
            this.joinedAsLabel.Text = "Joined As";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(456, 103);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 19);
            this.statusLabel.Style = MetroFramework.MetroColorStyle.White;
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Status";
            // 
            // empProjectStatusLabel
            // 
            this.empProjectStatusLabel.AutoSize = true;
            this.empProjectStatusLabel.Location = new System.Drawing.Point(456, 139);
            this.empProjectStatusLabel.Name = "empProjectStatusLabel";
            this.empProjectStatusLabel.Size = new System.Drawing.Size(54, 19);
            this.empProjectStatusLabel.Style = MetroFramework.MetroColorStyle.White;
            this.empProjectStatusLabel.TabIndex = 10;
            this.empProjectStatusLabel.Text = "Project ";
            // 
            // empProjectStatusTextLabel
            // 
            this.empProjectStatusTextLabel.AutoSize = true;
            this.empProjectStatusTextLabel.Location = new System.Drawing.Point(583, 139);
            this.empProjectStatusTextLabel.Name = "empProjectStatusTextLabel";
            this.empProjectStatusTextLabel.Size = new System.Drawing.Size(28, 19);
            this.empProjectStatusTextLabel.TabIndex = 11;
            this.empProjectStatusTextLabel.Text = "Nill";
            // 
            // uploadLabel
            // 
            this.uploadLabel.AutoSize = true;
            this.uploadLabel.Location = new System.Drawing.Point(513, 16);
            this.uploadLabel.Name = "uploadLabel";
            this.uploadLabel.Size = new System.Drawing.Size(153, 19);
            this.uploadLabel.TabIndex = 12;
            this.uploadLabel.Text = "Upload FILE to DataBase";
            // 
            // uploadingFileTextBox
            // 
            // 
            // 
            // 
            this.uploadingFileTextBox.CustomButton.Image = null;
            this.uploadingFileTextBox.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.uploadingFileTextBox.CustomButton.Name = "";
            this.uploadingFileTextBox.CustomButton.Size = new System.Drawing.Size(67, 67);
            this.uploadingFileTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uploadingFileTextBox.CustomButton.TabIndex = 1;
            this.uploadingFileTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uploadingFileTextBox.CustomButton.UseSelectable = true;
            this.uploadingFileTextBox.CustomButton.Visible = false;
            this.uploadingFileTextBox.Lines = new string[0];
            this.uploadingFileTextBox.Location = new System.Drawing.Point(450, 53);
            this.uploadingFileTextBox.MaxLength = 32767;
            this.uploadingFileTextBox.Multiline = true;
            this.uploadingFileTextBox.Name = "uploadingFileTextBox";
            this.uploadingFileTextBox.PasswordChar = '\0';
            this.uploadingFileTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uploadingFileTextBox.SelectedText = "";
            this.uploadingFileTextBox.SelectionLength = 0;
            this.uploadingFileTextBox.SelectionStart = 0;
            this.uploadingFileTextBox.ShortcutsEnabled = true;
            this.uploadingFileTextBox.Size = new System.Drawing.Size(216, 69);
            this.uploadingFileTextBox.TabIndex = 13;
            this.uploadingFileTextBox.UseSelectable = true;
            this.uploadingFileTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uploadingFileTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uploadDownloadPanel
            // 
            this.uploadDownloadPanel.Controls.Add(this.uploadButton);
            this.uploadDownloadPanel.Controls.Add(this.downloadFileButton);
            this.uploadDownloadPanel.Controls.Add(this.downloadLabel);
            this.uploadDownloadPanel.Controls.Add(this.projectOnWorkListView);
            this.uploadDownloadPanel.Controls.Add(this.presentLabel);
            this.uploadDownloadPanel.Controls.Add(this.browseButton);
            this.uploadDownloadPanel.Controls.Add(this.uploadingFileTextBox);
            this.uploadDownloadPanel.Controls.Add(this.uploadLabel);
            this.uploadDownloadPanel.HorizontalScrollbarBarColor = true;
            this.uploadDownloadPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.uploadDownloadPanel.HorizontalScrollbarSize = 10;
            this.uploadDownloadPanel.Location = new System.Drawing.Point(47, 204);
            this.uploadDownloadPanel.Name = "uploadDownloadPanel";
            this.uploadDownloadPanel.Size = new System.Drawing.Size(693, 249);
            this.uploadDownloadPanel.TabIndex = 15;
            this.uploadDownloadPanel.VerticalScrollbarBarColor = true;
            this.uploadDownloadPanel.VerticalScrollbarHighlightOnWheel = false;
            this.uploadDownloadPanel.VerticalScrollbarSize = 10;
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoSize = true;
            this.downloadLabel.Location = new System.Drawing.Point(331, 196);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(92, 19);
            this.downloadLabel.TabIndex = 17;
            this.downloadLabel.Text = "Download File";
            // 
            // projectOnWorkListView
            // 
            this.projectOnWorkListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projectNameHeader,
            this.fileUploadedHeader,
            this.commitHeader});
            this.projectOnWorkListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.projectOnWorkListView.FullRowSelect = true;
            this.projectOnWorkListView.Location = new System.Drawing.Point(23, 53);
            this.projectOnWorkListView.Name = "projectOnWorkListView";
            this.projectOnWorkListView.OwnerDraw = true;
            this.projectOnWorkListView.Size = new System.Drawing.Size(287, 172);
            this.projectOnWorkListView.TabIndex = 16;
            this.projectOnWorkListView.UseCompatibleStateImageBehavior = false;
            this.projectOnWorkListView.UseSelectable = true;
            this.projectOnWorkListView.View = System.Windows.Forms.View.Details;
            this.projectOnWorkListView.SelectedIndexChanged += new System.EventHandler(this.projectOnWorkListView_SelectedIndexChanged);
            // 
            // projectNameHeader
            // 
            this.projectNameHeader.Text = "Project";
            this.projectNameHeader.Width = 100;
            // 
            // fileUploadedHeader
            // 
            this.fileUploadedHeader.Text = "File Name";
            this.fileUploadedHeader.Width = 100;
            // 
            // commitHeader
            // 
            this.commitHeader.Text = "Commit";
            this.commitHeader.Width = 80;
            // 
            // presentLabel
            // 
            this.presentLabel.AutoSize = true;
            this.presentLabel.Location = new System.Drawing.Point(23, 16);
            this.presentLabel.Name = "presentLabel";
            this.presentLabel.Size = new System.Drawing.Size(152, 19);
            this.presentLabel.TabIndex = 15;
            this.presentLabel.Text = "Present Project on Work";
            // 
            // empStatusTextLabel
            // 
            this.empStatusTextLabel.AutoSize = true;
            this.empStatusTextLabel.Location = new System.Drawing.Point(583, 103);
            this.empStatusTextLabel.Name = "empStatusTextLabel";
            this.empStatusTextLabel.Size = new System.Drawing.Size(0, 0);
            this.empStatusTextLabel.TabIndex = 9;
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(501, 139);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(56, 23);
            this.uploadButton.TabIndex = 19;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseSelectable = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 525);
            this.Controls.Add(this.employeeIdLabel);
            this.Controls.Add(this.empLogoutLink);
            this.Controls.Add(this.uploadDownloadPanel);
            this.Controls.Add(this.empProjectStatusTextLabel);
            this.Controls.Add(this.empProjectStatusLabel);
            this.Controls.Add(this.empStatusTextLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.joinedAsTextLabel);
            this.Controls.Add(this.projectHubButton);
            this.Controls.Add(this.joinedAsLabel);
            this.Controls.Add(this.empSendEmailButton);
            this.Controls.Add(this.empInfoButton);
            this.Controls.Add(this.pendingRequestLink);
            this.Controls.Add(this.empDateTime);
            this.Controls.Add(this.empNameLabel);
            this.MaximizeBox = false;
            this.Name = "EmployeeManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeManagement_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            this.uploadDownloadPanel.ResumeLayout(false);
            this.uploadDownloadPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel empNameLabel;
        private MetroFramework.Controls.MetroDateTime empDateTime;
        private MetroFramework.Components.MetroToolTip pendingRequestToolTip;
        private MetroFramework.Controls.MetroLink pendingRequestLink;
        private MetroFramework.Controls.MetroButton empInfoButton;
        private MetroFramework.Controls.MetroButton empSendEmailButton;
        private MetroFramework.Controls.MetroLabel joinedAsLabel;
        private MetroFramework.Controls.MetroButton projectHubButton;
        private MetroFramework.Controls.MetroLabel joinedAsTextLabel;
        private MetroFramework.Controls.MetroLabel statusLabel;
        private MetroFramework.Controls.MetroLabel empProjectStatusTextLabel;
        private MetroFramework.Controls.MetroLabel empProjectStatusLabel;
        private MetroFramework.Controls.MetroLabel uploadLabel;
        private MetroFramework.Controls.MetroTextBox uploadingFileTextBox;
        private MetroFramework.Controls.MetroButton browseButton;
        private MetroFramework.Controls.MetroPanel uploadDownloadPanel;
        private MetroFramework.Controls.MetroLabel presentLabel;
        private MetroFramework.Controls.MetroLabel downloadLabel;
        private MetroFramework.Controls.MetroListView projectOnWorkListView;
        private System.Windows.Forms.ColumnHeader projectNameHeader;
        private System.Windows.Forms.ColumnHeader fileUploadedHeader;
        private System.Windows.Forms.ColumnHeader commitHeader;
        private MetroFramework.Controls.MetroButton downloadFileButton;
        private MetroFramework.Controls.MetroLink empLogoutLink;
        private MetroFramework.Controls.MetroLabel empStatusTextLabel;
        private MetroFramework.Controls.MetroLabel employeeIdLabel;
        private MetroFramework.Controls.MetroButton uploadButton;
    }
}