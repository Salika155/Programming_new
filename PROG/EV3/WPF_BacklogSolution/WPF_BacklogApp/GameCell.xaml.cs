
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

        public void GameCellClick(object sender, RoutedEventArgs e)
        {
            var game = DataContext as Game;
            if (game != null)
            {
                GameDetailsWindow detailsWindow = new GameDetailsWindow(game);
                if (detailsWindow.ShowDialog()== true)
                {

                }
            }
        }
    }
}
