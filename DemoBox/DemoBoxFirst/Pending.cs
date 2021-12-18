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
    public partial class Pending : MetroFramework.Forms.MetroForm
    {
        int i = 0,id=0;
        string iden = null, roles = null,status=null;
        public Pending()
        {
            InitializeComponent();
        }

        //New Employee Pending Requests by pressing Button and values in PendingNewListView
        // // // // // // 
        private void newEmployeeButton_Click(object sender, EventArgs e)
        {

            if (i==0)
            {
                if (pendingOldPanel.Visible == true)
                {
                    pendingOldPanel.Visible = false;
                }
                pendingNewPanel.Visible = true;
                i = 1;

                try
                {
                    string id,name, role;
                    using (var context = new DemoBoxDBContext())
                    {

                        IEnumerable<Employee> Emp = from x in context.Employees
                                                    select x;

                        foreach (var em in Emp)
                        {
                            if (em.EmployeeRole == 0)
                            {
                                id = em.EmployeeId.ToString();
                                name = em.EmployeeName;
                                role = "NILL";

                                ListViewItem lvi1 = new ListViewItem();

                                lvi1.Text = id;
                                lvi1.SubItems.Add(name);
                                lvi1.SubItems.Add(role);

                                pendingNewListView.Items.Add(lvi1);
                            }
                            /*else if (em.EmployeeRole == 2)
                            {
                                id = em.EmployeeId.ToString();
                                name = em.EmployeeName;
                                role = "NILL";

                                ListViewItem lvi1 = new ListViewItem();

                                lvi1.Text = id;
                                lvi1.SubItems.Add(name);
                                lvi1.SubItems.Add(role);

                                pendingNewListView.Items.Add(lvi1);
                            }
                            else if (em.EmployeeRole == 4)
                            {
                                id = em.EmployeeId.ToString();
                                name = em.EmployeeName;
                                role = "NILL";

                                ListViewItem lvi1 = new ListViewItem();

                                lvi1.Text = id;
                                lvi1.SubItems.Add(name);
                                lvi1.SubItems.Add(role);

                                pendingNewListView.Items.Add(lvi1);
                            }
                            else if (em.EmployeeRole == 5)
                            {
                                id = em.EmployeeId.ToString();
                                name = em.EmployeeName;
                                role = "NILL";

                                ListViewItem lvi1 = new ListViewItem();

                                lvi1.Text = id;
                                lvi1.SubItems.Add(name);
                                lvi1.SubItems.Add(role);

                                pendingNewListView.Items.Add(lvi1);
                            }
                            else if (em.EmployeeRole == 6)
                            {
                                id = em.EmployeeId.ToString();
                                name = em.EmployeeName;
                                role = "NILL";

                                ListViewItem lvi1 = new ListViewItem();

                                lvi1.Text = id;
                                lvi1.SubItems.Add(name);
                                lvi1.SubItems.Add(role);

                                pendingNewListView.Items.Add(lvi1);
                            }*/
                        }

                    }
                }
                catch
                {

                }
            }
            else if (i==1)
            {
                pendingNewListView.Items.Clear();
                pendingNewPanel.Visible=false;
                pendingOldPanel.Visible = false;
                i = 0;
            }
        }
        // // // // // // 


        //Loading Pending Form with setting visibility On or Off of new and old pending panels
        // // // // // //
        private void Pending_Load(object sender, EventArgs e)
        {
            pendingNewPanel.Visible = false;
            pendingOldPanel.Visible = false;
        }
        // // // // // //


        //Chaing Old Employee's Status
        // // // // // //
        private void oldEmployeeButton_Click(object sender, EventArgs e)
        {
            if (i==0)
            {
                if (pendingNewPanel.Visible == true)
                {
                    pendingNewPanel.Visible = false;
                }
                pendingOldPanel.Visible = true;
                
                i = 1;

                try
                {
                    string id, name, status;
                    using (var context = new DemoBoxDBContext())
                    {

                        IEnumerable<Employee> Emp = from x in context.Employees
                                                    select x;

                        foreach (var em in Emp)
                        {
                            if (em.EmployeeStatus==null)
                            {
                                id = em.EmployeeId.ToString();
                                name = em.EmployeeName;
                                status = em.EmployeeStatus;

                                ListViewItem lvi1 = new ListViewItem();

                                lvi1.Text = id;
                                lvi1.SubItems.Add(name);
                                lvi1.SubItems.Add(status);

                                pendingOldListView.Items.Add(lvi1);
                           }
                            /*else if (em.EmployeeRole == 3)
                            {
                                id = em.EmployeeId.ToString();
                                name = em.EmployeeName;
                                role = "Analyst";

                                ListViewItem lvi1 = new ListViewItem();

                                lvi1.Text = id;
                                lvi1.SubItems.Add(name);
                                lvi1.SubItems.Add(role);

                                pendingOldListView.Items.Add(lvi1);
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

                                pendingOldListView.Items.Add(lvi1);
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

                                pendingOldListView.Items.Add(lvi1);
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

                                pendingOldListView.Items.Add(lvi1);
                            }*/
                        }

                    }
                }
                catch
                {

                }
            }
            else if (i==1)
            {
                pendingOldListView.Items.Clear();
                pendingOldPanel.Visible = false;
                pendingNewPanel.Visible = false;
                i = 0;
            }
        }
        // // // // // //

        
        //Assinging Role and Status to Employee by clicking AssignButton
        // // // // // //
        private void assignButton_Click(object sender, EventArgs e)
        {
            if (id !=0 && roles !=null)
            {
                using (var context = new DemoBoxDBContext())
                {
                    var query = from x in context.Employees
                                where x.EmployeeId == id
                                select x;

                    foreach (var em in query)
                    {
                        if (roles == "Team Leader")
                        {
                            em.EmployeeRole = 2;
                        }
                        else if (roles == "Analyst")
                        {
                            em.EmployeeRole = 3;
                        }
                        else if (roles == "Designer")
                        {
                            em.EmployeeRole = 4;
                        }
                        else if (roles == "Programmer")
                        {
                            em.EmployeeRole = 5;
                        }
                        else if (roles == "Tester")
                        {
                            em.EmployeeRole = 6;
                        }

                    }

                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }


            }

            else if (id !=0 && status != null)
            {
                using (var context = new DemoBoxDBContext())
                {
                    var query = from x in context.Employees
                                where x.EmployeeId == id
                                select x;

                    foreach (var em in query)
                    {
                        em.EmployeeStatus = status;
                    }

                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }

            }

        }
        // // // // // //


        //Getting Selected Items from StatusComboBox
        // // // // // //
        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.status = statusComboBox.SelectedItem.ToString();
        }

        private void pendingNewListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        // // // // // //


        //Getting Selected Items from NewPendingListView
        // // // // // //
        private void pendingNewListView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                iden = pendingNewListView.SelectedItems[0].SubItems[0].Text;
                this.id = Convert.ToInt32(iden);
                iden = null;
            }
            catch
            {

            }
        }
        // // // // // //


        //Getting Selected Items from RolesComboBox
        // // // // // //
        private void rolesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.roles = rolesComboBox.SelectedItem.ToString();
        }
        // // // // // //

        
        //Selecting Items in PendingOldListview
        // // // // // //
        private void pendingOldListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.iden = pendingOldListView.SelectedItems[0].SubItems[0].Text;
                this.id = Convert.ToInt32(iden);
                iden = null;
            }
            catch
            {

            }
        }
        // // // // // //
    }
}
