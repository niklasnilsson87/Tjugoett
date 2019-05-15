using System;
using System.Collections.Generic;
using System.Linq;

namespace nn222ia_examination_3
{
  class Deck
  {
    public List<Card> cards;

    public void GenerateDeck () {
        cards = new List<Card>();

        foreach (var suit in (Suit[]) Enum.GetValues(typeof(Suit)))
        {
            foreach (var rank in (Rank[]) Enum.GetValues(typeof(Rank)))
            {
                cards.Add(new Card(rank, suit));
            }
        }
    }

    public void Shuffle () 
    {
      Random r = new Random();
      var deckCount = cards.Count();
      Card tempValue;
      int randomIndex;

      while (deckCount != 0)
      {
        randomIndex = r.Next(deckCount);
        deckCount -= 1;
        tempValue = cards[deckCount];
        cards[deckCount] = cards[randomIndex];
        cards[randomIndex] = tempValue;
      }
    }

    public Card DrawCard () 
    {
      Card c = cards.ElementAt(0);
      cards.RemoveAt(0);
      return c;
    }
  }
}