using System;
using System.Collections;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(15) { 1, 34, 'f', 4, 'c', 'D', 7, 5, 16, 'A','k', 0, 9, 'L', 'p' };
            int k = 0;
            ArrayList list2 = new ArrayList(new char[k]);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is char)
                {
                    list2.Add(list[i]);
                    list.RemoveAt(i);
                    k++;
                }
                if (list[i] is char)
                {
                    list2.Add(list[i]);
                    list.RemoveAt(i);
                    k++;
                }
            }
            char[] c = new char[k];
            list2.CopyTo(c);
            for (int i = 0; i < list2.Count; i++)
            {
                list2.RemoveAt(i);
                if (char.IsUpper(c[i]))
                {
                    list2.Add(c[i]); 
                }   
            }
            list2.RemoveAt(0);
            foreach (object o in list)
            { 
                Console.Write(o + " "); 
            }
            Console.WriteLine();
            foreach (object o in list2)
            {
                Console.Write(o + " ");
            }
        }
    }
}
