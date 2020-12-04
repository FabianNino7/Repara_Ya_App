using System;
using Microsoft.EntityFrameworkCore;
using Repara_Ya__App.Models;

namespace Repara_Ya__App.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            Database.SetCommandTimeout(9000);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<QuieroAdquirirUnServicio> QuieroAdquirirUnServicioTable { get; set; }
        public DbSet<QuieroOfrecerMisServicios> QuieroOfrecerTable { get; set;}
        public DbSet<LoginAdquirir> LoginAdquirirTable { get; set; }
        
        public DbSet<IngresarAdquirir> IngresarAdquirirTable { get; set; }
        public DbSet<RegistrateAdquirir> RegistrateAdquirirTable { get; set; }
        public DbSet<LoginOfrecer> LoginOfrecerTable { get; set; }
        public DbSet<IngresarOfrecer> IngresarOfrecerTable { get; set; }
        
        public DbSet<RegistrateOfrecer> RegistrateOfrecerTable { get; set; }
        public DbSet<Adquirir> AdquirirTable { get; set; }
        public DbSet<Ofrecer> OfrecerTable { get; set; }
    }
}