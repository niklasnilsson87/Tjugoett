using System;

namespace nn222ia_examination_3
{
    class Program
    {
    static void Main(string[] args)
    {
        var deck = new Deck();
        deck.GenerateDeck();
        deck.Shuffle();
        // for (int i = 0; i < 2; i++)
        // {
        //     System.Console.WriteLine(deck.DrawCard().GetValues());
        // }

        var player = new Player();
        player.TakeCard(deck.DrawCard());
        player.TakeCard(deck.DrawCard());
        System.Console.WriteLine(player.SumOfHand());
    }
    }
}
