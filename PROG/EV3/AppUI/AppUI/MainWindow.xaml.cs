using Model;
using System.Windows;

namespace AppUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _index = 0;

        public long CurrentStudentId
        {
            get
            {
                Student? currentStudent = AppModel.Instance.Database.GetStudentAt(_index);
                return currentStudent != null ? currentStudent.Id : -1; // Devuelve -1 si no hay estudiante actual
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            UpdateStudentDetails();
        }

        private void UpdateStudentDetails()
        {
            Student? currentStudent = AppModel.Instance.Database.GetStudentAt(_index);

            if (currentStudent != null)
            {
                // Mostrar los detalles del estudiante en las cajas de texto correspondientes
                NameTextBox.Text = currentStudent.Name;
                AgeTextBox.Text = currentStudent.Age.ToString();
                DescriptionTextBox.Text = currentStudent.Description;
                StudentNumberTextBox.Text = (_index + 1).ToString(); // Mostrar el número de estudiante actual
            }
            else
            {
                // Limpiar las cajas de texto si no hay estudiantes
                NameTextBox.Text = "";
                AgeTextBox.Text = "";
                DescriptionTextBox.Text = "";
                StudentNumberTextBox.Text = "";
            }
        }


        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (_index < AppModel.Instance.Database.GetStudentCount() - 1)
            {
                _index++;
                UpdateStudentDetails();
            }
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            var addStudentWindow = new AddStudent();
            addStudentWindow.ShowDialog();

        }

        private void DeleteStudentButton_Click(object sender, RoutedEventArgs e)
        {
            Student? currentStudent = AppModel.Instance.Database.GetStudentAt(_index);
            if (currentStudent != null)
            {
                long currentStudentId = currentStudent.Id;

                // Eliminar el estudiante de la base de datos
                AppModel.Instance.Database.RemoveStudent(currentStudentId);

                // Actualizar la ventana principal después de eliminar el estudiante
                UpdateStudentDetails();
            }

        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            if (_index > 0)
            {
                _index--;
                UpdateStudentDetails();
            }

        }

        //private void StudentNumberBox(object sender, System.Windows.Controls.TextChangedEventArgs e)
        //{
        //    Student? currentStudent = AppModel.Instance.Database.GetStudentAt(_index);
        //    currentStudent.Id = long.Parse(StudentNumberTextBox.Text);
        //}
    }
}