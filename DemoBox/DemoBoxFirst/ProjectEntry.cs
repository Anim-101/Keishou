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

/*Project Specification and it's information
 * entry into database from Project Entry Form
 * */
namespace DemoBoxFirst
{
    public partial class ProjectEntry : MetroFramework.Forms.MetroForm
    {
        public ProjectEntry()
        {
            InitializeComponent();
        }

        //Back Button
        private void backLink_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ProjectEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        //By Clicking Done Project Manager has added an Project into Project Database
        private void doneLink_Click(object sender, EventArgs e)
        {
            try
            {
                var newProject = new Project();

                newProject.ProjectName = projectNameTextBox.Text;
                newProject.ClientName = projectClientTextBox.Text;
                newProject.ClientEmail = clientEmailTextBox.Text;
                newProject.ClientContact = clientContactNoTextBox.Text;
                newProject.ProjectTimeline = projectTimelineTextBox.Text;
                newProject.ProjectCost = projectCostTextBox.Text;
                newProject.EstimatedTimeline = estimatedTimeTextBox.Text;
                newProject.EstimatedCost = estimatedCostTextBox.Text;
                newProject.DeliveryDate = deliveryDatePicker.Text;
                newProject.Specification = specificationTextBox.Text;
                newProject.ProjectStatus = "Active";


                using (var context = new DemoBoxDBContext())
                {
                    context.Projects.Add(newProject);
                    context.SaveChanges();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
