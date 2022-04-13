using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritanceAlapok
{
    public class Negyzet : Negyszog, ITerulettelRendelkezik
    {
        public double OldalHossz;
        public Negyzet(Pont p1, Pont p2, Pont p3, Pont p4) : base(p1, p2, p3, p4)
        {
            this.OldalHossz = this.P1.Tavolsag(this.P2);
        }

        public Negyzet(double oldalHossz) :
            this(
                new Pont(0, 0),
                new Pont(0, oldalHossz),
                new Pont(oldalHossz, oldalHossz),
                new Pont(oldalHossz, 0)
                )
        {
            this.OldalHossz = oldalHossz;
        }

        public Negyzet() : base() { }

        public double Terulet() => Math.Pow(this.OldalHossz, 2);




    }
}
