using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using DemoBoxSecond;
using DemoBoxThrid;
//ProjectManager UI Form and it's Application 
namespace DemoBoxFirst
{
    public partial class ProjectManagerUI : MetroFramework.Forms.MetroForm
    {
        MainUI m = new MainUI();
        string email;
        int i = 0;
        public ProjectManagerUI()
        {
            InitializeComponent();
        }

        //Loading ProjectManagerUI with Email Address
        public ProjectManagerUI(string email)
        {
            InitializeComponent();
            this.email = email;
        }
        // // // // // // 


        //Project Manager Form Loading
        // // // // // //
        private void ProjectManagerUI_Load(object sender, EventArgs e)
        {
            //Employee Information Panels Visibility Off
            currentEIPanel.Visible = false;
            onLeaveEIPanel.Visible = false;
            availableEIPanel.Visible = false;

            //Completed/Pending Project Panels Visibility Off
            pendingProjectPanel.Visible = false;
            completedProjectPanel.Visible = false;

            //Loading Project Manager's Name in ProjectManagerLaber from Database
            try
            {
                using (var context = new DemoBoxDBContext())
                {
                    var query = from x in context.Employees
                                where x.EmployeeEmail == email
                                select x.EmployeeName;

                    foreach (var em in query)
                    {
                        projectManagerNameLabel.Text = "" + em;
                    }
                }
            }
            catch
            {

            }
        }
        // // // // // //


        //Current Employee Checking Button & Setting Visibilitiy
        // // // // // //
        private void currentEIButton_Click(object sender, EventArgs e)
        {
            //View On or Off
            if (i == 0)
            {
                currentEIPanel.Visible = true;
                onLeaveEIPanel.Visible = false;
                availableEIPanel.Visible = false;
                i = 1;
                //Showing list on data throug Crruent List view
                try
                {
                    string name, role;
                    using (var context = new DemoBoxDBContext())
                    {

                        IEnumerable<Employee> Emp = from x in context.Employees
                                                    select x;

                        foreach (var em in Emp)
                        {
                            if (em.EmployeeStatus != "On Leave" || em.EmployeeStatus != "Left")
                            {
                                if (em.EmployeeRole == 2)
                                {
                                    name = em.EmployeeName;
                                    role = "Team Leader";

                                    ListViewItem lvi1 = new ListViewItem();
                                    lvi1.Text = name;
                                    lvi1.SubItems.Add(role);

                                    currentEIListView.Items.Add(lvi1);
                                }
                                else if (em.EmployeeRole == 3)
                                {
                                    name = em.EmployeeName;
                                    role = "Analyst";
                                    ListViewItem lvi1 = new ListViewItem();
                                    lvi1.Text = name;
                                    lvi1.SubItems.Add(role);

                                    currentEIListView.Items.Add(lvi1);
                                }
                                else if (em.EmployeeRole == 4)
                                {
                                    name = em.EmployeeName;
                                    role = "Designer";
                                    ListViewItem lvi1 = new ListViewItem();
                                    lvi1.Text = name;
                                    lvi1.SubItems.Add(role);

                                    currentEIListView.Items.Add(lvi1);
                                }
                                else if (em.EmployeeRole == 5)
                                {
                                    name = em.EmployeeName;
                                    role = "Programmer";
                                    ListViewItem lvi1 = new ListViewItem();
                                    lvi1.Text = name;
                                    lvi1.SubItems.Add(role);

                                    currentEIListView.Items.Add(lvi1);
                                }
                                else if (em.EmployeeRole == 6)
                                {
                                    name = em.EmployeeName;
                                    role = "Tester";
                                    ListViewItem lvi1 = new ListViewItem();
                                    lvi1.Text = name;
                                    lvi1.SubItems.Add(role);

                                    currentEIListView.Items.Add(lvi1);
                                }
                            }
                        }

                    }
                }
                catch
                {

                }



            }
            else
            {
                currentEIPanel.Visible = false;
                onLeaveEIPanel.Visible = false;
                availableEIPanel.Visible = false;
                i = 0;
                currentEIListView.Items.Clear();
            }

            /*EmployeeData ed = new EmployeeData();
            List<Employee> Employees =  ed.GetEmployee();

            foreach ()
            {
                
            }
            */
        }
        // // // // // //

        
        //Closing Project Manager Form
        // // // // // //
        private void ProjectManagerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            m.ShowDialog();
            this.Close();
        }
        // // // // // //


        //On Leave Employee Checking Button & Setting Visibility
        // // // // // //
        private void onLeaveEIButton_Click(object sender, EventArgs e)
        {
            //Setting Panel On or Off According to Button Click
            if (i == 0)

            {
                currentEIPanel.Visible = false;
                onLeaveEIPanel.Visible = true;
                availableEIPanel.Visible = false;
                i = 1;

                try
                {
                    string name, role;
                    using (var context = new DemoBoxDBContext())
                    {

                        IEnumerable<Employee> Emp = from x in context.Employees
                                                    select x;

                        foreach (var em in Emp)
                        {
                            if(em.EmployeeStatus== "On Leave")
                            {

                                if (em.EmployeeRole == 2)
                                {
                                    name = em.EmployeeName;
                                    role = "Team Leader";

                                    ListViewItem lvi1 = new ListViewItem();
                                    lvi1.Text = name;
                                    lvi1.SubItems.Add(role);

                                    onLeaveEIListView.Items.Add(lvi1);
                                }
                                else if (em.EmployeeRole == 3)
                                {
                                    name = em.EmployeeName;
                                    role = "Analyst";
                                    ListViewItem lvi1 = new ListViewItem();
                                    lvi1.Text = name;
                                    lvi1.SubItems.Add(role);

                                    onLeaveEIListView.Items.Add(lvi1);

                                }
                                else if (em.EmployeeRole == 4)
                                {
                                    name = em.EmployeeName;
                                    role = "Designer";
                                    ListViewItem lvi1 = new ListViewItem();
                                    lvi1.Text = name;
                                    lvi1.SubItems.Add(role);

                                    onLeaveEIListView.Items.Add(lvi1);
                                }
                                else if (em.EmployeeRole == 5)
                                {
                                    name = em.EmployeeName;
                                    role = "Programmer";
                                    ListViewItem lvi1 = new ListViewItem();
                                    lvi1.Text = name;
                                    lvi1.SubItems.Add(role);

                                    onLeaveEIListView.Items.Add(lvi1);
                                }
                                else if (em.EmployeeRole == 6)
                                {
                                    name = em.EmployeeName;
                                    role = "Tester";
                                    ListViewItem lvi1 = new ListViewItem();
                                    lvi1.Text = name;
                                    lvi1.SubItems.Add(role);

                                    onLeaveEIListView.Items.Add(lvi1);
                                }
                            }
                        }

                    }
                }
                catch
                {

                }
            }
            else
            {
                onLeaveEIListView.Items.Clear();
                currentEIPanel.Visible = false;
                onLeaveEIPanel.Visible = false;
                availableEIPanel.Visible = false;
                i = 0;

            }

            // // //

           
        }
        // // // // // //


        //Available Employee Checking Button & Setting Visibility
        // // // // // //
        private void availableEIButton_Click(object sender, EventArgs e)
        {
            if (i == 0)

            {
                currentEIPanel.Visible = false;
                onLeaveEIPanel.Visible = false;
                availableEIPanel.Visible = true;
                i = 1;

                try
                {
                    string name, role;
                    using (var context = new DemoBoxDBContext())
                    {

                        IEnumerable<Employee> Emp = from x in context.Employees
                                                    select x;

                        foreach (var em in Emp)
                        {
                            if (em.EmployeeStatus != "On Leave" && em.EmployeeStatus != "Working" && em.EmployeeStatus != "Left")
                            {

                                if (em.EmployeeRole == 2)
                                {
                                    name = em.EmployeeName;
                                    role = "Team Leader";

                                    ListViewItem lvi1 = new ListViewItem();
                                    lvi1.Text = name;
                                    lvi1.SubItems.Add(role);

                                    avaiableEIListView.Items.Add(lvi1);
                                }
                                else if (em.EmployeeRole == 3)
                                {
                                    name = em.EmployeeName;
                                    role = "Analyst";
                                    ListViewItem lvi1 = new ListViewItem();
                                    lvi1.Text = name;
                                    lvi1.SubItems.Add(role);

                                    avaiableEIListView.Items.Add(lvi1);

                                }
                                else if (em.EmployeeRole == 4)
                                {
                                    name = em.EmployeeName;
                                    role = "Designer";
                                    ListViewItem lvi1 = new ListViewItem();
                                    lvi1.Text = name;
                                    lvi1.SubItems.Add(role);

                                    avaiableEIListView.Items.Add(lvi1);
                                }
                                else if (em.EmployeeRole == 5)
                                {
                                    name = em.EmployeeName;
                                    role = "Programmer";
                                    ListViewItem lvi1 = new ListViewItem();
                                    lvi1.Text = name;
                                    lvi1.SubItems.Add(role);

                                    avaiableEIListView.Items.Add(lvi1);
                                }
                                else if (em.EmployeeRole == 6)
                                {
                                    name = em.EmployeeName;
                                    role = "Tester";
                                    ListViewItem lvi1 = new ListViewItem();
                                    lvi1.Text = name;
                                    lvi1.SubItems.Add(role);

                                    avaiableEIListView.Items.Add(lvi1);
                                }
                            }
                        }

                    }
                }
                catch
                {

                }

            }
            else
            {
                currentEIPanel.Visible = false;
                onLeaveEIPanel.Visible = false;
                availableEIPanel.Visible = false;
                avaiableEIListView.Items.Clear();
                i = 0;

            }

        }
        // // // // // //


        //Loading Project Entry by Clicking Project Entry Button
        // // // // // //
        private void projectEntryButton_Click(object sender, EventArgs e)
        {
            ProjectEntry pe = new ProjectEntry();
            pe.ShowDialog();
        }
        // // // // // //


        //Loging out Project Manager
        // // // // // //
        private void projectManagerlogutLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            m.ShowDialog();
            this.Close();
           
        }
        // // // // // //


        //Pending Project Panel Visibility On or Off and Checking
        // // // // // //
        private void pendingProjectButton_Click(object sender, EventArgs e)
        {
            if (i==0)
            {
                pendingProjectPanel.Visible = true;
                i = 1;
            }
            else
            {
                pendingProjectPanel.Visible = false;
                i = 0;
            }
        }
        // // // // // //


        //Completed Project Button Checking and Visibility
        // // // // // //
        private void completedProjectButton_Click(object sender, EventArgs e)
        {
            if (i==0)
            {
                
                completedProjectPanel.Visible = true;
                i = 1;
            }
            else
            {
                completedProjectPanel.Visible = false;
                i = 0;
            }
            
        }
        // // // // // //


        //Back To Main Login Ui
        // // // // // //
        private void projectManagerlogutLink_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            m.ShowDialog();
            this.Close();
        }
        // // // // // //


        //AssignProjectUi Open by Clicking AssignProjectButton
        // // // // // //
        private void assignProjectButton_Click(object sender, EventArgs e)
        {
            AssignProject ap = new AssignProject();
            ap.ShowDialog();
        }
        // // // // // //


        //SendEmailButtonClick by Clicking SendEmaimButton
        // // // // // //
        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            EmailSender em = new EmailSender();
            em.ShowDialog();
        }
        // // // // // //


        //ProjectHubUi Open by cliking Hub button
        // // // // // //
        private void projectHubButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectHub ph = new ProjectHub(email);
            ph.ShowDialog();
            this.Close();
        }
        // // // // // //


        //Pending Request from New or Old Employees
        // // // // // //
        private void employeePendingButton_Click(object sender, EventArgs e)
        {
            Pending pen = new Pending();
            pen.Show();
        }
        // // // // // //

    }
}
