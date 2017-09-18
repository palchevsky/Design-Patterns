using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Observer
{
    public class Number : IEnumerable<int>
    {
        private int[] _items = new int[0];

        public Number(params int[] items)
        {
            Array.Resize(ref _items, _items.Length + items.Length);
            items.CopyTo(_items, 0);
        }

        public void AddItem(int item)
        {
            Array.Resize(ref _items, _items.Length + 1);
            _items[_items.Length - 1] = item;
            Sort();
        }
        //удаление элемента по Индексу 
        public void RemoveItem(int index)
        {
            var tmpList=_items.ToList();
            if (index>=0 && index<_items.Length)
            { tmpList.RemoveAt(index); }
            else
            { return; }
            _items = tmpList.ToArray();
        }

        public int GetItem(int index)
        {
            return _items[index];
        }

        public void Sort()
        {
            for (int i = 0; i < _items.Length - 1; i++)
            {
                for (int j = i + 1; j < _items.Length; j++)
                {
                    if (_items[i]> _items[j])
                    {
                        var temp = _items[i];
                        _items[i] = _items[j];
                        _items[j] = temp;
                    }
                }
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return item;
            }
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
