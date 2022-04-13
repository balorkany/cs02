using System;
using StringExtensions;
using System.Linq;

namespace ExtensionAlapok
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Ez egy mondat.";

            Console.WriteLine(StringExtension.SzavakSzama(str));
            Console.WriteLine(str.SzavakSzama());
        }

    }

   


}
