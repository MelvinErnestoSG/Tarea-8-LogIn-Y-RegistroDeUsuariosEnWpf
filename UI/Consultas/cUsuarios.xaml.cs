using System.Collections.Generic;
using System.Windows;
using Tarea_8_LogIn_y_RegistroDeUsuariosEnWpf.BLL;
using Tarea_8_LogIn_y_RegistroDeUsuariosEnWpf.Entidades;

namespace Tarea_8_LogIn_y_RegistroDeUsuariosEnWpf.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cUsuarios.xaml
    /// </summary>
    public partial class cUsuarios : Window
    {
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Usuarios>();

            if (!string.IsNullOrEmpty(CriterioTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //todo
                        listado = UsuariosBLL.GetList(u => true);
                        break;

                    case 1://Id
                        listado = UsuariosBLL.GetList(u => u.UsuarioId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;

                    case 2://Nombres
                        listado = UsuariosBLL.GetList(u => u.Nombres.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;

                    case 3://Email
                        listado = UsuariosBLL.GetList(u => u.Email.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;

                    case 4://Rol
                        listado = UsuariosBLL.GetList(u => u.Rol.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;
                }
            }
            else
            {
                listado = UsuariosBLL.GetList(u => true);
            }

            if (DesdeDatePicker.SelectedDate != null && HastaDatePicker.SelectedDate != null)
                listado = UsuariosBLL.GetList(u => u.FechaIngreso.Date > DesdeDatePicker.SelectedDate && u.FechaIngreso.Date < HastaDatePicker.SelectedDate);

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }
    }
}
