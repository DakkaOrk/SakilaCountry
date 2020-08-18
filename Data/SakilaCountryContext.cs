using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SakilaCountry.Models;

namespace SakilaCountry.Data
{
    public class SakilaCountryContext : DbContext
    {
        public SakilaCountryContext (DbContextOptions<SakilaCountryContext> options)
            : base(options)
        {
        }

        public DbSet<SakilaCountry.Models.Country> Country { get; set; }
    }
}
