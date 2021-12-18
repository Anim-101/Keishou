//DemoBoxThird is Database Entity Model of Demo Box Applciation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace DemoBoxThrid
{
    //Entity Model of Employee TABLE
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeeBlood { get; set; }
        public string EmplyoeePhone { get; set; }
        public string EmployeeGender { get; set; }
        public string EmployeeBirth { get; set; }
        public int EmployeeRole { get; set;}

        public int EmployeeProjectRole { get; set; }
        public string EmployeeStatus { get; set; }


    }
}
