using System;
using System.Collections.Generic;
using System.Linq;

namespace HashTableList
{
    public class HashTableList
    {
        List<Tuple<int, List<object>>> HashTable;
        HashTableList(int size)
        {
            HashTable = new List<Tuple<int, List<object>>>(size);
        }
        public void PutPair(object key, object value)
        {
            var khash = key.GetHashCode();
            foreach (var element in HashTable)
            {
                if (element.Item1 == khash)
                {
                    element.Item2.Add(value);
                    return;
                }
            }
            HashTable.Add(Tuple.Create(khash, new List<object> { value }));
        }
        public object GetValueByKey(object key)
        {
            var kluch = key.GetHashCode();
            foreach (var element in HashTable)
            {
                if (element.Item1 == kluch)
                    return element.Item2.Last();
            }
            return null;
        }
    }
}
