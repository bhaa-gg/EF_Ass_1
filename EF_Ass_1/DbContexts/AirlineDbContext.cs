using EF_Ass_1.Constant;
using EF_Ass_1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ass_1.DbContexts
{
    internal class AirlineDbContext : DbContext
    {
        public DbSet<AirCraft> AirCrafts { get; set; }
        public DbSet<Airline> AirLines { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<AssignedRoute> AssignedRoutes { get; set; }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<AirLinePhone> AirLinePhones { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = AirlineEf ; Trusted_Connection =true ; TrustServerCertificate = true");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            #region EmpBD
            modelBuilder.Entity<Employee>().OwnsOne(E=>E.Birthday);
            #endregion


            #region AirLineTrans
            modelBuilder.Entity<Airline>().HasMany(A => A.Transactions).WithOne(T => T.Airline)
                .HasForeignKey(T=>T.AirlineId)
                 .OnDelete(DeleteBehavior.Restrict);
            #endregion


            #region AirCraft_Crew
            modelBuilder.Entity<AirCraft>().HasOne(a => a.Crew).WithOne(c => c.AirCraft)
                .HasForeignKey<Crew>(c=>c.AirCraftId)
                 .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region AddGenderConstrain

            modelBuilder.Entity<Employee>()
                .HasCheckConstraint(
                    "CK_Employee_Gender",
                    $"[Gender] IN ('{Gender.Male}', '{Gender.Female}')"
                );
            #endregion

            #region AssignedRoute
            modelBuilder.Entity<AirCraft>().HasOne(a => a.Crew)
                .WithOne(c => c.AirCraft)
                .HasForeignKey<Crew>(c=>c.AirCraftId);
            #endregion

        }


    }
}
