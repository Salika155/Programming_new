
using System.Windows;
using System.Windows.Controls;
using WPF_BacklogData.Models;



namespace WPF_BacklogApp
{
    /// <summary>
    /// Lógica de interacción para GameCell.xaml
    /// </summary>
    public partial class GameCell : UserControl
    {
        public GameCell()
        {
            InitializeComponent();
        }

        private void DetailsGameClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Game game)
            {
                GameDetailsWindow detailsWindow = new GameDetailsWindow(game);
                if (detailsWindow.ShowDialog() == true)
                {

                }
            }
        }

    }
}
