using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Educations")]
    public class Education:ModelBase
    {
        
        public string? Name { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
    }
}
