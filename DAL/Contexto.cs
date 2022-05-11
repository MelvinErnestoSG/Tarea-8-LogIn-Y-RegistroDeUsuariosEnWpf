using Microsoft.EntityFrameworkCore;
using System;
using Tarea_8_LogIn_y_RegistroDeUsuariosEnWpf.Entidades;

namespace Tarea_8_LogIn_y_RegistroDeUsuariosEnWpf.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\GestorUsers.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                UsuarioId = 1,
                Nombres = "Melvin",
                Alias = "Mel",
                Clave = "12345",
                ConfirmarClave = "12345",
                Email = "Admin@gmail.com",
                FechaIngreso = new DateTime(2021, 11, 11),
                Rol = "Admin",
                Activo = true
            });
        }
    }
}
