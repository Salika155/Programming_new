using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using WPF_BacklogData.Models;


namespace WPF_BacklogApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ISGameListener
    {
        ObservableCollection<Game> _games = new ObservableCollection<Game>();
        Game? _gamesCollectables;

        private User _currentUser;
        //public User CurrentUser
        //{
        //    get => _currentUser;
        //    set
        //    {
        //        _currentUser = value;

        //    }
        //}

        

        public MainWindow()
        {
            InitializeComponent();

            Game game = new Game();
            game.Name = "Roberto";
            game.Img = "https://img.asmedia.epimg.net/resizer/v2/KUYWWFPNXVHSNH5IOUFD3NC22E.jpg?auth=611cfe3f84263d1fc2a947a7c723b6336e0df65d2be43aeff13f024fe578bed8";
            this.DataContext = game;

            //aqui se debera cargar la lista de juegos
            _games.Add(new Game() { ID = 0, Name = "Roberto1", Img = "https://img.asmedia.epimg.net/resizer/v2/KUYWWFPNXVHSNH5IOUFD3NC22E.jpg?auth=611cfe3f84263d1fc2a947a7c723b6336e0df65d2be43aeff13f024fe578bed8"});
            _games.Add(new Game() { ID = 1, Name = "Roberto2", Img = "https://img.asmedia.epimg.net/resizer/v2/KUYWWFPNXVHSNH5IOUFD3NC22E.jpg?auth=611cfe3f84263d1fc2a947a7c723b6336e0df65d2be43aeff13f024fe578bed8" });
            _games.Add(new Game() { ID = 2, Name = "Roberto3", Img = "https://img.asmedia.epimg.net/resizer/v2/KUYWWFPNXVHSNH5IOUFD3NC22E.jpg?auth=611cfe3f84263d1fc2a947a7c723b6336e0df65d2be43aeff13f024fe578bed8" });

            ItemsPool.ItemsSource = _games;
        }

        private void AddGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddRemoveGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveGame_Click(object sender, RoutedEventArgs e)
        {

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

        public void OnStudentSelected(Game game)
        {
            _gamesCollectables = game;

        }


        //public MainWindow()
        //{
        //    InitializeComponent();
        //}

        //public MainWindow(User user)
        //{
        //    User = user;
        //}

        //public User User { get; }
    }
}