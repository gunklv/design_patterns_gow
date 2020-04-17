using Chess.Memento;

namespace Memento
{
    class Program
    {
        static void Main()
        {
            var game = new ChessGame();
            var savedGames = new SavedGames();

            //playing the game
            //...
            //getting bored

            savedGames.ChessMementos.Add(game.CreateMemento());
            game = null;

            //start playing again

            game = new ChessGame();
            game.RestoreMemento(savedGames.ChessMementos[0]);
        }
    }
}
