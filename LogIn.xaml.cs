using System.Windows;
using Tarea_8_LogIn_y_RegistroDeUsuariosEnWpf.BLL;
using Tarea_8_LogIn_y_RegistroDeUsuariosEnWpf.UI.Ventana_Menu;

namespace Tarea_8_LogIn_y_RegistroDeUsuariosEnWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LogIn : Window
    {

        public LogIn()
        {
            InitializeComponent();
        }

        private void IniciarButton_Click(object sender, RoutedEventArgs e)
        {
            bool paso = LogInBLL.Validar(NombreUsuarioTextBox.Text, ContrasenaPasswordBox.Password);

            if (NombreUsuarioTextBox.Text == string.Empty && ContrasenaPasswordBox.Password == string.Empty)
            {
                MessageBox.Show("El Campo Nombre Usuario está vacío", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (paso)
            {
                VentanaMenu menu = new VentanaMenu();
                menu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Nombre de Usuario o Contraseña incorrectos.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void SalirButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
