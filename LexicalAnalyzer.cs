using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HackerEarth.Strings
{
    class LexicalAnalyzer
    {
        public static void main()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            Hashtable hashtable = new Hashtable();
            int counter = 0;
            //Read data and add into hash table
            for (int i = 0; i < N; i++)
            {
                var tmp = Console.ReadLine().Split('=');

                if (!hashtable.ContainsKey(tmp[0]))
                {
                    hashtable.Add(tmp[0], tmp[1]);
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
