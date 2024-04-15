using System.Windows;


namespace MiPrimerWPF
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Botón apretado");
            bool? state = CheckboxMain.IsChecked.Value;
            CheckboxMain.IsChecked = !state;

            this.ButtonMain.Content += "0";
        }

        private void OnMainClick(object sender, RoutedEventArgs e)
        {

        }

        //private void OnCheck(object sender, RoutedEventArgs e)
        //{
        //    bool? state = CheckboxMain.IsChecked.Value;
        //    CheckboxMain.IsChecked = !state; 
        //}
    }
}
