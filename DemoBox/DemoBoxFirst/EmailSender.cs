using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;


namespace DemoBoxFirst
{
    public partial class EmailSender : MetroFramework.Forms.MetroForm
    {
        public EmailSender()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                string gmailId = fromTextBox.Text;
                string gmailPassword = passwordTextBox.Text;
                client.Credentials = new NetworkCredential(gmailId, gmailPassword);
                MailMessage msg = new MailMessage();
                string toGmailId = toTextBox.Text;
                msg.To.Add(toGmailId);
                msg.From = new MailAddress(gmailId);
                msg.Subject = subjectTextBox.Text;
                msg.Body = messageTextBox.Text;
                Attachment data = new Attachment(attachmentTextBox.Text);
                msg.Attachments.Add(data);
                client.Send(msg);
                MessageBox.Show("Successfully Sent Message");



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void attachmentButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog()==DialogResult.OK)
            {
                attachmentTextBox.Text = dlg.FileName.ToString();
            }
        }
    }
}
