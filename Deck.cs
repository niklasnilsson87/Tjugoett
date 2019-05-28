using System;
using System.Collections.Generic;
using System.Linq;

namespace nn222ia_examination_3
{
  /// <summary>
  /// Representing a deck of cards
  /// </summary>
  class Deck
  {
    /// <summary>
    /// Represents a list object containing cards
    /// </summary>
    /// <typeparam name="Card">Card</typeparam>
    /// <returns>Cards</returns>
    private List<Card> _cards = new List<Card>();

    /// <summary>
    /// Preventing the card list to be manipulated
    /// </summary>
    /// <returns>A readonly list containing the cards</returns>
    public IReadOnlyList<Card> Cards => _cards.AsReadOnly();

    /// <summary>
    /// Loops through and creates cards from the available different values, 
    /// then adds it to the cards list
    /// </summary>
    public void GenerateDeck()
    {
      _cards = new List<Card>(52);

      foreach (var suit in (Suit[])Enum.GetValues(typeof(Suit)))
      {
        foreach (var rank in (Rank[])Enum.GetValues(typeof(Rank)))
        {
          _cards.Add(new Card(rank, suit));
        }
      }
    }

    /// <summary>
    /// Shuffles the card list
    /// </summary>
    public void Shuffle()
    {
      Random r = new Random();
      var deckCount = _cards.Count();
      Card tempValue;
      int randomIndex;

      while (deckCount != 0)
      {
        randomIndex = r.Next(deckCount);
        deckCount -= 1;
        tempValue = _cards[deckCount];
        _cards[deckCount] = _cards[randomIndex];
        _cards[randomIndex] = tempValue;
      }
    }
  }
}
