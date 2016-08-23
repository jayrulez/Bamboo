using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Models
{
    public class BambooContext : DbContext
    {
        public BambooContext(DbContextOptions<BambooContext> options)
            : base(options)
        { }

        public DbSet<RegistrationModel> Registrations { get; set; }
    }
}
