using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScriptSociety_Admin.Models;

namespace ScriptSociety_Admin.Data
{
    public class ScriptSociety_AdminContext : DbContext
    {
        public ScriptSociety_AdminContext (DbContextOptions<ScriptSociety_AdminContext> options)
            : base(options)
        {
        }

        public DbSet<ScriptSociety_Admin.Models.Announcements> Announcements { get; set; } = default!;
        public DbSet<ScriptSociety_Admin.Models.Inventory> Inventory { get; set; } = default!;
        public DbSet<ScriptSociety_Admin.Models.Orders> Orders { get; set; } = default!;
        public DbSet<ScriptSociety_Admin.Models.Users> Users { get; set; } = default!;
    }
}
