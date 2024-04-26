namespace nuncopy_definitivo
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileUnifier fileUnifier = new FileUnifier();

            // Define los directorios de entrada y salida directamente en el código
            string[] inputDirectories = new string[] { "C:\\Users\\carre\\Desktop\\Brandon Sanderson", "C:\\Users\\carre\\Desktop\\carpeta_origen" };
            string outputDirectory = "C:\\Users\\carre\\Desktop\\carpeta_destino";

            // Establece los directorios en el FileUnifier

           
            AppRunner.RunApp(inputDirectories);
        }
    }
}
