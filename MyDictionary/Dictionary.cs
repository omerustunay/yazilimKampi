using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Dictionary<T1, T2>
    {
        T1[] array1;
        T2[] array2;
        public Dictionary()
        {
            array1 = new T1[0];
            array2 = new T2[0];
        }

        public void Add(T1 key1, T2 key2)
        {
            T1[] tempKeys1 = array1;
            T2[] tempKeys2 = array2;
            array1 = new T1[tempKeys1.Length + 1];
            array2 = new T2[tempKeys2.Length + 1];

            for (int i = 0; i < tempKeys1.Length; i++)
            {
                array1[i] = tempKeys1[i];
                array2[i] = tempKeys2[i];
            }
            array1[tempKeys1.Length] = key1;
            array2[tempKeys2.Length] = key2;
        }
        public void Write()
        {
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array2[i] + ":" + array1[i]);
            }
        }
    }
}
