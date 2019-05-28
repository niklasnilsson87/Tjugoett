using System;
using System.Collections.Generic;
using System.Linq;

namespace nn222ia_examination_3
{

  /// <summary>
  /// Inherits from player
  /// </summary>
  class Dealer : Player
  {
    /// <summary>
    /// Represents a list of the cards in the deck
    /// </summary>
    private List<Card> _cards;

    /// <summary>
    /// Represents a list of the cards in the discard pile
    /// </summary>
    /// <typeparam name="Card">Card</typeparam>
    /// <returns>A list object containg the cards</returns>
    private List<Card> _trashCards = new List<Card>(51);

    /// <summary>
    /// Instanciates a new deck of cards
    /// </summary>
    /// <returns>A deck object</returns>
    private Deck _deck = new Deck();

    /// <summary>
    /// Constructor that sets the name and limit of the dealer
    /// </summary>
    /// <param name="name">Name</param>
    /// <param name="limit">Limit</param>
    public Dealer(string name = "Dealer:", int limit = 10)
    : base(name, limit)
    {

    }


    /// <summary>
    /// Method to create and shuffle a deck
    /// </summary>
    public void InstansiateDeck()
    {
      _deck.GenerateDeck();
      _deck.Shuffle();
      _cards = new List<Card>(_deck.Cards);
    }

    /// <summary>
    /// Method to assign a card to the player
    /// </summary>
    /// <returns></returns>
    public Card GiveCard()
    {
      if (_cards.Count() <= 1)
      {
        foreach (var card in _trashCards)
        {
          _cards.Add(card);
        }
        _deck.Shuffle();
      }

      Card c = _cards.First();
      _cards.Remove(c);
      return c;
    }

    /// <summary>
    /// Takes all cards and puts them in the trash pile List object
    /// </summary>
    /// <param name="cards">Cards</param>
    public void TrashPile(IEnumerable<Card> cards)
    {
      _trashCards.AddRange(cards);
    }
  }
}
