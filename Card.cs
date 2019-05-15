using System;

namespace nn222ia_examination_3
{
      public enum Rank 
    {
    Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace, Count,
    }
    public enum Suit
    {
    Hearts = '♥', Clubs = '♠', Diamonds = '♦', Spades = '♣', Count
    }
  class Card
  {
    public Rank Rank {get;}
    public Suit Suit {get;}
    public int Value {get => (int)Rank;}

    public Card (Rank rank, Suit suit)
    {
      Rank = rank;
      Suit = suit;
    }

    public override string ToString ()
    {
        return $" {Value}{(char)Suit}";
    }
  }
}