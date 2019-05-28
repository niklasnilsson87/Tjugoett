using System;
using System.Collections.Generic;
using System.Linq;

namespace nn222ia_examination_3
{
  /// <summary>
  /// Representing the card game 21
  /// </summary>
  class Game
  {

    /// <summary>
    /// List object containing the players
    /// </summary>
    /// <typeparam name="Player">Player</typeparam>
    /// <returns>A list of players</returns>
    private List<Player> players = new List<Player>();

    /// <summary>
    /// Holds the number of players
    /// </summary>
    private int _numberOfPlayers;

    /// <summary>
    /// Instanciates a new dealer with name and a limit
    /// </summary>
    /// <returns>A dealer</returns>
    private Dealer dealer = new Dealer("Dealer:", 15);

    /// <summary>
    /// Property used to set the number of players
    /// <exception cref="ArgumentOutOfRangeException">Thrown if value is greater than 30</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if value is less than 1</exception>
    /// </summary>
    /// <value>Received by the constructor</value>
    public int NumberOfPlayers
    {
      get => _numberOfPlayers;
      set
      {
        if (value >= 30)
        {
          throw new ArgumentOutOfRangeException("Too many players.");
        }
        else if (value < 1)
        {
          throw new ArgumentOutOfRangeException("There must be at least 1 player to play.");
        }
        _numberOfPlayers = value;
      }


    }

    /// <summary>
    /// Constructor to set the amount of players
    /// </summary>
    /// <param name="numberOfPlayers">The amount of players</param>
    public Game(int numberOfPlayers)
    {
      NumberOfPlayers = numberOfPlayers;
    }

    /// <summary>
    /// Method to generate players based on the amount of players
    /// </summary>
    public void GeneratePlayers()
    {
      for (int i = 0; i < _numberOfPlayers; i++)
      {
        string name = ($"Player #{i + 1}:");
        Player player = new Player(name, 18);
        players.Add(player);
      }
    }

    /// <summary>
    /// Starting point of the game where it first generates a deck and shuffles it, 
    /// then iterates through each player and calling the rules method
    /// </summary>
    public void StartGame()
    {
      dealer.InstansiateDeck();
      GeneratePlayers();

      for (int i = 0; i < players.Count(); i++)
      {
        Player player = players[i];
        Rules(player);
      }
    }

    /// <summary>
    /// Method that gives players and the dealer cards and checks for conditions 
    /// whenever player or dealer is satisfied or win/loses
    /// </summary>
    /// <param name="player">Players from the List object (Players)</param>
    public void Rules(Player player)
    {
      // Give the player a card if the condition is true
      while (player.ShouldAcceptCard) player.TakeCard(dealer.GiveCard());
      PrintHand(player);

      if (player.Sum < 21 && player.ShowHand.Count() < 5)
      {
        while (dealer.ShouldAcceptCard) dealer.TakeCard(dealer.GiveCard());
        PrintHand(dealer);
      }
      else
      {
        Print.Write($"{dealer.Name} - \n");
      }

      // Logic for determining the winner and loser
      if (player.Sum > dealer.Sum && player.Sum <= 21 ||
          player.ShowHand.Count() >= 5 && player.Sum <= 21 ||
          dealer.Sum > 21)
      {
        Print.WriteLine("Player wins! \n");
      }
      else
      {
        Print.WriteLine("Dealer wins! \n");
      }

      dealer.DiscardPile(player.ThrowCards());
      dealer.DiscardPile(dealer.ThrowCards());
    }

    /// <summary>
    /// Prints the player and dealers cards together with their name and total sum
    /// </summary>
    /// <param name="player">Player or dealer object</param>
    public void PrintHand(Player player)
    {
      Print.Write($"{player.Name}");

      // Print the players hand
      foreach (string card in player.ShowHand)
      {
        Print.Write(card);
      }

      Print.Write(player.Sum > 21 ? $" ({player.Sum}) BUSTED! \n" : $" ({player.Sum}) \n");
    }
  }
}
