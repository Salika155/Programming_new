namespace nuncopy_definitivo
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileUnifier fileUnifier = new FileUnifier();

            //como no he conseguido aplicarselo por json se los paso directamente, pero es una decision temporal
            string[] inputDirectories = new string[] { "C:\\Users\\carre\\Desktop\\Brandon Sanderson", "C:\\Users\\carre\\Desktop\\carpeta_origen",
            "C:\\Users\\carre\\Desktop\\carpeta_destino" };

            AppRunner.RunApp(inputDirectories);
        }
    }
}
