namespace PokerCards
{
    public class Program
    {
        static void Main(string[] args)
        {
            Card card = new (54, Palo.TREBOLES);
            Console.WriteLine(card.GetFigureType());
            Console.WriteLine(card.IsFigure() + " " + card.IsValid());


        }
    }
}