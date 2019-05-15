using System;

namespace nn222ia_examination_3
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var deck = new Deck();
            deck.GenerateDeck();
            deck.Shuffle();

            var player = new Player("Hans", 15);
            while (player.ShouldAcceptCard) player.TakeCard(deck.DrawCard());

            System.Console.Write($"\n{player.Name}");
            foreach (string card in player.ShowHand)
            {
                System.Console.Write(card);
            }
            System.Console.Write($" ({player.Sum}) \n");


            var dealer = new Dealer("Gummibjörn", 1);
            while (dealer.ShouldAcceptCard) dealer.TakeCard(deck.DrawCard());

            System.Console.Write($"\n{dealer.Name}");
            foreach (var card in dealer.ShowHand)
            {
                System.Console.Write(card);
            }
            System.Console.Write($" ({dealer.Sum}) \n \n");
        }
    }
}
