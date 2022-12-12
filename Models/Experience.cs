using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Experience")]
    public class Experience:ModelBase
    {
		
		public string? Name { get; set; }
        public string? ExperienceCity { get; set; }
        public string? Description { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }

        public Guid? ProfileId { get; set; }
        public virtual Profile profile { get; set; }
    }
}
