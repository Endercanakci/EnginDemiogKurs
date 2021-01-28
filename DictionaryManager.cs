using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class DictionaryManager<K, V>
    {
        K[] keys;
        V[] values;

        public DictionaryManager()
        {
            keys = new K[0];
            values = new V[0];
        }
        public void Add(K key, V value)
        {
            K[] tempArrayKeys = keys;
            V[] tempArrayValues = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempArrayKeys.Length; i++)
            {
                keys[i] = tempArrayKeys[i];
            }
            keys[keys.Length - 1] = key;

            for (int a = 0; a < tempArrayValues.Length; a++)
            {
                values[a] = tempArrayValues[a];
            }
            values[values.Length - 1] = value;
        }
        public void Show()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " = " + values[i]);
            }
        }
    }
}