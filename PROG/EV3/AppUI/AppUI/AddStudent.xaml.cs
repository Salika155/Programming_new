using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
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
            int age = int.Parse(AgeTextBox.Text);
            string description = DescriptionTextBox.Text;

            // Crear un nuevo estudiante con los valores ingresados
            Student newStudent = new Student(name, age, description);

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
