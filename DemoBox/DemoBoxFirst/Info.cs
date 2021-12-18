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

//Creating Info Form for Employee Informations
namespace DemoBoxFirst
{
    public partial class Info : MetroFramework.Forms.MetroForm
    {
        string email;
        int i = 0,id=0;
        public Info()
        {
            InitializeComponent();
        }

        //Info Form loading with Email address
        // // // // // //
        public Info(string email)
        {
            InitializeComponent();
            this.email = email;
        }
        // // // // // //


        //Deleting Information
        // // // // // //
        private void deleteInfoTile_Click(object sender, EventArgs e)
        {

        }

        // // // // // //

        //UpdatingInformation
        private void updateInfoTile_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            s.ShowDialog();
        }
        // // // // // //

        //Project Name Button and Visibilty ON or OFF
        // // // // // //
        private void projectNameButton_Click(object sender, EventArgs e)
        {
            if (projectPendingPanel.Visible==true)
            {
                projectPendingPanel.Visible = false;
            }
            if (i==0)
            {
                projectPanel.Visible = true;
                i = 1;
            }

            else if ( i==1)
            {
                projectPanel.Visible = false;
                i = 0;
            }
        }
        // // // // // //

        //Loading Information FORM
        // // // // // //
        private void Info_Load(object sender, EventArgs e)
        {
            updateInfoTile.Visible = false;
            deleteInfoTile.Visible = false;
            projectPanel.Visible = false;
            projectPendingPanel.Visible = false;

            try
            {
                using (var context = new DemoBoxDBContext())
                {
                    //Setting Id From Database
                    var query = from x in context.Employees
                                where x.EmployeeEmail == email
                                select x.EmployeeId;
                    foreach (var em in query)
                    {
                        this.id = em;
                        idTextLabel.Text = ""+em;
                    }
                    // // //

                    //Setting Name From Database
                    var query1 = from x in context.Employees
                                where x.EmployeeEmail == email
                                select x.EmployeeName;
                    foreach (var em in query1)
                    {
                        nameTextLabel.Text = em;
                    }
                    // // //

                    //Setting Password From Database
                    var query2 = from x in context.Employees
                                where x.EmployeeEmail == email
                                select x.EmployeePassword;
                    foreach (var em in query2)
                    {
                        passwordTextLabel.Text = em;
                    }
                    // // //

                    //Setting Email From Database
                    var query3 = from x in context.Employees
                                where x.EmployeeEmail == email
                                select x.EmployeeEmail;
                    foreach (var em in query3)
                    {
                        emailTextLabel.Text = em;
                    }
                    // // //

                    //Setting Phone From Database
                    var query4 = from x in context.Employees
                                where x.EmployeeEmail == email
                                select x.EmplyoeePhone;
                    foreach (var em in query4)
                    {
                        phoneNoTextLabel.Text = em;
                    }
                    // // //

                    //Setting Id From Database
                    var query5 = from x in context.Employees
                                where x.EmployeeEmail == email
                                select x.EmployeeBirth;
                    foreach (var em in query5)
                    {
                        dateOfBirthTextLabel.Text = em;
                    }
                    // // //

                    //Setting Id From Database
                    var query6 = from x in context.Employees
                                where x.EmployeeEmail == email
                                select x.EmployeeGender;
                    foreach (var em in query6)
                    {
                        genderTextLabel.Text = em;
                    }
                    // // //

                    //Setting Project Number till now
                    int a = 0;
                    IEnumerable<ProjectEmployee> query7 = from x in context.ProjectEmployees
                                 where x.EmployeeId == id
                                 select x;
                    foreach (var em in query7)
                    {
                        a++;
                    }
                    projectCompletedTextLabel.Text = "" + a;
                    // // //

                    //Loading Pending Projects
                }
            }

            catch
            {

            }
        }
        // // // // // //

        //PendingProjectPanel Show On or Off via pendingProjectButton
        // // // // // //
        private void pendingProjectButton_Click_1(object sender, EventArgs e)
        {
            if (projectPanel.Visible==true)
            {
                projectPanel.Visible = false;
            }
            if (i == 0)
            {
                projectPendingPanel.Visible = true;
                i = 1;
            }
            else if (i == 1)
            {
                projectPendingPanel.Visible = false;
                i = 0;
            }

        }
        // // // // // //

    }
}
