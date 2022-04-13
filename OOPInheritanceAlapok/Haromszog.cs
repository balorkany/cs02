using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritanceAlapok
{
    public class Haromszog : Alakzat
    {
        public Pont P1;
        public Pont P2;
        public Pont P3;

        public Haromszog(Pont p1, Pont p2, Pont p3)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.P3 = p3;
        }

        public Haromszog() : this(new Pont(0, 0), new Pont(1, 0), new Pont(1, 1)) { }

        //ToDo
        public override double Kerulet()
        { return 0.0; }

        //ToDo
        public double Terulet()
        { return 0.0; }
       
    }
}
