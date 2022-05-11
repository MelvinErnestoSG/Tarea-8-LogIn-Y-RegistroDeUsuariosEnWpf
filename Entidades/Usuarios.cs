using System;
using System.ComponentModel.DataAnnotations;

namespace Tarea_8_LogIn_y_RegistroDeUsuariosEnWpf.Entidades
{
    public class Usuarios
    {

        [Key]
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public string ConfirmarClave { get; set; }
        public DateTime FechaIngreso { get; set; } = DateTime.Now;
        public string Rol { get; set; }
        public bool Activo { get; set; } = true;
    }
}
