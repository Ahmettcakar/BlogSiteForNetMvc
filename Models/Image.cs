﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Images")]
    public class Image:ModelBase
    {
      
        public string ImageType { get; set; }
        public string ImagePath { get; set; }
    }
}
