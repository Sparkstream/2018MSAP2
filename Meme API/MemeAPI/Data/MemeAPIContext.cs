using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MemeAPI.Models
{
    public class MemeAPIContext : DbContext
    {
        public MemeAPIContext (DbContextOptions<MemeAPIContext> options)
            : base(options)
        {
        }

        public DbSet<MemeAPI.Models.MemeItem> MemeItem { get; set; }
    }
}
