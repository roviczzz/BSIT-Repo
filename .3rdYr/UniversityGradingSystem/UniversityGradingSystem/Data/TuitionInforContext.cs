using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityGradingSystem.Models;

namespace UniversityGradingSystem.Data
{
    public class TuitionInforContext : DbContext
    {
        public TuitionInforContext (DbContextOptions<TuitionInforContext> options)
            : base(options)
        {
        }

        public DbSet<UniversityGradingSystem.Models.TuitionInfor> TuitionInfor { get; set; } = default!;
    }
}
