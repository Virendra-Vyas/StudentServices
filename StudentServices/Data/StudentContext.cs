using Microsoft.EntityFrameworkCore;
using StudentServices.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentServices.Data
{
    public class StudentContext: DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options): base(options)
        {

        }

        public DbSet<Students> students { get; set; }
    }
}
