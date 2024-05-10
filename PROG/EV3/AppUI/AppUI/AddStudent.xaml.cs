using System.Windows;
using System.Windows.Controls;
using Model;

namespace AppUI
{
    /// <summary>
    /// Lógica de interacción para AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
        }


        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            
            string name = NameTextBox.Text;
            int ageText = int.Parse(AgeTextBox.Text);
            string description = DescriptionTextBox.Text;

            // Crear un nuevo estudiante con los valores ingresados
            Student newStudent = new Student(name, ageText, description);

            // Agregar el estudiante a la base de datos
            AppModel.Instance.Database.AddStudent(newStudent);

            // Cerrar la ventana
            this.Close();

        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string name = NameTextBox.Text;


        }

        private void AgeTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            string age = AgeTextBox.Text;

        }

        private void DescriptionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string description = DescriptionTextBox.Text;

        }
    }
}
