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
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


/* Sign Up Form for an Employee
 * and logic to database connection and it's usage
 * */

namespace DemoBoxFirst
{
    public partial class SignUp : MetroFramework.Forms.MetroForm
    {
        MainUI m = new MainUI();
        string gender;
        public SignUp()
        {
            InitializeComponent();
        }

        //Back to Main Ui
        private void backLink_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                m.ShowDialog();
                this.Close();
            }
            catch
            { }
        }

        private void doneLink_Click(object sender, EventArgs e)
        {
            if(maleCheckBox.Checked==true && femaleCheckBox.Checked==false)
            {
                gender = "Male";
            }
            else if (femaleCheckBox.Checked==true && maleCheckBox.Checked==false)
            {
                gender = "FeMale";
            }
            try
            {
                var newEmployee = new Employee();

                newEmployee.EmployeeName = uNameTextBox.Text;
                newEmployee.EmployeeEmail = uEmailTextBox.Text;
                newEmployee.EmployeePassword = uPasswordTextBox.Text;
                newEmployee.EmployeeGender = gender;
                newEmployee.EmplyoeePhone = uPhoneNoTextBox.Text;
                newEmployee.EmployeeBlood = bloodGroupComboBox.Text;
                newEmployee.EmployeeBirth = dateOfBirthTextBox.Text;

                using (var context = new DemoBoxDBContext())
                {
                    context.Employees.Add(newEmployee);
                    context.SaveChanges();
                }


             }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            try
            {
                this.Hide();
                m.ShowDialog();
                this.Close();
            }
            catch { }

        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Hide();
                m.ShowDialog();
                this.Close();
            }
            catch { }
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void uNameTextBox_Click(object sender, EventArgs e)
        {
           
        }

        private void uEmailTextBox_Click(object sender, EventArgs e)
        {
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
