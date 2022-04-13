using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritanceAlapok
{
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
