using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class Storage<T> : IEnumerable<T>
    {
        public List<T> _list = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            return new StorageEnumerator<T>(_list);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new StorageEnumerator<T>(_list);
        }
    }

    public class StorageEnumerator<T> : IEnumerator<T>
    {
        private List<T> _list;

        public StorageEnumerator(List<T> list)
        {
            _list = list;
        }

        private int _currentIndex = -1;

        public T Current => _list[_currentIndex];

        object IEnumerator.Current => _list[_currentIndex];

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if(_currentIndex < _list.Count-1)
            {
                _currentIndex++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _currentIndex = 0;
        }
    }
}
