using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritanceAlapok
{
    public class Teglalap : Negyszog, ITerulettelRendelkezik
    {
        public double RovidOldalHossz;
        public double HosszuOldalHossz;

        public Teglalap(Pont p1, Pont p2, Pont p3, Pont p4) : base(p1, p2, p3, p4)
        {
            this.RovidOldalHossz = this.P1.Tavolsag(this.P2);
            this.HosszuOldalHossz = this.P2.Tavolsag(this.P3);
        }

        public Teglalap(double rovidOldalHossz, double hosszuOldalHossz) :
            this(
                new Pont(0, 0),
                new Pont(0, rovidOldalHossz),
                new Pont(hosszuOldalHossz, rovidOldalHossz),
                new Pont(hosszuOldalHossz, 0)
                )
        {
            this.RovidOldalHossz = rovidOldalHossz;
            this.HosszuOldalHossz = hosszuOldalHossz;
        }

        public Teglalap() : base() { }

        public double Terulet() => this.RovidOldalHossz * this.HosszuOldalHossz;
    }
}
