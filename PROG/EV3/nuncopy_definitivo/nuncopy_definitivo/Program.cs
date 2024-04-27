namespace nuncopy_definitivo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Environment.ExitCode = 0;

            FileUnifier fileUnifier = new FileUnifier();

            //como no he conseguido aplicarselo por json se los paso directamente, pero es una decision temporal
            // Define los directorios de entrada y salida directamente en el código
            string[] inputDirectories = new string[] { "C:\\Users\\carre\\Desktop\\Brandon Sanderson", "C:\\Users\\carre\\Desktop\\carpeta_origen" , 
                "C:\\Users\\carre\\Desktop\\carpeta_destino" };
            //string outputDirectory = "C:\\Users\\carre\\Desktop\\carpeta_destino";

            // Establece los directorios en el FileUnifier

            AppRunner.RunApp(inputDirectories);
        }
    }
}
