using System;
using System.Collections.Generic;

namespace Metoder_opgave_8
{

    class Program

    {

        static void Main(string[] args)

        {

            List<int> listeB = new List<int>();

            for (int i = 2; i <= 20; i += 2)
            {
                listeB.Add(i);
            }
            listeB = RemoveNumbers(listeB);

            int listeCount = listeB.Count;

            listeB.Insert(2, 17);

            List<int> listeA = new List<int>();

            listeA = listeB;

            listeA.Reverse();

        }
        public static List<int> RemoveNumbers(List<int> a)
        {
            for (int i = 0; i < a.Count; i++)
                if (i % 3 == 0)
                    a.RemoveAt(i);
            return a;
        }
}

}
