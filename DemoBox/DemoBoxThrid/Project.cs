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
    //Entity Model of Project TABLE
    [Table("Project")]
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ClientName { get; set; }
        public string ClientContact { get; set; }
        public string ClientEmail { get; set; }
        public string ProjectStatus { get; set; }
        public string ProjectTimeline { get; set; }
        public string  ProjectCost { get; set; }
        public string EstimatedTimeline { get; set; }
        public string EstimatedCost { get; set; }
        public string DeliveryDate { get; set; }
        public string Specification { get; set; }

    }
}
