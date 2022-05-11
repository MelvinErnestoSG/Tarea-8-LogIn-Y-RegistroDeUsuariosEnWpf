using System;
using System.Linq;
using Tarea_8_LogIn_y_RegistroDeUsuariosEnWpf.DAL;

namespace Tarea_8_LogIn_y_RegistroDeUsuariosEnWpf.BLL
{
    public class LogInBLL
    {
        public static bool Validar(string nombres, string clave)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                paso = contexto.Usuarios.Any(u => u.Nombres.Equals(nombres) && u.Clave.Equals(clave));
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
    }
}
