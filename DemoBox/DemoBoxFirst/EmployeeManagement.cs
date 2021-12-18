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
using System.IO;


//Employee Form and it's Applications with DemoBoxDb
namespace DemoBoxFirst
{
    public partial class EmployeeManagement : MetroFramework.Forms.MetroForm
    {
        string email;
        int role;
        OpenFileDialog openFildlg;
        FileInfo fi;
        int proId,id;
        DemoBoxThrid.File file;
        MainUI m = new MainUI();

        //Creating EmployeeManagmentForm with it's User Name and it's Role

         // // // // // //
        public EmployeeManagement(string email,int role)
        {
            InitializeComponent();
            this.email = email;
            this.role = role;
        }
        // // // // // //


        public EmployeeManagement ()
        {
            InitializeComponent();
        }


        private void pendingRequestToolTip_Popup(object sender, PopupEventArgs e)
        {

        }


        //Opening Project Hub Form to Check info about Projects
        // // // // // //
        private void projectHubButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectHub ph = new ProjectHub(email);
            ph.ShowDialog();
            this.Close();
        }
        // // // // // //

        
        //Opening Sending Email Form
        // // // // //  //
        private void empSendEmailButton_Click(object sender, EventArgs e)
        {
            EmailSender es = new EmailSender();
            es.ShowDialog();
        }
        // // // // // //


       //Application Exit !
       // // // // // //
        private void EmployeeManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            m.ShowDialog();
            this.Close();
        }
        // // // // // //


        //Opening Information Form for This Employee
        private void empInfoButton_Click(object sender, EventArgs e)
        {
            Info inf = new Info(email);
            inf.ShowDialog();
        }
        // // // // // // //


        //Loging out from EmployeeManagment Form
        // // // // // //
        private void empLogoutLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            m.ShowDialog();
            this.Close();
        }
        // // // // // //


        //Setting EmployeeId,EmployeeName,EmployeeRole, at the top of Form in empNameLabel
        // // // // // //
        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DemoBoxDBContext())
                {
                    //Setting Employee Name According to Login
                    var query = from x in context.Employees
                                where x.EmployeeEmail == email
                                select x.EmployeeName;
                    foreach (var em in query)
                    {
                        empNameLabel.Text = em;
                    }

                    //Seting Employee ID According to Login
                    var query1 = from x in context.Employees
                                where x.EmployeeEmail == email
                                select x.EmployeeId;

                    foreach (var em in query1)
                    {
                       this.id = em;
                        employeeIdLabel.Text = ""+em;
                    }

                    //

                    //Seting Employee Status Accoding to Login
                    var query2 = from x in context.Employees
                                  where x.EmployeeEmail == email
                                  select x.EmployeeStatus;

                    foreach (var em in query2)
                    {
                        if (em != null)
                        {
                            empStatusTextLabel.Text = "" + em;
                        }
                        else
                        {
                            empStatusTextLabel.Text = "Nill";
                        }
                    }

                    //Setting Employee Status According to Login
                    var query3 = from x in context.Employees
                                 where x.EmployeeRole == role
                                 select x.EmployeeRole;
                     foreach (var em in query3)
                    {
                        if (em ==2)
                        {
                            joinedAsTextLabel.Text = "Team Leader";
                        }
                        else if ( em==3)
                        {
                            joinedAsTextLabel.Text = "Analyst";
                        }
                        else if (em==4)
                        {
                            joinedAsTextLabel.Text = "Designer";
                        }

                        else if (em==5)
                        {
                            joinedAsTextLabel.Text = "Programmer";
                        }

                        else if (em==6)
                        {
                            joinedAsTextLabel.Text = "Tester";
                        }
                    }

                    //Setting ProjectId
                    var query4 = from x in context.ProjectEmployees
                                 where x.EmployeeId == id
                                 select x.ProjectId;

                    foreach (var em in query4)
                    {
                        this.proId = em;
                    }

                    //Loading Project on List View
                    string name, file;
                    var query5 = from p in context.Projects
                                 join c in context.Files on p.ProjectId equals c.ProjectId
                                 select new { projectName = p.ProjectName, c.FileName };

                    foreach (var em in query5)
                    {
                        name = em.projectName;
                        file = em.FileName;

                        ListViewItem lvi1 = new ListViewItem();
                        lvi1.Text = name;
                        lvi1.SubItems.Add(file);

                        projectOnWorkListView.Items.Add(lvi1);
                    }

                }
            }
            catch 
            {
               
            }
        }

        private void projectOnWorkListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        //Getting File from Desktop
        // // // // // //
        private void browseButton_Click(object sender, EventArgs e)
        {
            this.openFildlg = new OpenFileDialog();
            this.openFildlg.InitialDirectory = Directory.GetCurrentDirectory();
            if (openFildlg.ShowDialog() == DialogResult.OK)
            {
                this.fi = new FileInfo(openFildlg.FileName);
                uploadingFileTextBox.Text = fi.ToString();
            }
        }
        // // // // // //
        
        
        //Uplaoding the File into Database
        // // // // // //
        private void uploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DemoBoxDBContext())
                {
                    FileStream fs = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read);
                    BinaryReader rdr = new BinaryReader(fs);
                    byte[] fileData = rdr.ReadBytes((int)fs.Length);
                    rdr.Close();
                    fs.Close();

                    file = new DemoBoxThrid.File();

                    file.FileName = fi.FullName;
                    file.Data = fileData;
                    file.FileExtension = fi.Extension;
                    file.ProjectId = proId;
                    file.EmployeeId = id;

                    context.Files.Add(file);
                    context.SaveChanges();
                }
            }
            catch
            {

            }

        }
        // // // // // //


    }
}
