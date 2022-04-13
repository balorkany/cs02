using System;

namespace EnumAlapok
{
    class Program
    {
        static void Main(string[] args)
        {
            Evszakok evszak = (Evszakok)2;
            Console.WriteLine(evszak);

            switch (evszak)
            {
                case Evszakok.Nyar:
                    Console.WriteLine(Evszakok.Nyar);
                    break;

                case Evszakok.Tavasz:
                    Console.WriteLine(Evszakok.Tavasz);
                    break;

                case Evszakok.Osz:
                    Console.WriteLine(Evszakok.Osz);
                    break;

                case Evszakok.Tel:
                    Console.WriteLine(Evszakok.Tel);
                    break;

                default:
                    Console.WriteLine("Egyik sem..");
                    break;
            }
        }


    }

    enum Evszakok
    {
        Tavasz = 7,
        Nyar = 2,
        Osz = 4,
        Tel = 899
    }

}
