using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppStudentGrades.Models;

namespace WebAppStudentGrades.Data
{
    public class WebAppStudentGradesContext : DbContext
    {
        public WebAppStudentGradesContext (DbContextOptions<WebAppStudentGradesContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppStudentGrades.Models.User> User { get; set; } = default!;
    }
}
