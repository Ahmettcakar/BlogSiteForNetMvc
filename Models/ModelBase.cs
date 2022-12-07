using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ModelBase
    {
        [Key]
        public Guid Id { get; set; }= Guid.NewGuid();
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; }    = false;
        public bool IsActive { get; set; } = true; 



    }
}
