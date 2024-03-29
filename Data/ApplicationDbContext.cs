﻿using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { 
        
        }
       public DbSet<Profile> profiles { get; set; }
       public DbSet<Experience> experiences { get; set; }
       public DbSet<Image> images { get; set; }
       public DbSet<Education> educations { get; set; }
    }
}
