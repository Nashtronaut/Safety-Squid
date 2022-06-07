using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafetySquid._data._entities
{
    public class SquidDbContext : DbContext
    {
        public DbSet<EmergContact> EmergContacts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FuelCard> FuelCards { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketRecieved> TicketsRecieved { get; set; }
        public DbSet<Unit> Units { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=safety_squid.db");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
