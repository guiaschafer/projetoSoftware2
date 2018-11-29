﻿    using CompareRemedios.Dominio.Entidades;
using CompareRemedios.Dominio.Entity.Maps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Farmacia> Farmacias { get; set; }
        public DbSet<Preco> Precos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public DataBaseContext() : base()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FarmaciaMap());
            modelBuilder.Configurations.Add(new PrecoMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new UsuarioMap());

        }
    }
}
