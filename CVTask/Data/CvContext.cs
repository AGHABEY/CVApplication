using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CVTask.Data
{
    public class CvContext:DbContext
    {
        public CvContext():base("MyCvConnection")
        {

        }

        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<ContactMe> Contacts { get; set; }
    }
}