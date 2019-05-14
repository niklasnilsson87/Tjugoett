using System;
using System.Collections.Generic;
using System.Linq;

namespace nn222ia_examination_3
{
  class Deck
  {
    public List<Card> cards;

    public void GenerateDeck () 
    {
        cards = new List<Card>();

        for (int s = 0; s < (int)Card.Suit.Count; s++)
        {
          for (int n = 0; n < (int)Card.Name.Count; n++)
          {
              cards.Add(new Card((Card.Name)n, (Card.Suit)s));
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

    public void NewDeck () 
    {
        GenerateDeck();
        Shuffle();
    }

    public Card DrawCard () 
    {
      Card c = cards.ElementAt(0);
      cards.RemoveAt(0);
      return c;
    }
  }
}