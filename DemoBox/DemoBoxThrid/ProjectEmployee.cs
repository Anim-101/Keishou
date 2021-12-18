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
    [Table("ProjectEmployee")]
    public class ProjectEmployee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int projeectEmployeeId { get; set; }
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
    }
}
