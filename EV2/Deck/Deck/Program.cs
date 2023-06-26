namespace Deck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            deck.AddCard(1, SuitCard.CUP);
            deck.AddCard(2, SuitCard.GOLD);
            deck.AddCard(3, SuitCard.SWORD);
            deck.AddCard(4, SuitCard.STICK);

            int cardCount = deck.cardCount;
            Console.WriteLine("Número total de cartas: " + cardCount);

            int numCard = 1;
            deck.RemoveCard(numCard);
            Console.WriteLine("Número de la carta: " + numCard);

            
            Console.WriteLine("Número total de cartas: " + cardCount);




        }
    }
}