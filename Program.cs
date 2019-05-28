using System;

namespace nn222ia_examination_3
{
  /// <summary>
  /// Program that initializes the card game 21
  /// </summary>
  class Program
  {
    /// <summary>
    /// The starting point of the application
    /// </summary>
    static void Main()
    {
      Console.OutputEncoding = System.Text.Encoding.UTF8;
      try
      {
        Game game = new Game(5);
        game.StartGame();
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}
