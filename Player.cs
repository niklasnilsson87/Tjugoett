using System;
using System.Collections.Generic;

namespace nn222ia_examination_3
{
    class Player
    {
    List<Card> hand = new List<Card>();

    public void TakeCard (Card card)
    {
        hand.Add(card);
    }

    public int SumOfHand ()
    {
        int sum = 0;
        for (int i = 0; i < hand.Count; i++)
        {
          sum += (int)hand[i].GetName() + 2;
          System.Console.WriteLine(hand[i].GetName());
          System.Console.WriteLine((int)hand[i].GetName() + 2);
        }
        return sum;

        // // int[] points;
        // List<int> points = new List<int>();
        // for (int i = 0; i < (int)Card.Name.Count; i++)
        // {
        //     // System.Console.WriteLine(i + 2);
        //     points.Add(i + 2);

        // }
        // System.Console.WriteLine(string.Join(", ", points));

    }

  }
}