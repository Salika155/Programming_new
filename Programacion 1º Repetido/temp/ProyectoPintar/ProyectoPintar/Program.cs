using System.Security.Cryptography.X509Certificates;
using UDK;


namespace ProyectoPintar
{
    //si es metodo de juego existen this dentro, en este caso de mijuego
    internal class Program
    {
        static void Main(string[] args)
        {
            MyGame juego = new MyGame();
            UDK.Game.Launch(juego);
            
            //creo una clase llamada mundo para meter a los personajes
            //mundo va a tener una lista de objetos -> tendra funcion crearpersonajes y draw personajes
            //crear clases fuera clase character, world, y mijuego
        }
    }
}