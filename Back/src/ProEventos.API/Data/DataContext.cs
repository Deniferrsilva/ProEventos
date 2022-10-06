using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        
        public DbSet<Evento> Eventos { get; set; }

        public DbSet<Paciente> Pacientes { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {        modelBuilder.Entity<Paciente>()
        // .HasNoKey();
        // }
    }
}