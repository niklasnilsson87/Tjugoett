using System;

namespace nn222ia_examination_3
{

  /// <summary>
  /// Represents the different rank values
  /// </summary>
  public enum Rank
  {
    Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
  }

  /// <summary>
  /// Represents the different suit values
  /// </summary>
  public enum Suit
  {
    Hearts = '♥', Clubs = '♠', Diamonds = '♦', Spades = '♣'
  }
  /// <summary>
  /// Represents a card
  /// </summary>
  class Card
  {
    /// <summary>
    /// Auto-implemented get that sets the rank value
    /// </summary>
    /// <value>Received from the constructor</value>
    public Rank Rank { get; }

    /// <summary>
    /// Auto-implemented get that sets the suit value
    /// </summary>
    /// <value>Received from the constructor</value>
    public Suit Suit { get; }

    /// <summary>
    /// Sets the value by using the IEnumerable Rank value
    /// </summary>
    /// <value>Received from the constructor</value>
    public int Value { get => (int)Rank; }


    /// <summary>
    /// Constructor that sets the rank and suit for the card
    /// </summary>
    /// <param name="rank">Rank</param>
    /// <param name="suit">Suit</param>
    public Card(Rank rank, Suit suit)
    {
      Rank = Enum.IsDefined(typeof(Rank), rank) ? rank : throw new ArgumentException(nameof(rank));
      Suit = Enum.IsDefined(typeof(Suit), suit) ? suit : throw new ArgumentException(nameof(suit));
    }

    /// <summary>
    /// Overrides the default ToString method
    /// </summary>
    /// <returns>The card in one line with suit, rank and value</returns>

    public override string ToString()
    {
      return $" {(Value > 1 & Value < 11 ? Value.ToString() : Rank.ToString().Substring(0, 1))}{(char)Suit}";
    }
  }
}
