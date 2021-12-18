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
    [Table("File")]
    public class File
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FileId { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public byte [] Data { get; set; }
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }       

    }
}
