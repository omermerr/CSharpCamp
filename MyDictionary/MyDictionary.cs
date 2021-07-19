using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;


        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];

        }
        public void Add(K k,V v)
        {
            K[] key = keys;
            V[] value = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < key.Length; i++)
            {
                keys[i] = key[i];
            }

            keys[keys.Length - 1] = k;

            for (int i = 0; i < value.Length; i++)
            {
                values[i] = value[i];
            }
            values[values.Length - 1] = v; 
        }
       public int Lenght
        {
            get { return keys.Length; }
        }
    }
}
