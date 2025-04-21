using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityGradingSystem.Models;

namespace UniversityGradingSystem.Data
{
    public class GradesInfoContext : DbContext
    {
        public GradesInfoContext (DbContextOptions<GradesInfoContext> options)
            : base(options)
        {
        }

        public DbSet<UniversityGradingSystem.Models.GradesInfo> GradesInfo { get; set; } = default!;
    }
}
