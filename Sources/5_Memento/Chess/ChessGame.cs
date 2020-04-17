using System.Collections.Generic;

namespace Chess.Memento
{
    public class ChessGame
    {
        private Dictionary<(int, int), string> Table = new Dictionary<(int, int), string>();

        public ChessMemento CreateMemento()
        {
            return new ChessMemento { Table = Table };
        }

        public void RestoreMemento(ChessMemento memento)
        {
            Table = memento.Table;
        }
    }
}
