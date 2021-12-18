namespace DemoBoxFirst
{
    partial class EmailSender
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
            this.toLabel = new MetroFramework.Controls.MetroLabel();
            this.ccLabel = new MetroFramework.Controls.MetroLabel();
            this.subjectLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.toTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ccTextBox = new MetroFramework.Controls.MetroTextBox();
            this.subjectTextBox = new MetroFramework.Controls.MetroTextBox();
            this.messageTextBox = new MetroFramework.Controls.MetroTextBox();
            this.attachmentTextBox = new MetroFramework.Controls.MetroTextBox();
            this.attachmentLabel = new MetroFramework.Controls.MetroLabel();
            this.attachmentButton = new MetroFramework.Controls.MetroButton();
            this.fromLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.fromTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.sendButton = new MetroFramework.Controls.MetroButton();
            this.emailSenderToolTip = new MetroFramework.Components.MetroToolTip();
            this.SuspendLayout();
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(11, 26);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(24, 19);
            this.toLabel.TabIndex = 0;
            this.toLabel.Text = "To";
            // 
            // ccLabel
            // 
            this.ccLabel.AutoSize = true;
            this.ccLabel.Location = new System.Drawing.Point(11, 69);
            this.ccLabel.Name = "ccLabel";
            this.ccLabel.Size = new System.Drawing.Size(27, 19);
            this.ccLabel.TabIndex = 1;
            this.ccLabel.Text = "CC";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(11, 112);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(51, 19);
            this.subjectLabel.TabIndex = 2;
            this.subjectLabel.Text = "Subject";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 155);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Message";
            // 
            // toTextBox
            // 
            // 
            // 
            // 
            this.toTextBox.CustomButton.Image = null;
            this.toTextBox.CustomButton.Location = new System.Drawing.Point(370, 1);
            this.toTextBox.CustomButton.Name = "";
            this.toTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.toTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.toTextBox.CustomButton.TabIndex = 1;
            this.toTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toTextBox.CustomButton.UseSelectable = true;
            this.toTextBox.CustomButton.Visible = false;
            this.toTextBox.Lines = new string[0];
            this.toTextBox.Location = new System.Drawing.Point(102, 26);
            this.toTextBox.MaxLength = 32767;
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.PasswordChar = '\0';
            this.toTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.toTextBox.SelectedText = "";
            this.toTextBox.SelectionLength = 0;
            this.toTextBox.SelectionStart = 0;
            this.toTextBox.ShortcutsEnabled = true;
            this.toTextBox.Size = new System.Drawing.Size(392, 23);
            this.toTextBox.TabIndex = 4;
            this.toTextBox.UseSelectable = true;
            this.toTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.toTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ccTextBox
            // 
            // 
            // 
            // 
            this.ccTextBox.CustomButton.Image = null;
            this.ccTextBox.CustomButton.Location = new System.Drawing.Point(370, 1);
            this.ccTextBox.CustomButton.Name = "";
            this.ccTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ccTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ccTextBox.CustomButton.TabIndex = 1;
            this.ccTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ccTextBox.CustomButton.UseSelectable = true;
            this.ccTextBox.CustomButton.Visible = false;
            this.ccTextBox.Lines = new string[0];
            this.ccTextBox.Location = new System.Drawing.Point(102, 68);
            this.ccTextBox.MaxLength = 32767;
            this.ccTextBox.Name = "ccTextBox";
            this.ccTextBox.PasswordChar = '\0';
            this.ccTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ccTextBox.SelectedText = "";
            this.ccTextBox.SelectionLength = 0;
            this.ccTextBox.SelectionStart = 0;
            this.ccTextBox.ShortcutsEnabled = true;
            this.ccTextBox.Size = new System.Drawing.Size(392, 23);
            this.ccTextBox.TabIndex = 5;
            this.ccTextBox.UseSelectable = true;
            this.ccTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ccTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // subjectTextBox
            // 
            // 
            // 
            // 
            this.subjectTextBox.CustomButton.Image = null;
            this.subjectTextBox.CustomButton.Location = new System.Drawing.Point(370, 1);
            this.subjectTextBox.CustomButton.Name = "";
            this.subjectTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.subjectTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.subjectTextBox.CustomButton.TabIndex = 1;
            this.subjectTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.subjectTextBox.CustomButton.UseSelectable = true;
            this.subjectTextBox.CustomButton.Visible = false;
            this.subjectTextBox.Lines = new string[0];
            this.subjectTextBox.Location = new System.Drawing.Point(102, 110);
            this.subjectTextBox.MaxLength = 32767;
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.PasswordChar = '\0';
            this.subjectTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subjectTextBox.SelectedText = "";
            this.subjectTextBox.SelectionLength = 0;
            this.subjectTextBox.SelectionStart = 0;
            this.subjectTextBox.ShortcutsEnabled = true;
            this.subjectTextBox.Size = new System.Drawing.Size(392, 23);
            this.subjectTextBox.TabIndex = 6;
            this.emailSenderToolTip.SetToolTip(this.subjectTextBox, "Give an Appropriate Subject for this Email Conversation.");
            this.subjectTextBox.UseSelectable = true;
            this.subjectTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.subjectTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // messageTextBox
            // 
            // 
            // 
            // 
            this.messageTextBox.CustomButton.Image = null;
            this.messageTextBox.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.messageTextBox.CustomButton.Name = "";
            this.messageTextBox.CustomButton.Size = new System.Drawing.Size(195, 195);
            this.messageTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.messageTextBox.CustomButton.TabIndex = 1;
            this.messageTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.messageTextBox.CustomButton.UseSelectable = true;
            this.messageTextBox.CustomButton.Visible = false;
            this.messageTextBox.Lines = new string[0];
            this.messageTextBox.Location = new System.Drawing.Point(102, 148);
            this.messageTextBox.MaxLength = 32767;
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.PasswordChar = '\0';
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.messageTextBox.SelectedText = "";
            this.messageTextBox.SelectionLength = 0;
            this.messageTextBox.SelectionStart = 0;
            this.messageTextBox.ShortcutsEnabled = true;
            this.messageTextBox.Size = new System.Drawing.Size(392, 197);
            this.messageTextBox.TabIndex = 7;
            this.messageTextBox.UseSelectable = true;
            this.messageTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.messageTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // attachmentTextBox
            // 
            // 
            // 
            // 
            this.attachmentTextBox.CustomButton.Image = null;
            this.attachmentTextBox.CustomButton.Location = new System.Drawing.Point(370, 1);
            this.attachmentTextBox.CustomButton.Name = "";
            this.attachmentTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.attachmentTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.attachmentTextBox.CustomButton.TabIndex = 1;
            this.attachmentTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.attachmentTextBox.CustomButton.UseSelectable = true;
            this.attachmentTextBox.CustomButton.Visible = false;
            this.attachmentTextBox.Lines = new string[0];
            this.attachmentTextBox.Location = new System.Drawing.Point(102, 374);
            this.attachmentTextBox.MaxLength = 32767;
            this.attachmentTextBox.Name = "attachmentTextBox";
            this.attachmentTextBox.PasswordChar = '\0';
            this.attachmentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.attachmentTextBox.SelectedText = "";
            this.attachmentTextBox.SelectionLength = 0;
            this.attachmentTextBox.SelectionStart = 0;
            this.attachmentTextBox.ShortcutsEnabled = true;
            this.attachmentTextBox.Size = new System.Drawing.Size(392, 23);
            this.attachmentTextBox.TabIndex = 8;
            this.emailSenderToolTip.SetToolTip(this.attachmentTextBox, "Don\'t Attach .exe/.bin/.com file.");
            this.attachmentTextBox.UseSelectable = true;
            this.attachmentTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.attachmentTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // attachmentLabel
            // 
            this.attachmentLabel.AutoSize = true;
            this.attachmentLabel.Location = new System.Drawing.Point(11, 374);
            this.attachmentLabel.Name = "attachmentLabel";
            this.attachmentLabel.Size = new System.Drawing.Size(76, 19);
            this.attachmentLabel.TabIndex = 9;
            this.attachmentLabel.Text = "Attachment";
            // 
            // attachmentButton
            // 
            this.attachmentButton.Location = new System.Drawing.Point(419, 412);
            this.attachmentButton.Name = "attachmentButton";
            this.attachmentButton.Size = new System.Drawing.Size(75, 23);
            this.attachmentButton.TabIndex = 10;
            this.attachmentButton.Text = "Attach";
            this.emailSenderToolTip.SetToolTip(this.attachmentButton, "Browse file from your Device");
            this.attachmentButton.UseSelectable = true;
            this.attachmentButton.Click += new System.EventHandler(this.attachmentButton_Click);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(11, 437);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(41, 19);
            this.fromLabel.TabIndex = 11;
            this.fromLabel.Text = "From";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(11, 470);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(64, 19);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password";
            // 
            // fromTextBox
            // 
            // 
            // 
            // 
            this.fromTextBox.CustomButton.Image = null;
            this.fromTextBox.CustomButton.Location = new System.Drawing.Point(247, 1);
            this.fromTextBox.CustomButton.Name = "";
            this.fromTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fromTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fromTextBox.CustomButton.TabIndex = 1;
            this.fromTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fromTextBox.CustomButton.UseSelectable = true;
            this.fromTextBox.CustomButton.Visible = false;
            this.fromTextBox.Lines = new string[0];
            this.fromTextBox.Location = new System.Drawing.Point(102, 437);
            this.fromTextBox.MaxLength = 32767;
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.PasswordChar = '\0';
            this.fromTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fromTextBox.SelectedText = "";
            this.fromTextBox.SelectionLength = 0;
            this.fromTextBox.SelectionStart = 0;
            this.fromTextBox.ShortcutsEnabled = true;
            this.fromTextBox.Size = new System.Drawing.Size(269, 23);
            this.fromTextBox.TabIndex = 13;
            this.emailSenderToolTip.SetToolTip(this.fromTextBox, "Enter your Email");
            this.fromTextBox.UseSelectable = true;
            this.fromTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fromTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordTextBox
            // 
            // 
            // 
            // 
            this.passwordTextBox.CustomButton.Image = null;
            this.passwordTextBox.CustomButton.Location = new System.Drawing.Point(247, 1);
            this.passwordTextBox.CustomButton.Name = "";
            this.passwordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox.CustomButton.TabIndex = 1;
            this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox.CustomButton.UseSelectable = true;
            this.passwordTextBox.CustomButton.Visible = false;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(102, 470);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(269, 23);
            this.passwordTextBox.TabIndex = 14;
            this.emailSenderToolTip.SetToolTip(this.passwordTextBox, "Enter password for this Email address");
            this.passwordTextBox.UseSelectable = true;
            this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(419, 494);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 15;
            this.sendButton.Text = "Send";
            this.emailSenderToolTip.SetToolTip(this.sendButton, "Send !");
            this.sendButton.UseSelectable = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // emailSenderToolTip
            // 
            this.emailSenderToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailSenderToolTip.StyleManager = null;
            this.emailSenderToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // EmailSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 540);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.attachmentButton);
            this.Controls.Add(this.attachmentLabel);
            this.Controls.Add(this.attachmentTextBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.ccTextBox);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.ccLabel);
            this.Controls.Add(this.toLabel);
            this.MaximizeBox = false;
            this.Name = "EmailSender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel toLabel;
        private MetroFramework.Controls.MetroLabel ccLabel;
        private MetroFramework.Controls.MetroLabel subjectLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox toTextBox;
        private MetroFramework.Controls.MetroTextBox ccTextBox;
        private MetroFramework.Controls.MetroTextBox subjectTextBox;
        private MetroFramework.Controls.MetroTextBox messageTextBox;
        private MetroFramework.Controls.MetroTextBox attachmentTextBox;
        private MetroFramework.Controls.MetroLabel attachmentLabel;
        private MetroFramework.Controls.MetroButton attachmentButton;
        private MetroFramework.Controls.MetroLabel fromLabel;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroTextBox fromTextBox;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroButton sendButton;
        private MetroFramework.Components.MetroToolTip emailSenderToolTip;
    }
}