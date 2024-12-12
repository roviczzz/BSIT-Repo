using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rodriguez_ScriptSocietyMVC.Models;

namespace Rodriguez_ScriptSocietyMVC.Data
{
    public class Rodriguez_ScriptSocietyMVCContext : DbContext
    {
        public Rodriguez_ScriptSocietyMVCContext (DbContextOptions<Rodriguez_ScriptSocietyMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Rodriguez_ScriptSocietyMVC.Models.Inventory> Inventory { get; set; } = default!;
        public DbSet<Rodriguez_ScriptSocietyMVC.Models.Campaign> Campaign { get; set; } = default!;
    }
}
