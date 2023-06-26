using Buscaminas;
using BuscaminasBiblio;
using UDK_Test_Release;

namespace BuscaminasApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            UDK.Game.Launch(new MineSweeper());

            Board1 board = new Board1();

            int x = 10;
            int y = 10;
            int bombCount = 10;

            board.CreateBoard(x, y);
            board.Init(x, y, bombCount);
            
            
        }
    }
}