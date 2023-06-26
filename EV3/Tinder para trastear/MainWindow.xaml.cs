using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Tinder
{
   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<User> u;
        ObservableCollection<User> user = new ObservableCollection<User>();
        

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                user.Add(new User()
                {
                    Id = i,
                    Name = "",
                    Description = "",
                    Age = 22,
                    Gender = "",
                    Photo = "",
                    Rating = 0

                }) ;
            }
            ListViewUsers.ItemsSource = user;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            User p = (User)b.DataContext;
            //MessageBox.Show(p.Description);
            user.Add(new User()
            {
                Name = "Gian",
                Description = "Franco"
            });
        }



        //Grid myGrid = new Grid();

        //this.Content = myGrid;

        //Button mybutton = new Button();

        //WrapPanel myWrapP = new WrapPanel();

        //TextBlock txt1 = new TextBlock();
    }
}

