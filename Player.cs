using System;
using System.Collections.Generic;
using System.Linq;

namespace nn222ia_examination_3
{
  /// <summary>
  /// Creates an instance of a player
  /// </summary>
  class Player
  {
    /// <summary>
    /// Represents the players hand
    /// </summary>
    /// <typeparam name="Card">Card</typeparam>
    /// <returns>A list object containg the players hand</returns>
    private List<Card> _hand = new List<Card>();

    /// <summary>
    /// Property that sets the sum of the players hand
    /// </summary>
    public int Sum
    {
      get
      {
        var sum = _hand.Sum(c => c.Value);
        if (sum > 21)
        {
          var count = _hand.Count(v => v.Rank == Rank.Ace);
          while (sum > 21 && count-- > 0)
          {
            sum -= 13;
          }
        }
        return sum;
      }
    }

    /// <summary>
    /// Sets the limit
    /// </summary>
    /// <value>Received from the constructor</value>
    private int Limit { get; }

    /// <summary>
    /// Sets the name
    /// </summary>
    /// <value>Received from the constructor</value>
    public string Name { get; }

    /// <summary>
    /// Property used to show the hand
    /// </summary>
    /// <returns>all cards in the hand as a string</returns>
    public IEnumerable<string> ShowHand { get => _hand.Select(c => c.ToString()); }

    /// <summary>
    /// Boolean that determines whether the player should take a card
    /// </summary>
    public bool ShouldAcceptCard { get => Sum < Limit ? true : false; }

    /// <summary>
    /// Constructor that sets the name and limit
    /// </summary>
    /// <param name="name">The players name</param>
    /// <param name="limit">The players limit</param>
    public Player(string name = "Player", int limit = 15)
    {
      Name = name;
      Limit = limit;
    }

    /// <summary>
    /// Takes a given card and adds it into the hand List object
    /// </summary>
    /// <param name="card">The card to add</param>
    public void TakeCard(Card card)
    {
      _hand.Add(card);
    }

    /// <summary>
    /// Removes all cards from the players hand, and adds it to the trash list
    /// </summary>
    /// <returns>All cards from players hand</returns>
    public IEnumerable<Card> ThrowCards()
    {
      IEnumerable<Card> trashCards = _hand.ToList();
      _hand.Clear();
      return trashCards;
    }
  }
}
