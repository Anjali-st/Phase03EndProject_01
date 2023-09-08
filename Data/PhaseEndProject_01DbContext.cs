using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppPhaseEndProject_01.Models;

namespace WebAppPhaseEndProject_01.Data
{
    public class PhaseEndProject_01DbContext : DbContext
    {
        public PhaseEndProject_01DbContext (DbContextOptions<PhaseEndProject_01DbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppPhaseEndProject_01.Models.EmpProfile> EmpProfile { get; set; } = default!;

        public DbSet<WebAppPhaseEndProject_01.Models.DeptMaster>? DeptMaster { get; set; }
    }
}
