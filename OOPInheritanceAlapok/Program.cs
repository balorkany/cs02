using System;
using System.Collections.Generic;

namespace OOPInheritanceAlapok
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITerulettelRendelkezik> alakzatok = new List<ITerulettelRendelkezik>();

            Negyzet n = new Negyzet(10);
            Teglalap t = new Teglalap(10, 20);

            if (t is Negyszog)
            {
                Console.WriteLine("igaz");
            }

            Negyszog negyszog = t as Negyszog;

            alakzatok.Add(n);
            alakzatok.Add(t);

            Kor k = new Kor(new Pont(0, 12), 12);
            alakzatok.Add(k);

            foreach (var alak in alakzatok)
            {
                Console.WriteLine(alak.Terulet());
                Console.WriteLine(alak.Kerulet());
            }
            //Console.WriteLine(t.Kerulet());
        }
    }
}
