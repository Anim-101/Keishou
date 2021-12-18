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
    //Project Hub to Show Informations about Projects and Files and Employee's Commit Number
    public partial class ProjectHub : MetroFramework.Forms.MetroForm
    {
        string email,proName;
        int proId;
        string name, empName;
        int id, role;
        AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
        public ProjectHub(string email)
        {
            InitializeComponent();
            this.email=email;

        }

        private void ProjectHub_Load(object sender, EventArgs e)
        {
            //Showing Search History on Project Search TextBox.
            projectNameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            projectNameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            projectNameTextBox.AutoCompleteCustomSource = autoComplete;
            // // //
        }

        private void projectDetailsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProjectHub_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                using (var context = new DemoBoxDBContext())
                {
                    var query = from x in context.Employees
                                where x.EmployeeEmail == email
                                select x.EmployeeRole;


                    foreach (var s in query)
                    {

                        if (s == 1)
                        {
                            this.Hide();
                            ProjectManagerUI pm = new ProjectManagerUI(email);
                            pm.ShowDialog();
                            this.Close();
                        }
                        else if (s ==2)
                        {
                            this.Hide();
                            EmployeeManagement em = new EmployeeManagement(email, s);
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
                    }
                }
            }
            catch
            {

            }

        }

        private void ProjectHub_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        // // // // // // 


        //Go Back to Parent Form
        // // // // // //
        private void goBackLink_Click(object sender, EventArgs e)
        {
            try
            {               
                using (var context = new DemoBoxDBContext())
                {
                    var query = from x in context.Employees
                                where x.EmployeeEmail == email
                                select x.EmployeeRole;


                    foreach (var s in query)
                    {

                        if (s == 1)
                        {
                            this.Hide();
                            ProjectManagerUI pm = new ProjectManagerUI(email);
                            pm.ShowDialog();
                            this.Close();
                        }
                        else if (s > 1)
                        {
                            this.Hide();
                            EmployeeManagement em = new EmployeeManagement(email, s);
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
                    }
                }
                
            }
            catch
            {
               
            }
        }

        private void projectNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            int n = 0;

            if (e.KeyCode == Keys.Enter)
            {
               
                this.proName = projectNameTextBox.Text;
                autoComplete.Add(projectNameTextBox.Text);

                if (n == 0)
                {

                    try
                    {

                        using (var context = new DemoBoxDBContext())
                        {
                            var query = from x in context.Projects
                                        where x.ProjectName == proName
                                        select x;
                            foreach (var em in query)
                            {
                                this.proId = em.ProjectId;
                            }

                        }

                        using (var context = new DemoBoxDBContext())
                        {
                            IEnumerable<File> query = from x in context.Files
                                                      join c in context.Projects on x.ProjectId equals c.ProjectId
                                                      //select new { FileName = x.FileName, x.EmployeeId };
                                                      select x;
                            foreach (var em in query)
                            {
                                this.name = em.FileName;
                                this.id = em.EmployeeId;
                                using (var newContext = new DemoBoxDBContext())
                                {
                                    var newQuery = from y in newContext.Employees
                                                   where y.EmployeeId == id
                                                   select y;
                                    foreach (var es in newQuery)
                                    {
                                        this.empName = es.EmployeeName;
                                        this.role = es.EmployeeRole;
                                    }

                                }

                                ListViewItem lvi1 = new ListViewItem();
                                lvi1.Text = name;
                                lvi1.SubItems.Add(empName);
                                lvi1.SubItems.Add("" + role);
                                projectDetailsListView.Items.Add(lvi1);
                            }
                        }

                        using (var context = new DemoBoxDBContext())
                        {
                            var query = from x in context.Projects
                                        where x.ProjectId == proId
                                        select x;
                            foreach (var em in query)
                            {
                                showStatusLabel.Text = em.ProjectStatus;
                                deliveryDateShowLabel.Text = em.DeliveryDate;
                                clientShowLabel.Text = em.ClientName;
                                DateTime dt1 = Convert.ToDateTime(em.DeliveryDate);
                                DateTime dt2 = DateTime.Today;
                                TimeSpan time = dt1.Subtract(dt2);
                                int t = (int)time.TotalDays;
                                timeRemainingShowLabel.Text = "" + t + " Days";
                            }

                        }
                    }
                    catch
                    {
                        MessageBox.Show("Nothing Found");
                    }
                    n = 1;
                }
                else if (n==1)
                {
                    projectDetailsListView.Items.Clear();
                    n = 0;
                }
            }
        }
        // // // // // //


    }
}
