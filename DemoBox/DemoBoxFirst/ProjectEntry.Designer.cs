namespace DemoBoxFirst
{
    partial class ProjectEntry
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
            this.estimatedCostLabel = new MetroFramework.Controls.MetroLabel();
            this.estimatedTimeLabel = new MetroFramework.Controls.MetroLabel();
            this.projectCostLabel = new MetroFramework.Controls.MetroLabel();
            this.projectTimelineLabel = new MetroFramework.Controls.MetroLabel();
            this.clientEmailLabel6 = new MetroFramework.Controls.MetroLabel();
            this.ProjectClientLabel = new MetroFramework.Controls.MetroLabel();
            this.projectNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.projectClientTextBox = new MetroFramework.Controls.MetroTextBox();
            this.clientEmailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.projectTimelineTextBox = new MetroFramework.Controls.MetroTextBox();
            this.projectCostTextBox = new MetroFramework.Controls.MetroTextBox();
            this.estimatedTimeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.estimatedCostTextBox = new MetroFramework.Controls.MetroTextBox();
            this.clientContactNoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.clientContactNoLabel = new MetroFramework.Controls.MetroLabel();
            this.deliveryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.deliveryDateLabel = new MetroFramework.Controls.MetroLabel();
            this.specificationTextBox = new MetroFramework.Controls.MetroTextBox();
            this.specificationLabel = new MetroFramework.Controls.MetroLabel();
            this.backLink = new MetroFramework.Controls.MetroLink();
            this.doneLink = new MetroFramework.Controls.MetroLink();
            this.projectEntryToolTip = new MetroFramework.Components.MetroToolTip();
            this.SuspendLayout();
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(37, 31);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(90, 19);
            this.projectNameLabel.TabIndex = 0;
            this.projectNameLabel.Text = "Project Name";
            this.projectEntryToolTip.SetToolTip(this.projectNameLabel, "Enter your Project\'s Name");
            // 
            // estimatedCostLabel
            // 
            this.estimatedCostLabel.AutoSize = true;
            this.estimatedCostLabel.Location = new System.Drawing.Point(37, 283);
            this.estimatedCostLabel.Name = "estimatedCostLabel";
            this.estimatedCostLabel.Size = new System.Drawing.Size(96, 19);
            this.estimatedCostLabel.TabIndex = 1;
            this.estimatedCostLabel.Text = "Estimated Cost";
            this.projectEntryToolTip.SetToolTip(this.estimatedCostLabel, "Cost to complete this Project");
            // 
            // estimatedTimeLabel
            // 
            this.estimatedTimeLabel.AutoSize = true;
            this.estimatedTimeLabel.Location = new System.Drawing.Point(37, 247);
            this.estimatedTimeLabel.Name = "estimatedTimeLabel";
            this.estimatedTimeLabel.Size = new System.Drawing.Size(99, 19);
            this.estimatedTimeLabel.TabIndex = 2;
            this.estimatedTimeLabel.Text = "Estimated Time";
            this.projectEntryToolTip.SetToolTip(this.estimatedTimeLabel, "Time needed to complete this Project");
            // 
            // projectCostLabel
            // 
            this.projectCostLabel.AutoSize = true;
            this.projectCostLabel.Location = new System.Drawing.Point(37, 211);
            this.projectCostLabel.Name = "projectCostLabel";
            this.projectCostLabel.Size = new System.Drawing.Size(80, 19);
            this.projectCostLabel.TabIndex = 3;
            this.projectCostLabel.Text = "Project Cost";
            this.projectEntryToolTip.SetToolTip(this.projectCostLabel, "Project\'s Cost given by Client");
            // 
            // projectTimelineLabel
            // 
            this.projectTimelineLabel.AutoSize = true;
            this.projectTimelineLabel.Location = new System.Drawing.Point(37, 175);
            this.projectTimelineLabel.Name = "projectTimelineLabel";
            this.projectTimelineLabel.Size = new System.Drawing.Size(103, 19);
            this.projectTimelineLabel.TabIndex = 4;
            this.projectTimelineLabel.Text = "Project Timeline";
            this.projectEntryToolTip.SetToolTip(this.projectTimelineLabel, "Project Timeline given by Client");
            // 
            // clientEmailLabel6
            // 
            this.clientEmailLabel6.AutoSize = true;
            this.clientEmailLabel6.Location = new System.Drawing.Point(37, 103);
            this.clientEmailLabel6.Name = "clientEmailLabel6";
            this.clientEmailLabel6.Size = new System.Drawing.Size(78, 19);
            this.clientEmailLabel6.TabIndex = 5;
            this.clientEmailLabel6.Text = "Client Email";
            this.projectEntryToolTip.SetToolTip(this.clientEmailLabel6, "Client\'s Email");
            // 
            // ProjectClientLabel
            // 
            this.ProjectClientLabel.AutoSize = true;
            this.ProjectClientLabel.Location = new System.Drawing.Point(37, 67);
            this.ProjectClientLabel.Name = "ProjectClientLabel";
            this.ProjectClientLabel.Size = new System.Drawing.Size(87, 19);
            this.ProjectClientLabel.TabIndex = 6;
            this.ProjectClientLabel.Text = "Project Client";
            this.projectEntryToolTip.SetToolTip(this.ProjectClientLabel, "Project\'s Client Name");
            // 
            // projectNameTextBox
            // 
            // 
            // 
            // 
            this.projectNameTextBox.CustomButton.Image = null;
            this.projectNameTextBox.CustomButton.Location = new System.Drawing.Point(267, 1);
            this.projectNameTextBox.CustomButton.Name = "";
            this.projectNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.projectNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.projectNameTextBox.CustomButton.TabIndex = 1;
            this.projectNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.projectNameTextBox.CustomButton.UseSelectable = true;
            this.projectNameTextBox.CustomButton.Visible = false;
            this.projectNameTextBox.Lines = new string[0];
            this.projectNameTextBox.Location = new System.Drawing.Point(180, 31);
            this.projectNameTextBox.MaxLength = 32767;
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.PasswordChar = '\0';
            this.projectNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.projectNameTextBox.SelectedText = "";
            this.projectNameTextBox.SelectionLength = 0;
            this.projectNameTextBox.SelectionStart = 0;
            this.projectNameTextBox.ShortcutsEnabled = true;
            this.projectNameTextBox.Size = new System.Drawing.Size(289, 23);
            this.projectNameTextBox.TabIndex = 7;
            this.projectNameTextBox.UseSelectable = true;
            this.projectNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.projectNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // projectClientTextBox
            // 
            // 
            // 
            // 
            this.projectClientTextBox.CustomButton.Image = null;
            this.projectClientTextBox.CustomButton.Location = new System.Drawing.Point(267, 1);
            this.projectClientTextBox.CustomButton.Name = "";
            this.projectClientTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.projectClientTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.projectClientTextBox.CustomButton.TabIndex = 1;
            this.projectClientTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.projectClientTextBox.CustomButton.UseSelectable = true;
            this.projectClientTextBox.CustomButton.Visible = false;
            this.projectClientTextBox.Lines = new string[0];
            this.projectClientTextBox.Location = new System.Drawing.Point(180, 67);
            this.projectClientTextBox.MaxLength = 32767;
            this.projectClientTextBox.Name = "projectClientTextBox";
            this.projectClientTextBox.PasswordChar = '\0';
            this.projectClientTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.projectClientTextBox.SelectedText = "";
            this.projectClientTextBox.SelectionLength = 0;
            this.projectClientTextBox.SelectionStart = 0;
            this.projectClientTextBox.ShortcutsEnabled = true;
            this.projectClientTextBox.Size = new System.Drawing.Size(289, 23);
            this.projectClientTextBox.TabIndex = 8;
            this.projectClientTextBox.UseSelectable = true;
            this.projectClientTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.projectClientTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // clientEmailTextBox
            // 
            // 
            // 
            // 
            this.clientEmailTextBox.CustomButton.Image = null;
            this.clientEmailTextBox.CustomButton.Location = new System.Drawing.Point(267, 1);
            this.clientEmailTextBox.CustomButton.Name = "";
            this.clientEmailTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.clientEmailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.clientEmailTextBox.CustomButton.TabIndex = 1;
            this.clientEmailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clientEmailTextBox.CustomButton.UseSelectable = true;
            this.clientEmailTextBox.CustomButton.Visible = false;
            this.clientEmailTextBox.Lines = new string[0];
            this.clientEmailTextBox.Location = new System.Drawing.Point(180, 103);
            this.clientEmailTextBox.MaxLength = 32767;
            this.clientEmailTextBox.Name = "clientEmailTextBox";
            this.clientEmailTextBox.PasswordChar = '\0';
            this.clientEmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clientEmailTextBox.SelectedText = "";
            this.clientEmailTextBox.SelectionLength = 0;
            this.clientEmailTextBox.SelectionStart = 0;
            this.clientEmailTextBox.ShortcutsEnabled = true;
            this.clientEmailTextBox.Size = new System.Drawing.Size(289, 23);
            this.clientEmailTextBox.TabIndex = 9;
            this.clientEmailTextBox.UseSelectable = true;
            this.clientEmailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clientEmailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // projectTimelineTextBox
            // 
            // 
            // 
            // 
            this.projectTimelineTextBox.CustomButton.Image = null;
            this.projectTimelineTextBox.CustomButton.Location = new System.Drawing.Point(267, 1);
            this.projectTimelineTextBox.CustomButton.Name = "";
            this.projectTimelineTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.projectTimelineTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.projectTimelineTextBox.CustomButton.TabIndex = 1;
            this.projectTimelineTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.projectTimelineTextBox.CustomButton.UseSelectable = true;
            this.projectTimelineTextBox.CustomButton.Visible = false;
            this.projectTimelineTextBox.Lines = new string[0];
            this.projectTimelineTextBox.Location = new System.Drawing.Point(180, 175);
            this.projectTimelineTextBox.MaxLength = 32767;
            this.projectTimelineTextBox.Name = "projectTimelineTextBox";
            this.projectTimelineTextBox.PasswordChar = '\0';
            this.projectTimelineTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.projectTimelineTextBox.SelectedText = "";
            this.projectTimelineTextBox.SelectionLength = 0;
            this.projectTimelineTextBox.SelectionStart = 0;
            this.projectTimelineTextBox.ShortcutsEnabled = true;
            this.projectTimelineTextBox.Size = new System.Drawing.Size(289, 23);
            this.projectTimelineTextBox.TabIndex = 10;
            this.projectTimelineTextBox.UseSelectable = true;
            this.projectTimelineTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.projectTimelineTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // projectCostTextBox
            // 
            // 
            // 
            // 
            this.projectCostTextBox.CustomButton.Image = null;
            this.projectCostTextBox.CustomButton.Location = new System.Drawing.Point(267, 1);
            this.projectCostTextBox.CustomButton.Name = "";
            this.projectCostTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.projectCostTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.projectCostTextBox.CustomButton.TabIndex = 1;
            this.projectCostTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.projectCostTextBox.CustomButton.UseSelectable = true;
            this.projectCostTextBox.CustomButton.Visible = false;
            this.projectCostTextBox.Lines = new string[0];
            this.projectCostTextBox.Location = new System.Drawing.Point(180, 211);
            this.projectCostTextBox.MaxLength = 32767;
            this.projectCostTextBox.Name = "projectCostTextBox";
            this.projectCostTextBox.PasswordChar = '\0';
            this.projectCostTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.projectCostTextBox.SelectedText = "";
            this.projectCostTextBox.SelectionLength = 0;
            this.projectCostTextBox.SelectionStart = 0;
            this.projectCostTextBox.ShortcutsEnabled = true;
            this.projectCostTextBox.Size = new System.Drawing.Size(289, 23);
            this.projectCostTextBox.TabIndex = 11;
            this.projectCostTextBox.UseSelectable = true;
            this.projectCostTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.projectCostTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // estimatedTimeTextBox
            // 
            // 
            // 
            // 
            this.estimatedTimeTextBox.CustomButton.Image = null;
            this.estimatedTimeTextBox.CustomButton.Location = new System.Drawing.Point(267, 1);
            this.estimatedTimeTextBox.CustomButton.Name = "";
            this.estimatedTimeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.estimatedTimeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.estimatedTimeTextBox.CustomButton.TabIndex = 1;
            this.estimatedTimeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.estimatedTimeTextBox.CustomButton.UseSelectable = true;
            this.estimatedTimeTextBox.CustomButton.Visible = false;
            this.estimatedTimeTextBox.Lines = new string[0];
            this.estimatedTimeTextBox.Location = new System.Drawing.Point(180, 247);
            this.estimatedTimeTextBox.MaxLength = 32767;
            this.estimatedTimeTextBox.Name = "estimatedTimeTextBox";
            this.estimatedTimeTextBox.PasswordChar = '\0';
            this.estimatedTimeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.estimatedTimeTextBox.SelectedText = "";
            this.estimatedTimeTextBox.SelectionLength = 0;
            this.estimatedTimeTextBox.SelectionStart = 0;
            this.estimatedTimeTextBox.ShortcutsEnabled = true;
            this.estimatedTimeTextBox.Size = new System.Drawing.Size(289, 23);
            this.estimatedTimeTextBox.TabIndex = 12;
            this.estimatedTimeTextBox.UseSelectable = true;
            this.estimatedTimeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.estimatedTimeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // estimatedCostTextBox
            // 
            // 
            // 
            // 
            this.estimatedCostTextBox.CustomButton.Image = null;
            this.estimatedCostTextBox.CustomButton.Location = new System.Drawing.Point(267, 1);
            this.estimatedCostTextBox.CustomButton.Name = "";
            this.estimatedCostTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.estimatedCostTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.estimatedCostTextBox.CustomButton.TabIndex = 1;
            this.estimatedCostTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.estimatedCostTextBox.CustomButton.UseSelectable = true;
            this.estimatedCostTextBox.CustomButton.Visible = false;
            this.estimatedCostTextBox.Lines = new string[0];
            this.estimatedCostTextBox.Location = new System.Drawing.Point(180, 283);
            this.estimatedCostTextBox.MaxLength = 32767;
            this.estimatedCostTextBox.Name = "estimatedCostTextBox";
            this.estimatedCostTextBox.PasswordChar = '\0';
            this.estimatedCostTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.estimatedCostTextBox.SelectedText = "";
            this.estimatedCostTextBox.SelectionLength = 0;
            this.estimatedCostTextBox.SelectionStart = 0;
            this.estimatedCostTextBox.ShortcutsEnabled = true;
            this.estimatedCostTextBox.Size = new System.Drawing.Size(289, 23);
            this.estimatedCostTextBox.TabIndex = 13;
            this.estimatedCostTextBox.UseSelectable = true;
            this.estimatedCostTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.estimatedCostTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // clientContactNoTextBox
            // 
            // 
            // 
            // 
            this.clientContactNoTextBox.CustomButton.Image = null;
            this.clientContactNoTextBox.CustomButton.Location = new System.Drawing.Point(267, 1);
            this.clientContactNoTextBox.CustomButton.Name = "";
            this.clientContactNoTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.clientContactNoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.clientContactNoTextBox.CustomButton.TabIndex = 1;
            this.clientContactNoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clientContactNoTextBox.CustomButton.UseSelectable = true;
            this.clientContactNoTextBox.CustomButton.Visible = false;
            this.clientContactNoTextBox.Lines = new string[0];
            this.clientContactNoTextBox.Location = new System.Drawing.Point(180, 139);
            this.clientContactNoTextBox.MaxLength = 32767;
            this.clientContactNoTextBox.Name = "clientContactNoTextBox";
            this.clientContactNoTextBox.PasswordChar = '\0';
            this.clientContactNoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clientContactNoTextBox.SelectedText = "";
            this.clientContactNoTextBox.SelectionLength = 0;
            this.clientContactNoTextBox.SelectionStart = 0;
            this.clientContactNoTextBox.ShortcutsEnabled = true;
            this.clientContactNoTextBox.Size = new System.Drawing.Size(289, 23);
            this.clientContactNoTextBox.TabIndex = 15;
            this.clientContactNoTextBox.UseSelectable = true;
            this.clientContactNoTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clientContactNoTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // clientContactNoLabel
            // 
            this.clientContactNoLabel.AutoSize = true;
            this.clientContactNoLabel.Location = new System.Drawing.Point(37, 139);
            this.clientContactNoLabel.Name = "clientContactNoLabel";
            this.clientContactNoLabel.Size = new System.Drawing.Size(113, 19);
            this.clientContactNoLabel.TabIndex = 14;
            this.clientContactNoLabel.Text = "Client Contact No";
            this.projectEntryToolTip.SetToolTip(this.clientContactNoLabel, "Client\'s Contact Number");
            // 
            // deliveryDatePicker
            // 
            this.deliveryDatePicker.Location = new System.Drawing.Point(180, 319);
            this.deliveryDatePicker.Name = "deliveryDatePicker";
            this.deliveryDatePicker.Size = new System.Drawing.Size(289, 20);
            this.deliveryDatePicker.TabIndex = 16;
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.AutoSize = true;
            this.deliveryDateLabel.Location = new System.Drawing.Point(37, 319);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(86, 19);
            this.deliveryDateLabel.TabIndex = 17;
            this.deliveryDateLabel.Text = "Delivery Date";
            this.projectEntryToolTip.SetToolTip(this.deliveryDateLabel, "Delivery Date by Client");
            // 
            // specificationTextBox
            // 
            // 
            // 
            // 
            this.specificationTextBox.CustomButton.Image = null;
            this.specificationTextBox.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.specificationTextBox.CustomButton.Name = "";
            this.specificationTextBox.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.specificationTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.specificationTextBox.CustomButton.TabIndex = 1;
            this.specificationTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.specificationTextBox.CustomButton.UseSelectable = true;
            this.specificationTextBox.CustomButton.Visible = false;
            this.specificationTextBox.Lines = new string[0];
            this.specificationTextBox.Location = new System.Drawing.Point(180, 352);
            this.specificationTextBox.MaxLength = 32767;
            this.specificationTextBox.Multiline = true;
            this.specificationTextBox.Name = "specificationTextBox";
            this.specificationTextBox.PasswordChar = '\0';
            this.specificationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.specificationTextBox.SelectedText = "";
            this.specificationTextBox.SelectionLength = 0;
            this.specificationTextBox.SelectionStart = 0;
            this.specificationTextBox.ShortcutsEnabled = true;
            this.specificationTextBox.Size = new System.Drawing.Size(289, 57);
            this.specificationTextBox.TabIndex = 19;
            this.specificationTextBox.UseSelectable = true;
            this.specificationTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.specificationTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // specificationLabel
            // 
            this.specificationLabel.AutoSize = true;
            this.specificationLabel.Location = new System.Drawing.Point(37, 355);
            this.specificationLabel.Name = "specificationLabel";
            this.specificationLabel.Size = new System.Drawing.Size(82, 19);
            this.specificationLabel.TabIndex = 18;
            this.specificationLabel.Text = "Specification";
            this.projectEntryToolTip.SetToolTip(this.specificationLabel, "Recquired Information and Specification for this Project");
            // 
            // backLink
            // 
            this.backLink.Image = global::DemoBoxFirst.Properties.Resources.circle_back_arrow_glyph_1281;
            this.backLink.Location = new System.Drawing.Point(379, 444);
            this.backLink.Name = "backLink";
            this.backLink.Size = new System.Drawing.Size(32, 23);
            this.backLink.TabIndex = 20;
            this.projectEntryToolTip.SetToolTip(this.backLink, "Go Back");
            this.backLink.UseSelectable = true;
            this.backLink.Click += new System.EventHandler(this.backLink_Click);
            // 
            // doneLink
            // 
            this.doneLink.Image = global::DemoBoxFirst.Properties.Resources.done_01_128;
            this.doneLink.Location = new System.Drawing.Point(426, 444);
            this.doneLink.Name = "doneLink";
            this.doneLink.Size = new System.Drawing.Size(40, 23);
            this.doneLink.TabIndex = 21;
            this.projectEntryToolTip.SetToolTip(this.doneLink, "Submit");
            this.doneLink.UseSelectable = true;
            this.doneLink.Click += new System.EventHandler(this.doneLink_Click);
            // 
            // projectEntryToolTip
            // 
            this.projectEntryToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.projectEntryToolTip.StyleManager = null;
            this.projectEntryToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ProjectEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 490);
            this.Controls.Add(this.doneLink);
            this.Controls.Add(this.backLink);
            this.Controls.Add(this.specificationTextBox);
            this.Controls.Add(this.specificationLabel);
            this.Controls.Add(this.deliveryDateLabel);
            this.Controls.Add(this.deliveryDatePicker);
            this.Controls.Add(this.clientContactNoTextBox);
            this.Controls.Add(this.clientContactNoLabel);
            this.Controls.Add(this.estimatedCostTextBox);
            this.Controls.Add(this.estimatedTimeTextBox);
            this.Controls.Add(this.projectCostTextBox);
            this.Controls.Add(this.projectTimelineTextBox);
            this.Controls.Add(this.clientEmailTextBox);
            this.Controls.Add(this.projectClientTextBox);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(this.ProjectClientLabel);
            this.Controls.Add(this.clientEmailLabel6);
            this.Controls.Add(this.projectTimelineLabel);
            this.Controls.Add(this.projectCostLabel);
            this.Controls.Add(this.estimatedTimeLabel);
            this.Controls.Add(this.estimatedCostLabel);
            this.Controls.Add(this.projectNameLabel);
            this.MaximizeBox = false;
            this.Name = "ProjectEntry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectEntry_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel projectNameLabel;
        private MetroFramework.Controls.MetroLabel estimatedCostLabel;
        private MetroFramework.Controls.MetroLabel estimatedTimeLabel;
        private MetroFramework.Controls.MetroLabel projectCostLabel;
        private MetroFramework.Controls.MetroLabel projectTimelineLabel;
        private MetroFramework.Controls.MetroLabel clientEmailLabel6;
        private MetroFramework.Controls.MetroLabel ProjectClientLabel;
        private MetroFramework.Controls.MetroTextBox projectNameTextBox;
        private MetroFramework.Controls.MetroTextBox projectClientTextBox;
        private MetroFramework.Controls.MetroTextBox clientEmailTextBox;
        private MetroFramework.Controls.MetroTextBox projectTimelineTextBox;
        private MetroFramework.Controls.MetroTextBox projectCostTextBox;
        private MetroFramework.Controls.MetroTextBox estimatedTimeTextBox;
        private MetroFramework.Controls.MetroTextBox estimatedCostTextBox;
        private MetroFramework.Controls.MetroTextBox clientContactNoTextBox;
        private MetroFramework.Controls.MetroLabel clientContactNoLabel;
        private System.Windows.Forms.DateTimePicker deliveryDatePicker;
        private MetroFramework.Controls.MetroLabel deliveryDateLabel;
        private MetroFramework.Controls.MetroTextBox specificationTextBox;
        private MetroFramework.Controls.MetroLabel specificationLabel;
        private MetroFramework.Controls.MetroLink backLink;
        private MetroFramework.Controls.MetroLink doneLink;
        private MetroFramework.Components.MetroToolTip projectEntryToolTip;
    }
}