using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_BacklogData.Interfaces;
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
        public User CurrentUser
        {
            get => _currentUser;
            set
            {
                _currentUser = value;

            }
        }

        

        public MainWindow()
        {
            InitializeComponent();

            //aqui se debera cargar la lista de juegos
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