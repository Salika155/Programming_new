
using System.Windows;
using System.Windows.Controls;
using WPF_BacklogData.Models;


namespace WPF_BacklogApp
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Replace this with your actual login logic
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;

            User currentUser = new User
            {
                ID = 1,
                Name = "User 1",
                Email = "a@hotmail.com",
                Password = "ab",
                Image = "https://img.asmedia.epimg.net/resizer/v2/KUYWWFPNXVHSNH5IOUFD3NC22E.jpg?auth=611cfe3f84263d1fc2a947a7c723b6336e0df65d2be43aeff13f024fe578bed8",
                TotalGames = 6
            };

            if (IsLoginValid(currentUser, email, password))
            {
                MainWindow mainWindow = new MainWindow(currentUser);
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectas.");
            }
        }

        private static bool IsLoginValid(User user, string email, string password)
        {
            return user != null && email == user.Email && password == user.Password;
        }
    }
}
