using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritanceAlapok
{
    public class Negyszog : Alakzat
    {
        public Pont P1;
        public Pont P2;
        public Pont P3;
        public Pont P4;

        public Negyszog(Pont p1, Pont p2, Pont p3, Pont p4)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.P3 = p3;
            this.P4 = p4;
        }

        public Negyszog() : this(new Pont(0, 0), new Pont(1, 0), new Pont(1, 1), new Pont(0, 1)) { }

        public override double Kerulet() => 
            this.P1.Tavolsag(this.P2) + this.P2.Tavolsag(this.P3) + 
            this.P3.Tavolsag(this.P4) + this.P4.Tavolsag(this.P1);

    }
}
