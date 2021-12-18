using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoBoxSecond;
using DemoBoxThrid;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

//MainUi for Demo Box Application
namespace DemoBoxFirst
{
    public partial class MainUI : MetroFramework.Forms.MetroForm
    {
  
        public MainUI()
        {
            InitializeComponent();         
         }

        private void loginInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        //Loading Main Panel
        // // // // // // 
        private void MainUI_Load(object sender, EventArgs e)
        {
            logSignHolderPanel.BringToFront();
            loginPanelHolderPanel.SendToBack();
        }
        // // // // // //

        private void loginButton_Click(object sender, EventArgs e)
        {
           

        }

        private void logSignPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        //Login or Sign Up Titile Click
        // // // // // // //
        private void loginTile_Click(object sender, EventArgs e)
        {
            loginPanelHolderPanel.BringToFront();
            logSignHolderPanel.SendToBack();
        }
        // // // // // // //

        private void logSignHolderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginPanelHolderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //Back to Main Form Link
        // // // // // // //
        private void loginBackLink_Click(object sender, EventArgs e)
        {
            loginPanelHolderPanel.SendToBack();
            logSignHolderPanel.BringToFront();
        }
        // // // // // // // 


        //Poping up Sing up Form and Hiding Main Form
        // // // // // // //
        private void signTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp s = new SignUp();
            s.ShowDialog();
            //this.Close();
        }
        // // // // // // //


        //Exiting Main UI by clicking x
        // // // // // // //
        private void MainUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch { }
        }
        // // // // // // //


        //Login Completed
        // // // // // // //
        private void loginDoneButton_Click(object sender, EventArgs e)
        {
            if (loginEmailTextBox.Text == null || loginPasswordTextBox.Text ==null)
            {
                MessageBox.Show("Enter your Email and Password!!");
            }

            try
            {
                string email = loginEmailTextBox.Text;
                string pass = loginPasswordTextBox.Text;
                using (var context = new DemoBoxDBContext())
                {
                    var query = from x in context.Employees
                                                 where x.EmployeeEmail == email && x.EmployeePassword == pass
                                                 select x.EmployeeRole;


                    foreach (var s in query)
                    {

                        if(s==1)
                        {
                            this.Hide();
                            ProjectManagerUI pm = new ProjectManagerUI(email);
                            pm.ShowDialog();
                            this.Close();
                        }
                        else if (s ==2)
                        {
                            this.Hide();
                            EmployeeManagement em = new EmployeeManagement(email,s);
                            em.ShowDialog();
                            this.Close();
                        }
                        else if (s == 3)
                        {
                            this.Hide();
                            EmployeeManagement em = new EmployeeManagement(email, s);
                            em.ShowDialog();
                           this.Close();
                        }
                        else if (s == 4)
                        {
                            this.Hide();
                            EmployeeManagement em = new EmployeeManagement(email, s);
                            em.ShowDialog();
                            this.Close();
                        }
                        else if (s == 5)
                        {
                            this.Hide();
                            EmployeeManagement em = new EmployeeManagement(email, s);
                            em.ShowDialog();
                            this.Close();
                        }
                        else if (s == 6)
                        {
                            this.Hide();
                            EmployeeManagement em = new EmployeeManagement(email, s);
                            em.ShowDialog();
                            this.Close();
                        }

                        else if (s==0)
                        {
                            MetroFramework.MetroMessageBox.Show(this,"Your Account Hasn't Confirmed Yet");
                        }
                    

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        // // // // // // //

        private void demoBoxPicturePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void loginEmailTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
