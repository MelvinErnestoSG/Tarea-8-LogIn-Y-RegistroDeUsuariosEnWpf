using Tarea_8_LogIn_y_RegistroDeUsuariosEnWpf.UI.Consultas;
using Tarea_8_LogIn_y_RegistroDeUsuariosEnWpf.UI.Registros;
using System.Windows;

namespace Tarea_8_LogIn_y_RegistroDeUsuariosEnWpf.UI.Ventana_Menu
{
    /// <summary>
    /// Interaction logic for VentanaMenu.xaml
    /// </summary>
    public partial class VentanaMenu : Window
    {
        public VentanaMenu()
        {
            InitializeComponent();
        }

        private void RegistroUsuariosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var rUsuario = new rUsuarios();
            rUsuario.Show();
        }

        private void ConsultaUsuarioMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var cUsuario = new cUsuarios();
            cUsuario.Show();
        }
    }
}
