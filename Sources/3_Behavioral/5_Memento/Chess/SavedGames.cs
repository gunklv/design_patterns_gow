using System.Collections.Generic;

namespace Chess.Memento
{
    public class SavedGames
    {
        public List<ChessMemento> ChessMementos { get; set; } = new List<ChessMemento>();
    }
}
