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
        public string? Job { get; set; }
        public string? LastJob { get; set; }
        public string? City { get; set; }
        public string? Nationality { get; set; }
        public string? Technology { get; set; }
        public string? AboutMe { get; set; }
  
        public string? AboutMeMore { get; set; }
        public string? BirtDay { get; set; }
        public string? Maritial { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public Guid EducationId { get; set; }
        public Guid ImageId { get; set; }
        public virtual Image? Image { get; set; }
       
        public  List<Education>? Educations { get; set; }



    }
}
