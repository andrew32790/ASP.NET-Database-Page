using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNETCORE_TEST1.Models;

namespace ASPNETCORE_TEST1.Data
{
    public class ASPNETCORE_TEST1Context : DbContext
    {
        public ASPNETCORE_TEST1Context (DbContextOptions<ASPNETCORE_TEST1Context> options)
            : base(options)
        {
        }

        public DbSet<ASPNETCORE_TEST1.Models.Movie> Movie { get; set; }

        public DbSet<ASPNETCORE_TEST1.Models.Game> Game { get; set; }

        
    }
}
