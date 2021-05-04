﻿using CustomMapping.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomMapping.DataAccess
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Personel> Personels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personel>().ToTable("Employees");

            modelBuilder.Entity<Personel>().Property(p=>p.Id).HasColumnName("EmployeeID");
            modelBuilder.Entity<Personel>().Property(p => p.Name).HasColumnName("FirstName");
            modelBuilder.Entity<Personel>().Property(p => p.Surname).HasColumnName("LastName");
        }
    }
}
