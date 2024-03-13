namespace DominoSimulacro
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Juego juego = new Juego();

            juego._participantes = new List<Participante>
            {
                new Impulsivo(),
                new Conservador(),
                new Conservador(),
                new Impulsivo()
            };

            Monto montofichas = new Monto();

            montofichas.Shuffle();



            //Ficha ficha = new Ficha();
            //ficha.SetN1(1);
            //ficha.SetN2(2);

            //Console.WriteLine(ficha.GetN1());   
            //Console.WriteLine(ficha.GetN2());
            

            //Console.WriteLine(ficha.GetFicha());
        }
    }
}