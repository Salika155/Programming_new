using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_BacklogApp
{
    /// <summary>
    /// Lógica de interacción para AddRemoveGameWindow.xaml
    /// </summary>
    public partial class AddRemoveGameWindow : Window
    {
        public AddRemoveGameWindow()
        {
            InitializeComponent();
        }

        private void AddGame_Click(object sender, RoutedEventArgs e)
        {
            string gameName = GameNameTextBox.Text;
            if (!string.IsNullOrEmpty(gameName))
            {
                MessageBox.Show($"Juego '{gameName}' añadido con éxito.");
                // Aquí puedes actualizar la lista de juegos en MainWindow
            }
            else
            {
                MessageBox.Show("Necesitas introducir un nombre de juego válido.");
            }

        }

        private void RemoveGame_Click(object sender, RoutedEventArgs e)
        {
            string gameName = GameNameTextBox.Text;
            if (!string.IsNullOrEmpty(gameName))
            {
                MessageBox.Show($"Juego '{gameName}' removido con éxito.");
                // Aquí puedes actualizar la lista de juegos en MainWindow
            }
            else
            {
                MessageBox.Show("Necesitas introducir un nombre de juego válido.");
            }
        }
    }
}
