using System.Collections.ObjectModel;
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
        public static User? AppUser { get; private set; }
        private ObservableCollection<Game> _games;
        //    OnPropertyChanged(nameof(CurrentUser)
        //);
    

        public MainWindow(User user)
        {
            InitializeComponent();
            AppUser = user;
            DataContext = AppUser;

            // Inicializar y cargar la lista de juegos
            _games = new ObservableCollection<Game>
            {
                new Game() { ID = 0, Name = "The Legend Of Zelda", Img = "https://img.asmedia.epimg.net/resizer/v2/KUYWWFPNXVHSNH5IOUFD3NC22E.jpg?auth=611cfe3f84263d1fc2a947a7c723b6336e0df65d2be43aeff13f024fe578bed8" },
                new Game() { ID = 1, Name = "Trails Of Cold Steel", Img = "https://img.asmedia.epimg.net/resizer/v2/KUYWWFPNXVHSNH5IOUFD3NC22E.jpg?auth=611cfe3f84263d1fc2a947a7c723b6336e0df65d2be43aeff13f024fe578bed8" },
                new Game() { ID = 2, Name = "YS IX Monstrum Nox", Img = "https://img.asmedia.epimg.net/resizer/v2/KUYWWFPNXVHSNH5IOUFD3NC22E.jpg?auth=611cfe3f84263d1fc2a947a7c723b6336e0df65d2be43aeff13f024fe578bed8" },
                new Game() { ID = 3, Name = "Pokemon Esmeralda", Img = "https://img.asmedia.epimg.net/resizer/v2/KUYWWFPNXVHSNH5IOUFD3NC22E.jpg?auth=611cfe3f84263d1fc2a947a7c723b6336e0df65d2be43aeff13f024fe578bed8" },
                new Game() { ID = 4, Name = "Fire Emblem", Img = "https://img.asmedia.epimg.net/resizer/v2/KUYWWFPNXVHSNH5IOUFD3NC22E.jpg?auth=611cfe3f84263d1fc2a947a7c723b6336e0df65d2be43aeff13f024fe578bed8" },
                new Game() { ID = 5, Name = "Dragon Quest VII", Img = "https://img.asmedia.epimg.net/resizer/v2/KUYWWFPNXVHSNH5IOUFD3NC22E.jpg?auth=611cfe3f84263d1fc2a947a7c723b6336e0df65d2be43aeff13f024fe578bed8" }
            };

            ItemsPool.ItemsSource = _games;
        }

        

        private void AddGame_Click(object sender, RoutedEventArgs e)
        {
            AddRemoveGameWindow addGameWindow = new AddRemoveGameWindow();
            addGameWindow.ShowDialog();

            //_games = new ObservableCollection<Game>
            //{
            //    new Game() { ID = }
            //};
            //ItemsPool.ItemsSource = _games;

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