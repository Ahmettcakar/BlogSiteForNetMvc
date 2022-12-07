using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Profiles")]
    public class Profile:ModelBase
    {
        public string? Name { get; set; }
        public string? Mission { get; set; }
        public string? LastMission { get; set; }
        public string? City { get; set; }
        public string? Nationality { get; set; }
        public string? Technology { get; set; }
        public string? AboutMe { get; set; }
  
        public string? AboutMeMore { get; set; }
        public string? BirtDay { get; set; }
        public string? Maritial { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? EducationId { get; set; }
        public string? ImageId { get; set; }
        public virtual Image? Image { get; set; }
        public virtual ICollection<Education>? Education { get; set; }



    }
}
