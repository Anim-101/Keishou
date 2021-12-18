namespace DemoBoxFirst
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
            this.demoBoxPicturePanel = new MetroFramework.Controls.MetroPanel();
            this.demoBoxPictureBox = new System.Windows.Forms.PictureBox();
            this.loginPanelHolderPanel = new MetroFramework.Controls.MetroPanel();
            this.loginInfoPanel = new MetroFramework.Controls.MetroPanel();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.loginDoneButton = new MetroFramework.Controls.MetroButton();
            this.loginWelcomeLabel = new MetroFramework.Controls.MetroLabel();
            this.loginPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.loginEmailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.loginBackLink = new MetroFramework.Controls.MetroLink();
            this.loginpictureBox = new System.Windows.Forms.PictureBox();
            this.logSignHolderPanel = new MetroFramework.Controls.MetroPanel();
            this.logSignPanel = new MetroFramework.Controls.MetroPanel();
            this.signTile = new MetroFramework.Controls.MetroTile();
            this.loginTile = new MetroFramework.Controls.MetroTile();
            this.mainUIToolTip = new MetroFramework.Components.MetroToolTip();
            this.demoBoxPicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demoBoxPictureBox)).BeginInit();
            this.loginPanelHolderPanel.SuspendLayout();
            this.loginInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginpictureBox)).BeginInit();
            this.logSignHolderPanel.SuspendLayout();
            this.logSignPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // demoBoxPicturePanel
            // 
            this.demoBoxPicturePanel.Controls.Add(this.demoBoxPictureBox);
            this.demoBoxPicturePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.demoBoxPicturePanel.HorizontalScrollbarBarColor = true;
            this.demoBoxPicturePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.demoBoxPicturePanel.HorizontalScrollbarSize = 10;
            this.demoBoxPicturePanel.Location = new System.Drawing.Point(20, 60);
            this.demoBoxPicturePanel.Name = "demoBoxPicturePanel";
            this.demoBoxPicturePanel.Size = new System.Drawing.Size(897, 115);
            this.demoBoxPicturePanel.TabIndex = 0;
            this.demoBoxPicturePanel.VerticalScrollbarBarColor = true;
            this.demoBoxPicturePanel.VerticalScrollbarHighlightOnWheel = false;
            this.demoBoxPicturePanel.VerticalScrollbarSize = 10;
            this.demoBoxPicturePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.demoBoxPicturePanel_Paint);
            // 
            // demoBoxPictureBox
            // 
            this.demoBoxPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.demoBoxPictureBox.Image = global::DemoBoxFirst.Properties.Resources.Demo_Box_Starting_Logo;
            this.demoBoxPictureBox.Location = new System.Drawing.Point(294, 3);
            this.demoBoxPictureBox.Name = "demoBoxPictureBox";
            this.demoBoxPictureBox.Size = new System.Drawing.Size(274, 104);
            this.demoBoxPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.demoBoxPictureBox.TabIndex = 2;
            this.demoBoxPictureBox.TabStop = false;
            // 
            // loginPanelHolderPanel
            // 
            this.loginPanelHolderPanel.Controls.Add(this.loginInfoPanel);
            this.loginPanelHolderPanel.HorizontalScrollbarBarColor = true;
            this.loginPanelHolderPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.loginPanelHolderPanel.HorizontalScrollbarSize = 10;
            this.loginPanelHolderPanel.Location = new System.Drawing.Point(20, 175);
            this.loginPanelHolderPanel.Name = "loginPanelHolderPanel";
            this.loginPanelHolderPanel.Size = new System.Drawing.Size(897, 232);
            this.loginPanelHolderPanel.TabIndex = 1;
            this.loginPanelHolderPanel.VerticalScrollbarBarColor = true;
            this.loginPanelHolderPanel.VerticalScrollbarHighlightOnWheel = false;
            this.loginPanelHolderPanel.VerticalScrollbarSize = 10;
            this.loginPanelHolderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanelHolderPanel_Paint);
            // 
            // loginInfoPanel
            // 
            this.loginInfoPanel.Controls.Add(this.passwordLabel);
            this.loginInfoPanel.Controls.Add(this.emailLabel);
            this.loginInfoPanel.Controls.Add(this.loginDoneButton);
            this.loginInfoPanel.Controls.Add(this.loginWelcomeLabel);
            this.loginInfoPanel.Controls.Add(this.loginPasswordTextBox);
            this.loginInfoPanel.Controls.Add(this.loginEmailTextBox);
            this.loginInfoPanel.Controls.Add(this.loginBackLink);
            this.loginInfoPanel.Controls.Add(this.loginpictureBox);
            this.loginInfoPanel.HorizontalScrollbarBarColor = true;
            this.loginInfoPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.loginInfoPanel.HorizontalScrollbarSize = 10;
            this.loginInfoPanel.Location = new System.Drawing.Point(91, 12);
            this.loginInfoPanel.Name = "loginInfoPanel";
            this.loginInfoPanel.Size = new System.Drawing.Size(723, 201);
            this.loginInfoPanel.TabIndex = 2;
            this.loginInfoPanel.VerticalScrollbarBarColor = true;
            this.loginInfoPanel.VerticalScrollbarHighlightOnWheel = false;
            this.loginInfoPanel.VerticalScrollbarSize = 10;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.passwordLabel.Location = new System.Drawing.Point(239, 104);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(67, 19);
            this.passwordLabel.Style = MetroFramework.MetroColorStyle.Silver;
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.emailLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.emailLabel.Location = new System.Drawing.Point(239, 64);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(41, 19);
            this.emailLabel.Style = MetroFramework.MetroColorStyle.Silver;
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Email";
            this.emailLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // loginDoneButton
            // 
            this.loginDoneButton.Location = new System.Drawing.Point(553, 149);
            this.loginDoneButton.Name = "loginDoneButton";
            this.loginDoneButton.Size = new System.Drawing.Size(56, 21);
            this.loginDoneButton.TabIndex = 9;
            this.loginDoneButton.Text = "Done";
            this.mainUIToolTip.SetToolTip(this.loginDoneButton, "Try Login !");
            this.loginDoneButton.UseSelectable = true;
            this.loginDoneButton.Click += new System.EventHandler(this.loginDoneButton_Click);
            // 
            // loginWelcomeLabel
            // 
            this.loginWelcomeLabel.AutoSize = true;
            this.loginWelcomeLabel.Location = new System.Drawing.Point(214, 15);
            this.loginWelcomeLabel.Name = "loginWelcomeLabel";
            this.loginWelcomeLabel.Size = new System.Drawing.Size(411, 19);
            this.loginWelcomeLabel.TabIndex = 8;
            this.loginWelcomeLabel.Text = "Welcome to Demo Box,Please enter your Email and Password below";
            // 
            // loginPasswordTextBox
            // 
            // 
            // 
            // 
            this.loginPasswordTextBox.CustomButton.Image = null;
            this.loginPasswordTextBox.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.loginPasswordTextBox.CustomButton.Name = "";
            this.loginPasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.loginPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginPasswordTextBox.CustomButton.TabIndex = 1;
            this.loginPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginPasswordTextBox.CustomButton.UseSelectable = true;
            this.loginPasswordTextBox.CustomButton.Visible = false;
            this.loginPasswordTextBox.Lines = new string[0];
            this.loginPasswordTextBox.Location = new System.Drawing.Point(347, 104);
            this.loginPasswordTextBox.MaxLength = 32767;
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '\0';
            this.loginPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginPasswordTextBox.SelectedText = "";
            this.loginPasswordTextBox.SelectionLength = 0;
            this.loginPasswordTextBox.SelectionStart = 0;
            this.loginPasswordTextBox.ShortcutsEnabled = true;
            this.loginPasswordTextBox.Size = new System.Drawing.Size(262, 23);
            this.loginPasswordTextBox.TabIndex = 7;
            this.mainUIToolTip.SetToolTip(this.loginPasswordTextBox, "Enter your Password here");
            this.loginPasswordTextBox.UseSelectable = true;
            this.loginPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loginPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // loginEmailTextBox
            // 
            // 
            // 
            // 
            this.loginEmailTextBox.CustomButton.Image = null;
            this.loginEmailTextBox.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.loginEmailTextBox.CustomButton.Name = "";
            this.loginEmailTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.loginEmailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginEmailTextBox.CustomButton.TabIndex = 1;
            this.loginEmailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginEmailTextBox.CustomButton.UseSelectable = true;
            this.loginEmailTextBox.CustomButton.Visible = false;
            this.loginEmailTextBox.Icon = global::DemoBoxFirst.Properties.Resources.boss;
            this.loginEmailTextBox.Lines = new string[0];
            this.loginEmailTextBox.Location = new System.Drawing.Point(347, 64);
            this.loginEmailTextBox.MaxLength = 32767;
            this.loginEmailTextBox.Name = "loginEmailTextBox";
            this.loginEmailTextBox.PasswordChar = '\0';
            this.loginEmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginEmailTextBox.SelectedText = "";
            this.loginEmailTextBox.SelectionLength = 0;
            this.loginEmailTextBox.SelectionStart = 0;
            this.loginEmailTextBox.ShortcutsEnabled = true;
            this.loginEmailTextBox.Size = new System.Drawing.Size(262, 23);
            this.loginEmailTextBox.Style = MetroFramework.MetroColorStyle.Silver;
            this.loginEmailTextBox.TabIndex = 6;
            this.mainUIToolTip.SetToolTip(this.loginEmailTextBox, "Enter your Email address here");
            this.loginEmailTextBox.UseSelectable = true;
            this.loginEmailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loginEmailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.loginEmailTextBox.Click += new System.EventHandler(this.loginEmailTextBox_Click);
            // 
            // loginBackLink
            // 
            this.loginBackLink.Image = global::DemoBoxFirst.Properties.Resources.circle_back_arrow_glyph_128;
            this.loginBackLink.Location = new System.Drawing.Point(20, 15);
            this.loginBackLink.Name = "loginBackLink";
            this.loginBackLink.Size = new System.Drawing.Size(41, 30);
            this.loginBackLink.TabIndex = 3;
            this.mainUIToolTip.SetToolTip(this.loginBackLink, "Go Back");
            this.loginBackLink.UseSelectable = true;
            this.loginBackLink.Click += new System.EventHandler(this.loginBackLink_Click);
            // 
            // loginpictureBox
            // 
            this.loginpictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginpictureBox.Image = global::DemoBoxFirst.Properties.Resources.Human_128;
            this.loginpictureBox.Location = new System.Drawing.Point(80, 25);
            this.loginpictureBox.Name = "loginpictureBox";
            this.loginpictureBox.Size = new System.Drawing.Size(128, 128);
            this.loginpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loginpictureBox.TabIndex = 2;
            this.loginpictureBox.TabStop = false;
            // 
            // logSignHolderPanel
            // 
            this.logSignHolderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logSignHolderPanel.Controls.Add(this.logSignPanel);
            this.logSignHolderPanel.HorizontalScrollbarBarColor = true;
            this.logSignHolderPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.logSignHolderPanel.HorizontalScrollbarSize = 10;
            this.logSignHolderPanel.Location = new System.Drawing.Point(20, 173);
            this.logSignHolderPanel.Name = "logSignHolderPanel";
            this.logSignHolderPanel.Size = new System.Drawing.Size(897, 232);
            this.logSignHolderPanel.TabIndex = 2;
            this.logSignHolderPanel.VerticalScrollbarBarColor = true;
            this.logSignHolderPanel.VerticalScrollbarHighlightOnWheel = false;
            this.logSignHolderPanel.VerticalScrollbarSize = 10;
            this.logSignHolderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.logSignHolderPanel_Paint);
            // 
            // logSignPanel
            // 
            this.logSignPanel.Controls.Add(this.signTile);
            this.logSignPanel.Controls.Add(this.loginTile);
            this.logSignPanel.HorizontalScrollbarBarColor = true;
            this.logSignPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.logSignPanel.HorizontalScrollbarSize = 10;
            this.logSignPanel.Location = new System.Drawing.Point(305, 27);
            this.logSignPanel.Name = "logSignPanel";
            this.logSignPanel.Size = new System.Drawing.Size(241, 155);
            this.logSignPanel.TabIndex = 2;
            this.logSignPanel.VerticalScrollbarBarColor = true;
            this.logSignPanel.VerticalScrollbarHighlightOnWheel = false;
            this.logSignPanel.VerticalScrollbarSize = 10;
            // 
            // signTile
            // 
            this.signTile.ActiveControl = null;
            this.signTile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signTile.Location = new System.Drawing.Point(85, 80);
            this.signTile.Name = "signTile";
            this.signTile.Size = new System.Drawing.Size(77, 34);
            this.signTile.TabIndex = 4;
            this.signTile.Text = "Sign Up";
            this.signTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.signTile.TileImage = global::DemoBoxFirst.Properties.Resources._30___Right_arrow_direction_orientation_24;
            this.signTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.signTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mainUIToolTip.SetToolTip(this.signTile, "Don\'t have an Account ?  Sign Up");
            this.signTile.UseSelectable = true;
            this.signTile.UseTileImage = true;
            this.signTile.Click += new System.EventHandler(this.signTile_Click);
            // 
            // loginTile
            // 
            this.loginTile.ActiveControl = null;
            this.loginTile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTile.Location = new System.Drawing.Point(85, 31);
            this.loginTile.Name = "loginTile";
            this.loginTile.Size = new System.Drawing.Size(77, 39);
            this.loginTile.TabIndex = 3;
            this.loginTile.Text = "Login";
            this.loginTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.loginTile.TileImage = global::DemoBoxFirst.Properties.Resources.User_32;
            this.loginTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.loginTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mainUIToolTip.SetToolTip(this.loginTile, "Login in your Account");
            this.loginTile.UseSelectable = true;
            this.loginTile.UseTileImage = true;
            this.loginTile.Click += new System.EventHandler(this.loginTile_Click);
            // 
            // mainUIToolTip
            // 
            this.mainUIToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.mainUIToolTip.StyleManager = null;
            this.mainUIToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(937, 519);
            this.Controls.Add(this.demoBoxPicturePanel);
            this.Controls.Add(this.loginPanelHolderPanel);
            this.Controls.Add(this.logSignHolderPanel);
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUI_FormClosing);
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.demoBoxPicturePanel.ResumeLayout(false);
            this.demoBoxPicturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demoBoxPictureBox)).EndInit();
            this.loginPanelHolderPanel.ResumeLayout(false);
            this.loginInfoPanel.ResumeLayout(false);
            this.loginInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginpictureBox)).EndInit();
            this.logSignHolderPanel.ResumeLayout(false);
            this.logSignPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel demoBoxPicturePanel;
        private System.Windows.Forms.PictureBox demoBoxPictureBox;
        private MetroFramework.Controls.MetroPanel loginPanelHolderPanel;
        private MetroFramework.Controls.MetroPanel loginInfoPanel;
        private MetroFramework.Controls.MetroButton loginDoneButton;
        private MetroFramework.Controls.MetroLabel loginWelcomeLabel;
        private MetroFramework.Controls.MetroTextBox loginPasswordTextBox;
        private MetroFramework.Controls.MetroTextBox loginEmailTextBox;
        private MetroFramework.Controls.MetroLink loginBackLink;
        private System.Windows.Forms.PictureBox loginpictureBox;
        private MetroFramework.Controls.MetroPanel logSignHolderPanel;
        private MetroFramework.Controls.MetroPanel logSignPanel;
        private MetroFramework.Controls.MetroTile signTile;
        private MetroFramework.Controls.MetroTile loginTile;
        private MetroFramework.Components.MetroToolTip mainUIToolTip;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroLabel emailLabel;
    }
}

