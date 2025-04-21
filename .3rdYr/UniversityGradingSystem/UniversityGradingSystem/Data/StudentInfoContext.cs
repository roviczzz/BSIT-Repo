using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityGradingSystem.Models;

namespace UniversityGradingSystem.Data
{
    public class StudentInfoContext : DbContext
    {
        public StudentInfoContext (DbContextOptions<StudentInfoContext> options)
            : base(options)
        {
        }

        public DbSet<UniversityGradingSystem.Models.StudentInfo> StudentInfo { get; set; } = default!;
    }
}
