using System;

namespace nn222ia_examination_3
{
  class Card
  {
    public enum Name 
    {
    Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Knight, Queen, King, Ace, Count,
    }
    public enum Suit 
    {
  Hearts, Clubs, Diamonds, Spades, Count
    }
    Name _name;
    Suit _suit;

    public Card (Name name, Suit suit)
    {
        _name = name;
        _suit = suit;
    }

    public Suit GetSuit ()
    {
        return _suit;
    }

    public Name GetName ()
    {
        return _name;
    }

    public string GetValues ()
    {
        return $"{_suit} {_name}";
    }
  }
}