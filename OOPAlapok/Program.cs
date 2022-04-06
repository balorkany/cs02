using System;
using System.Collections.Generic;

namespace OOPAlapok
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Szemely> szemelyek = new List<Szemely>()
            {
                new Szemely("Pipoly Ivett"),
                new Szemely("Nagy Béla"),
                new Szemely("Kiss Géza")
            };


            Szemely sz = new Szemely();

            Console.WriteLine($"{sz.Csaladnev} {sz.Vezeteknev}");
            Console.WriteLine(sz.TeljesNev);

            Console.WriteLine(sz.Csaladnev);
            

            Szemely sz2 = null;

            foreach (Szemely szemely in szemelyek)
            {
                Console.WriteLine(szemely);
            }

            Console.WriteLine(Szemely.Nagybetusse("ertertre"));
            

        }


    }



}
