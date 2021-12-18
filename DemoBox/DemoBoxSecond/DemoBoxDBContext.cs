//DemoBoxSecond is DAL of Demo Box Application
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using DemoBoxThrid;

namespace DemoBoxSecond
{
    public class DemoBoxDBContext : DbContext
    {
        public DemoBoxDBContext () : base ("DemoBoxDb")
        {

        }

        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<ProjectEmployee> ProjectEmployees { get; set; }
       
    }
}
