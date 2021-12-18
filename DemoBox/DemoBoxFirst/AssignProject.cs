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

namespace DemoBoxFirst
{
    //Assing Project to Employee 
    public partial class AssignProject : MetroFramework.Forms.MetroForm
    {
        string empIden=null,proIden=null;
        int empId=0,proId=0;
        string search=null,poss=null;
        AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
        

        //Constructor of AssignProject Class
        // // // // // // 
        public AssignProject()
        {
            InitializeComponent();
        }
        // // // // // // 

        
        //Loading Assign Project to search and assign Employee.
        // // // // // //
        private void AssignProject_Load(object sender, EventArgs e)
        {
            string name, time,id;

            //Visibility Switching at the start of the project.Only search Project Panel is shown.
            searchProjectPanel.Visible = true;
            availableEmployeePanel.Visible = false;
            // // //

            //Showing Search History on Project Search TextBox.
            projectNameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            projectNameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            projectNameTextBox.AutoCompleteCustomSource= autoComplete;
            // // //

            try
            {
                using (var context = new DemoBoxDBContext())
                {
                    IEnumerable<Project> query = from x in context.Projects
                                                 select x;
                    foreach (var pr in query)
                    {
                        id = pr.ProjectId.ToString();
                        name = pr.ProjectName;
                        time = pr.ProjectTimeline;

                        ListViewItem lvi1 = new ListViewItem();
                        lvi1.Text = id;
                        lvi1.SubItems.Add(name);
                        lvi1.SubItems.Add("NILL");
                        lvi1.SubItems.Add("NILL");
                        lvi1.SubItems.Add(time);

                        projectListView.Items.Add(lvi1);
                    }
                }
            }
            catch
            {

            }
        }
        // // // // // //



        private void projectNameTextBox_Enter(object sender, EventArgs e)
        {
            
        }



        //Taking Value from ProjectTextBox when Enter is Pressed
        // // // // // //
        private void projectNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                this.search = projectNameTextBox.Text;
                autoComplete.Add(projectNameTextBox.Text);
            }
        }
        // // // // // //

        
        //Clearing List View Window by Closing this Form
        // // // // // //
        private void AssignProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            projectListView.Items.Clear();
            availableEmployeeListView.Items.Clear();
        }

        private void projectListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.proIden = projectListView.SelectedItems[0].SubItems[0].Text;
                this.proId = Convert.ToInt32(proIden);
                proIden = null;
            }
            catch
            {

            }
        }
        // // // // // //

        
        //Showing Available Employee Panel on One click
        private void projectListView_MouseClick(object sender, MouseEventArgs e)
        {
            availableEmployeePanel.Visible = true;
            try
            {
                string name, role, id;
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
                                id = em.EmployeeId.ToString();
                                name = em.EmployeeName;
                                role = "Team Leader";

                                ListViewItem lvi1 = new ListViewItem();
                                lvi1.Text = id;
                                lvi1.SubItems.Add(name);
                                lvi1.SubItems.Add(role);

                                availableEmployeeListView.Items.Add(lvi1);
                            }
                            else if (em.EmployeeRole == 3)
                            {
                                id = em.EmployeeId.ToString();
                                name = em.EmployeeName;
                                role = "Analyst";
                                ListViewItem lvi1 = new ListViewItem();
                                lvi1.Text = id;
                                lvi1.SubItems.Add(name);
                                lvi1.SubItems.Add(role);

                                availableEmployeeListView.Items.Add(lvi1);

                            }
                            else if (em.EmployeeRole == 4)
                            {
                                id = em.EmployeeId.ToString();
                                name = em.EmployeeName;
                                role = "Designer";
                                ListViewItem lvi1 = new ListViewItem();
                                lvi1.Text = id;
                                lvi1.SubItems.Add(name);
                                lvi1.SubItems.Add(role);

                                availableEmployeeListView.Items.Add(lvi1);
                            }
                            else if (em.EmployeeRole == 5)
                            {
                                id = em.EmployeeId.ToString();
                                name = em.EmployeeName;
                                role = "Programmer";
                                ListViewItem lvi1 = new ListViewItem();
                                lvi1.Text = id;
                                lvi1.SubItems.Add(name);
                                lvi1.SubItems.Add(role);

                                availableEmployeeListView.Items.Add(lvi1);
                            }
                            else if (em.EmployeeRole == 6)
                            {
                                id = em.EmployeeId.ToString();
                                name = em.EmployeeName;
                                role = "Tester";
                                ListViewItem lvi1 = new ListViewItem();
                                lvi1.Text = id;
                                lvi1.SubItems.Add(name);
                                lvi1.SubItems.Add(role);

                                availableEmployeeListView.Items.Add(lvi1);
                            }
                        }
                    }

                }
            }
            catch
            {

            }
        }
        // // // // // //


        //Hiding Available Employee panel on Double click
        // // // // // //
        private void projectListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            availableEmployeePanel.Visible = false;
        }
        // // // // // //


        
        //Assigning Project to an Employee
        // // // // // //
        private void assignButton_Click(object sender, EventArgs e)
        {
            if (empId !=0 && proId !=0 && poss != null)
            {
                try
                {
                    var projectEmployee = new ProjectEmployee();

                    projectEmployee.EmployeeId = empId;
                    projectEmployee.ProjectId = proId;

                    using (var context = new DemoBoxDBContext())
                    {
                        context.ProjectEmployees.Add(projectEmployee);
                        context.SaveChanges();
                    }

                    using (var context = new DemoBoxDBContext())
                    {
                        var query = from x in context.Employees
                                    where x.EmployeeId == empId
                                    select x;
                        foreach (var em in query)
                        {
                            if (poss == "Team Leader")
                            {
                                em.EmployeeProjectRole = 2;
                                em.EmployeeStatus = "Working";
                            }
                            else if (poss == "Analyst")
                            {
                                em.EmployeeProjectRole = 3;
                                em.EmployeeStatus = "Working";
                            }
                            else if (poss == "Designer")
                            {
                                em.EmployeeProjectRole = 4;
                                em.EmployeeStatus = "Working";
                            }
                            else if (poss == "Programmer")
                            {
                                em.EmployeeProjectRole = 5;
                                em.EmployeeStatus = "Working";
                            }
                            else if (poss == "Tester")
                            {
                                em.EmployeeProjectRole = 6;
                                em.EmployeeStatus = "Working";
                            }
                        }

                        try
                        {
                            context.SaveChanges();
                        }
                        catch
                        {

                        }
                    }
                }
                catch
                {

                }
            }
        }
        // // // // // //

        
        // Taking value from Possition Combo Box
        // // // // // // //
        private void possitionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.poss = possitionComboBox.SelectedItem.ToString();
        }

        // // // // // //


        private void availableEmployeePanel_Paint(object sender, PaintEventArgs e)
        {

        }



        //AvailableEmployeeListView to Show Available Employee to Assing Selected Project
        // // // // // //
        private void availableEmployeeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.empIden = availableEmployeeListView.SelectedItems[0].SubItems[0].Text;
                this.empId = Convert.ToInt32(empIden);
                empIden = null;
            }
            catch
            {

            }
        }
        // // // // // //
    }
}
