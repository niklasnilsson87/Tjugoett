using System;
using System.Collections.Generic;
using System.Linq;

namespace nn222ia_examination_3
{
  class Player
  {
    private List<Card> _hand = new List<Card>();
    public int Sum {
        get {
            var sum = _hand.Sum(c => c.Value);
            if (sum > 21) 
            {
                var count = _hand.Count(v => v.Rank == Rank.Ace);
                while (sum > 21 && count-- > 0)
                {
                    sum-= 13;
                }
            }
            return sum;
        }
    }
    private int Limit { get; }
    public string Name { get; }
    public IEnumerable<string> ShowHand { get => _hand.Select(c => c.ToString()); }
    public bool ShouldAcceptCard { get => Sum < Limit ? true : false; }

    public Player (string name = "Player", int limit = 15)
    {
        Name = name;
        Limit = limit;
    }

    public void TakeCard (Card card)
    {
        _hand.Add(card);
    }
}
}