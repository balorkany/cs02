using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritanceAlapok
{
    public class Kor : Alakzat, ITerulettelRendelkezik
    {
        public Pont Center;
        double Sugar;

        public Kor(Pont center, double sugar)
        {
            this.Center = center;
            this.Sugar = sugar;
        }

        public Kor() : this(new Pont(0,0), 1.0) { }

        public override double Kerulet() => 2 * this.Sugar * Math.PI;

        public double Terulet() => Math.Pow(this.Sugar, 2) * Math.PI;

 
    }
}
