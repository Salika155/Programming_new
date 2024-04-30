using Model;
using System.Windows;

namespace AppUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddStudentButton(object sender, RoutedEventArgs e)
        {
            var student = new Student();

            student.Name = MyNameTextBox.Text;
            student.Age = MyAgeTextBox.Text.toInt();
            student.Description = TextBoxDescription.Text;

            AppModel.Instance.Database.AddStudent(student);
            Close();





        //private void OnButtonSave(object sender, RoutedEventArgs e)
        //{
        //    //var student = new Student();
        //    //student.Name = MyNameTextBox.Text;
        //    //student.Age = MyAge.TextBox.toInt();
        //    //student.Description = TextBoxDescription.Text;

        //    //App.Instance.Database.AddStudent(student);
        //    //Close();
        //}
    }
}