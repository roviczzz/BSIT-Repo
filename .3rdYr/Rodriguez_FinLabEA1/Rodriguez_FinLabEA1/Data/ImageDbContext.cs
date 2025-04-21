using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rodriguez_FinLabEA1.Models;

namespace Rodriguez_FinLabEA1.Data
{
    public class ImageDbContext : DbContext
    {
        public ImageDbContext (DbContextOptions<ImageDbContext> options)
            : base(options)
        {
        }

        public DbSet<Rodriguez_FinLabEA1.Models.Image> Image { get; set; } = default!;
    }
}
