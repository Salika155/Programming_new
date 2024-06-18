using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPF_BacklogData.Models;




namespace WPF_BacklogApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ISGameListener
    {
        private ObservableCollection<Game> _games;
        public static User? AppUser { get; set; }
        public int GameCount { get; set; }


        public MainWindow(User user)
        {
            InitializeComponent();
            AppUser = user;
            DataContext = AppUser;

            _games = new ObservableCollection<Game>(DatabaseSQL.Instance.LoadGamesFromDatabase());

            //// Inicializar y cargar la lista de juegos
            //_games = new ObservableCollection<Game>
            //{
            //    new Game() { ID = 0, Name = "The Legend Of Zelda", Img = "https://img.asmedia.epimg.net/resizer/v2/KUYWWFPNXVHSNH5IOUFD3NC22E.jpg?auth=611cfe3f84263d1fc2a947a7c723b6336e0df65d2be43aeff13f024fe578bed8" },
            //    new Game() { ID = 1, Name = "Trails Of Cold Steel", Img = "https://img.asmedia.epimg.net/resizer/v2/KUYWWFPNXVHSNH5IOUFD3NC22E.jpg?auth=611cfe3f84263d1fc2a947a7c723b6336e0df65d2be43aeff13f024fe578bed8" },
            //    new Game() { ID = 2, Name = "YS IX Monstrum Nox", Img = "https://img.asmedia.epimg.net/resizer/v2/KUYWWFPNXVHSNH5IOUFD3NC22E.jpg?auth=611cfe3f84263d1fc2a947a7c723b6336e0df65d2be43aeff13f024fe578bed8" },
            //    new Game() { ID = 3, Name = "Pokemon Esmeralda", Img = "https://img.asmedia.epimg.net/resizer/v2/KUYWWFPNXVHSNH5IOUFD3NC22E.jpg?auth=611cfe3f84263d1fc2a947a7c723b6336e0df65d2be43aeff13f024fe578bed8" },
            //    new Game() { ID = 4, Name = "Fire Emblem", Img = "https://img.asmedia.epimg.net/resizer/v2/KUYWWFPNXVHSNH5IOUFD3NC22E.jpg?auth=611cfe3f84263d1fc2a947a7c723b6336e0df65d2be43aeff13f024fe578bed8" },
            //    new Game() { ID = 5, Name = "Dragon Quest VII", Img = "https://img.asmedia.epimg.net/resizer/v2/KUYWWFPNXVHSNH5IOUFD3NC22E.jpg?auth=611cfe3f84263d1fc2a947a7c723b6336e0df65d2be43aeff13f024fe578bed8" }
            //};

            GameCount = _games.Count;
            ItemsPool.ItemsSource = _games;
        }

        public int GetGameCount()
        {
            try
            {
                return _games.Count;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo obtener el número de juegos.", ex);
            }
        }

        //todo: esto es lo que falla
        private void AddGame_Click(object sender, RoutedEventArgs e)
        {
            AddRemoveGameWindow addGameWindow = new AddRemoveGameWindow();
            addGameWindow.ShowDialog();
        }


        private void RemoveGame_Click(object sender, RoutedEventArgs e)
        {
            AddRemoveGameWindow removeGameWindow = new AddRemoveGameWindow();
            removeGameWindow.ShowDialog();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        public void OnStudentSelected(Game game) => _games = AppUser.Games;

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }

        private void FiltGameByState(object sender, RoutedEventArgs e)
        {

        }

        private void FilterGameByState(object sender, RoutedEventArgs e)
        {

        }

    }
}