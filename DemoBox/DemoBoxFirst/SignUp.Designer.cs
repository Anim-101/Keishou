namespace DemoBoxFirst
{
    partial class SignUp
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
            this.uNameLabel = new MetroFramework.Controls.MetroLabel();
            this.uNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.uEmailLabel = new MetroFramework.Controls.MetroLabel();
            this.uPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.uEmailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.uPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.uPhoneNoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.uPhoneNoLabel = new MetroFramework.Controls.MetroLabel();
            this.doneLink = new MetroFramework.Controls.MetroLink();
            this.dateOfBirthLabel = new MetroFramework.Controls.MetroLabel();
            this.dateOfBirthTextBox = new MetroFramework.Controls.MetroTextBox();
            this.genderLabel = new MetroFramework.Controls.MetroLabel();
            this.maleCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.femaleCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.backLink = new MetroFramework.Controls.MetroLink();
            this.signUpToolTip = new MetroFramework.Components.MetroToolTip();
            this.bloodGroupLabel = new MetroFramework.Controls.MetroLabel();
            this.bloodGroupComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // uNameLabel
            // 
            this.uNameLabel.AutoSize = true;
            this.uNameLabel.Location = new System.Drawing.Point(23, 91);
            this.uNameLabel.Name = "uNameLabel";
            this.uNameLabel.Size = new System.Drawing.Size(45, 19);
            this.uNameLabel.TabIndex = 0;
            this.uNameLabel.Text = "Name";
            this.signUpToolTip.SetToolTip(this.uNameLabel, "Enter your Full Name");
            // 
            // uNameTextBox
            // 
            // 
            // 
            // 
            this.uNameTextBox.CustomButton.Image = null;
            this.uNameTextBox.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.uNameTextBox.CustomButton.Name = "";
            this.uNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uNameTextBox.CustomButton.TabIndex = 1;
            this.uNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uNameTextBox.CustomButton.UseSelectable = true;
            this.uNameTextBox.CustomButton.Visible = false;
            this.uNameTextBox.Lines = new string[0];
            this.uNameTextBox.Location = new System.Drawing.Point(153, 91);
            this.uNameTextBox.MaxLength = 32767;
            this.uNameTextBox.Name = "uNameTextBox";
            this.uNameTextBox.PasswordChar = '\0';
            this.uNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uNameTextBox.SelectedText = "";
            this.uNameTextBox.SelectionLength = 0;
            this.uNameTextBox.SelectionStart = 0;
            this.uNameTextBox.ShortcutsEnabled = true;
            this.uNameTextBox.Size = new System.Drawing.Size(180, 23);
            this.uNameTextBox.TabIndex = 1;
            this.signUpToolTip.SetToolTip(this.uNameTextBox, "Input your Full Name");
            this.uNameTextBox.UseSelectable = true;
            this.uNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.uNameTextBox.Click += new System.EventHandler(this.uNameTextBox_Click);
            // 
            // uEmailLabel
            // 
            this.uEmailLabel.AutoSize = true;
            this.uEmailLabel.Location = new System.Drawing.Point(23, 129);
            this.uEmailLabel.Name = "uEmailLabel";
            this.uEmailLabel.Size = new System.Drawing.Size(41, 19);
            this.uEmailLabel.TabIndex = 2;
            this.uEmailLabel.Text = "Email";
            this.signUpToolTip.SetToolTip(this.uEmailLabel, "Enter your Email");
            // 
            // uPasswordLabel
            // 
            this.uPasswordLabel.AutoSize = true;
            this.uPasswordLabel.Location = new System.Drawing.Point(23, 167);
            this.uPasswordLabel.Name = "uPasswordLabel";
            this.uPasswordLabel.Size = new System.Drawing.Size(64, 19);
            this.uPasswordLabel.TabIndex = 3;
            this.uPasswordLabel.Text = "Password";
            this.signUpToolTip.SetToolTip(this.uPasswordLabel, "Enter a Password.");
            // 
            // uEmailTextBox
            // 
            // 
            // 
            // 
            this.uEmailTextBox.CustomButton.Image = null;
            this.uEmailTextBox.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.uEmailTextBox.CustomButton.Name = "";
            this.uEmailTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uEmailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uEmailTextBox.CustomButton.TabIndex = 1;
            this.uEmailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uEmailTextBox.CustomButton.UseSelectable = true;
            this.uEmailTextBox.CustomButton.Visible = false;
            this.uEmailTextBox.Lines = new string[0];
            this.uEmailTextBox.Location = new System.Drawing.Point(153, 129);
            this.uEmailTextBox.MaxLength = 32767;
            this.uEmailTextBox.Name = "uEmailTextBox";
            this.uEmailTextBox.PasswordChar = '\0';
            this.uEmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uEmailTextBox.SelectedText = "";
            this.uEmailTextBox.SelectionLength = 0;
            this.uEmailTextBox.SelectionStart = 0;
            this.uEmailTextBox.ShortcutsEnabled = true;
            this.uEmailTextBox.Size = new System.Drawing.Size(180, 23);
            this.uEmailTextBox.TabIndex = 4;
            this.signUpToolTip.SetToolTip(this.uEmailTextBox, "Input your Email");
            this.uEmailTextBox.UseSelectable = true;
            this.uEmailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uEmailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.uEmailTextBox.Click += new System.EventHandler(this.uEmailTextBox_Click);
            // 
            // uPasswordTextBox
            // 
            // 
            // 
            // 
            this.uPasswordTextBox.CustomButton.Image = null;
            this.uPasswordTextBox.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.uPasswordTextBox.CustomButton.Name = "";
            this.uPasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uPasswordTextBox.CustomButton.TabIndex = 1;
            this.uPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uPasswordTextBox.CustomButton.UseSelectable = true;
            this.uPasswordTextBox.CustomButton.Visible = false;
            this.uPasswordTextBox.Lines = new string[0];
            this.uPasswordTextBox.Location = new System.Drawing.Point(153, 167);
            this.uPasswordTextBox.MaxLength = 32767;
            this.uPasswordTextBox.Name = "uPasswordTextBox";
            this.uPasswordTextBox.PasswordChar = '\0';
            this.uPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uPasswordTextBox.SelectedText = "";
            this.uPasswordTextBox.SelectionLength = 0;
            this.uPasswordTextBox.SelectionStart = 0;
            this.uPasswordTextBox.ShortcutsEnabled = true;
            this.uPasswordTextBox.Size = new System.Drawing.Size(180, 23);
            this.uPasswordTextBox.TabIndex = 5;
            this.signUpToolTip.SetToolTip(this.uPasswordTextBox, "Input your Password here");
            this.uPasswordTextBox.UseSelectable = true;
            this.uPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uPhoneNoTextBox
            // 
            // 
            // 
            // 
            this.uPhoneNoTextBox.CustomButton.Image = null;
            this.uPhoneNoTextBox.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.uPhoneNoTextBox.CustomButton.Name = "";
            this.uPhoneNoTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uPhoneNoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uPhoneNoTextBox.CustomButton.TabIndex = 1;
            this.uPhoneNoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uPhoneNoTextBox.CustomButton.UseSelectable = true;
            this.uPhoneNoTextBox.CustomButton.Visible = false;
            this.uPhoneNoTextBox.Lines = new string[0];
            this.uPhoneNoTextBox.Location = new System.Drawing.Point(153, 205);
            this.uPhoneNoTextBox.MaxLength = 32767;
            this.uPhoneNoTextBox.Name = "uPhoneNoTextBox";
            this.uPhoneNoTextBox.PasswordChar = '\0';
            this.uPhoneNoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uPhoneNoTextBox.SelectedText = "";
            this.uPhoneNoTextBox.SelectionLength = 0;
            this.uPhoneNoTextBox.SelectionStart = 0;
            this.uPhoneNoTextBox.ShortcutsEnabled = true;
            this.uPhoneNoTextBox.Size = new System.Drawing.Size(180, 23);
            this.uPhoneNoTextBox.TabIndex = 6;
            this.signUpToolTip.SetToolTip(this.uPhoneNoTextBox, "Input your Phone Number here");
            this.uPhoneNoTextBox.UseSelectable = true;
            this.uPhoneNoTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uPhoneNoTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uPhoneNoLabel
            // 
            this.uPhoneNoLabel.AutoSize = true;
            this.uPhoneNoLabel.Location = new System.Drawing.Point(23, 205);
            this.uPhoneNoLabel.Name = "uPhoneNoLabel";
            this.uPhoneNoLabel.Size = new System.Drawing.Size(68, 19);
            this.uPhoneNoLabel.TabIndex = 7;
            this.uPhoneNoLabel.Text = "Phone No";
            this.signUpToolTip.SetToolTip(this.uPhoneNoLabel, "Enter one of your Available Phone numbers.");
            // 
            // doneLink
            // 
            this.doneLink.Image = global::DemoBoxFirst.Properties.Resources.done_01_128;
            this.doneLink.Location = new System.Drawing.Point(276, 396);
            this.doneLink.Name = "doneLink";
            this.doneLink.Size = new System.Drawing.Size(37, 23);
            this.doneLink.TabIndex = 8;
            this.signUpToolTip.SetToolTip(this.doneLink, "Submit");
            this.doneLink.UseSelectable = true;
            this.doneLink.Click += new System.EventHandler(this.doneLink_Click);
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(23, 243);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(83, 19);
            this.dateOfBirthLabel.TabIndex = 10;
            this.dateOfBirthLabel.Text = "Date of Birth";
            this.signUpToolTip.SetToolTip(this.dateOfBirthLabel, "Days/Months/Years");
            // 
            // dateOfBirthTextBox
            // 
            // 
            // 
            // 
            this.dateOfBirthTextBox.CustomButton.Image = null;
            this.dateOfBirthTextBox.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.dateOfBirthTextBox.CustomButton.Name = "";
            this.dateOfBirthTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dateOfBirthTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dateOfBirthTextBox.CustomButton.TabIndex = 1;
            this.dateOfBirthTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dateOfBirthTextBox.CustomButton.UseSelectable = true;
            this.dateOfBirthTextBox.CustomButton.Visible = false;
            this.dateOfBirthTextBox.Lines = new string[0];
            this.dateOfBirthTextBox.Location = new System.Drawing.Point(153, 243);
            this.dateOfBirthTextBox.MaxLength = 32767;
            this.dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            this.dateOfBirthTextBox.PasswordChar = '\0';
            this.dateOfBirthTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dateOfBirthTextBox.SelectedText = "";
            this.dateOfBirthTextBox.SelectionLength = 0;
            this.dateOfBirthTextBox.SelectionStart = 0;
            this.dateOfBirthTextBox.ShortcutsEnabled = true;
            this.dateOfBirthTextBox.Size = new System.Drawing.Size(180, 23);
            this.dateOfBirthTextBox.TabIndex = 11;
            this.signUpToolTip.SetToolTip(this.dateOfBirthTextBox, "Input your Date of Birth");
            this.dateOfBirthTextBox.UseSelectable = true;
            this.dateOfBirthTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dateOfBirthTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(23, 327);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(52, 19);
            this.genderLabel.TabIndex = 13;
            this.genderLabel.Text = "Gender";
            // 
            // maleCheckBox
            // 
            this.maleCheckBox.AutoSize = true;
            this.maleCheckBox.Location = new System.Drawing.Point(153, 334);
            this.maleCheckBox.Name = "maleCheckBox";
            this.maleCheckBox.Size = new System.Drawing.Size(49, 15);
            this.maleCheckBox.TabIndex = 14;
            this.maleCheckBox.Text = "Male";
            this.maleCheckBox.UseSelectable = true;
            // 
            // femaleCheckBox
            // 
            this.femaleCheckBox.AutoSize = true;
            this.femaleCheckBox.Location = new System.Drawing.Point(245, 334);
            this.femaleCheckBox.Name = "femaleCheckBox";
            this.femaleCheckBox.Size = new System.Drawing.Size(61, 15);
            this.femaleCheckBox.TabIndex = 15;
            this.femaleCheckBox.Text = "Female";
            this.femaleCheckBox.UseSelectable = true;
            // 
            // backLink
            // 
            this.backLink.Image = global::DemoBoxFirst.Properties.Resources.circle_back_arrow_glyph_128;
            this.backLink.Location = new System.Drawing.Point(233, 396);
            this.backLink.Name = "backLink";
            this.backLink.Size = new System.Drawing.Size(37, 23);
            this.backLink.TabIndex = 16;
            this.signUpToolTip.SetToolTip(this.backLink, "Go Back");
            this.backLink.UseSelectable = true;
            this.backLink.Click += new System.EventHandler(this.backLink_Click);
            // 
            // signUpToolTip
            // 
            this.signUpToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.signUpToolTip.StyleManager = null;
            this.signUpToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // bloodGroupLabel
            // 
            this.bloodGroupLabel.AutoSize = true;
            this.bloodGroupLabel.Location = new System.Drawing.Point(23, 284);
            this.bloodGroupLabel.Name = "bloodGroupLabel";
            this.bloodGroupLabel.Size = new System.Drawing.Size(85, 19);
            this.bloodGroupLabel.TabIndex = 17;
            this.bloodGroupLabel.Text = "Blood Group";
            // 
            // bloodGroupComboBox
            // 
            this.bloodGroupComboBox.FormattingEnabled = true;
            this.bloodGroupComboBox.ItemHeight = 23;
            this.bloodGroupComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.bloodGroupComboBox.Location = new System.Drawing.Point(153, 284);
            this.bloodGroupComboBox.Name = "bloodGroupComboBox";
            this.bloodGroupComboBox.Size = new System.Drawing.Size(132, 29);
            this.bloodGroupComboBox.TabIndex = 18;
            this.bloodGroupComboBox.UseSelectable = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 447);
            this.Controls.Add(this.bloodGroupComboBox);
            this.Controls.Add(this.bloodGroupLabel);
            this.Controls.Add(this.backLink);
            this.Controls.Add(this.femaleCheckBox);
            this.Controls.Add(this.maleCheckBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.dateOfBirthTextBox);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.doneLink);
            this.Controls.Add(this.uPhoneNoLabel);
            this.Controls.Add(this.uPhoneNoTextBox);
            this.Controls.Add(this.uPasswordTextBox);
            this.Controls.Add(this.uEmailTextBox);
            this.Controls.Add(this.uPasswordLabel);
            this.Controls.Add(this.uEmailLabel);
            this.Controls.Add(this.uNameTextBox);
            this.Controls.Add(this.uNameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUp";
            this.Text = "Enter your Information below.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUp_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUp_FormClosed);
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel uNameLabel;
        private MetroFramework.Controls.MetroTextBox uNameTextBox;
        private MetroFramework.Controls.MetroLabel uEmailLabel;
        private MetroFramework.Controls.MetroLabel uPasswordLabel;
        private MetroFramework.Controls.MetroTextBox uEmailTextBox;
        private MetroFramework.Controls.MetroTextBox uPasswordTextBox;
        private MetroFramework.Controls.MetroTextBox uPhoneNoTextBox;
        private MetroFramework.Controls.MetroLabel uPhoneNoLabel;
        private MetroFramework.Controls.MetroLink doneLink;
        private MetroFramework.Controls.MetroLabel dateOfBirthLabel;
        private MetroFramework.Controls.MetroTextBox dateOfBirthTextBox;
        private MetroFramework.Controls.MetroLabel genderLabel;
        private MetroFramework.Controls.MetroCheckBox maleCheckBox;
        private MetroFramework.Controls.MetroCheckBox femaleCheckBox;
        private MetroFramework.Controls.MetroLink backLink;
        private MetroFramework.Components.MetroToolTip signUpToolTip;
        private MetroFramework.Controls.MetroLabel bloodGroupLabel;
        private MetroFramework.Controls.MetroComboBox bloodGroupComboBox;
    }
}