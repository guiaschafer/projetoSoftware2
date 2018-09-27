using CompareRemedios.Dominio.Entidades;
using CompareRemedios.Dominio.Entity.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompareRemedios.Dominio.Entity
{
    public class CompareRemediosContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public CompareRemediosContext() 
        {
            this.MigrationsDirectory = "DirOne\\DirTwo";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
                optionsBuilder.UseSqlServer(@"Server=.\SQLExpress;Database=FarmaciaDb;Trusted_Connection=True;");
                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=FarmaciaDB;Trusted_Connection=True;");
          
            modelBuilder.ApplyConfiguration(new FarmarciaMap());

        }
    }
}
