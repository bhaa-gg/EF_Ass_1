using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vechicle.Models;

namespace EF_Ass_1.DbContexts
{
    internal class MyContext : DbContext
    {



        public DbSet<Vehicles> Vehicles { get; set; }
        public DbSet<Payment> Payments{ get; set; }
        public DbSet<CreditCardPayment> CreditCardPayments { get; set; }
        public DbSet<CashPayment> CashPayments { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<Electronics> Electronics { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = InheritMap ; Trusted_Connection =true ; TrustServerCertificate = true");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Q1
            //modelBuilder.Entity<Vehicles>()
            //    .HasDiscriminator<string>("VehicleType")
            //    .HasValue<Bus>("bus")
            //    .HasValue<Car>("car")
            //    .HasValue<Vehicles>("Vehicles");
            #endregion


            #region Q2
            //modelBuilder.Entity<Payment>().ToTable("Payments");
            //modelBuilder.Entity<CreditCardPayment>().ToTable("CreditCardPayments");
            //modelBuilder.Entity<CashPayment>().ToTable("CashPayments");
            #endregion

            #region Q3
            //modelBuilder.Entity<Book>().ToTable("Books");
            //modelBuilder.Entity<Electronics>().ToTable("Electronics");

            #endregion

        }


    }
}
