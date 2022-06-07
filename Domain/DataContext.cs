using System;
using DataLib;
using Microsoft.EntityFrameworkCore;


namespace Domain
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public virtual DbSet<Employee> employees { get; set; }
    }
}
