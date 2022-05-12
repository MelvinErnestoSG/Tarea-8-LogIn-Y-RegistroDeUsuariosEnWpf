using Tarea_8_LogIn_y_RegistroDeUsuariosEnWpf.UI.Consultas;
using Tarea_8_LogIn_y_RegistroDeUsuariosEnWpf.UI.Registros;
using Tarea_8_LogIn_y_RegistroDeUsuariosEnWpf.UI.Ayuda;
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

        private void AyudaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var ayudas = new Ayudas();
            ayudas.Show();
        }
    }
}
