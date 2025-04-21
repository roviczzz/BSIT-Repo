using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScriptSociety_Client.Models;

namespace ScriptSociety_Client.Data
{
    public class ScriptSociety_ClientContext : DbContext
    {
        public ScriptSociety_ClientContext (DbContextOptions<ScriptSociety_ClientContext> options)
            : base(options)
        {
        }

        public DbSet<ScriptSociety_Client.Models.Item> Item { get; set; } = default!;
        public DbSet<ScriptSociety_Client.Models.Users> Users { get; set; } = default!;
        public DbSet<ScriptSociety_Client.Models.Announcements> Announcements { get; set; } = default!;
    }
}
