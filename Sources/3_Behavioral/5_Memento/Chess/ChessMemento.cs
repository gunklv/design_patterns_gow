using System.Collections.Generic;

namespace Chess.Memento
{
    public class ChessMemento
    {
        public Dictionary<(int, int), string> Table { get; set; }
    }
}
