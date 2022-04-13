using System;

namespace StructAlapok
{
    class Program
    {
        static void Main(string[] args)
        {
            Pont p1 = new Pont(0, 1);
            Pont p2 = new Pont(0, 12);

            p2 = p1;

            p1.X = -1;

            Console.WriteLine(p2);

            Console.WriteLine(p1.Tavolsag(p2));
        }
    }

    public struct Pont
    {
        public double X;
        public double Y;

        public Pont(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"({this.X}, {this.Y})";
        }

        public double Tavolsag(Pont masikPont) =>
            Math.Sqrt(Math.Pow(this.X - masikPont.X, 2) + Math.Pow(this.Y - masikPont.Y, 2));
    }
}
