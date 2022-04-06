using System;

namespace OOPAlapok
{
    class Szemely
    {
        static public int staticSorszam = 0;

        private int _sorszam;

        public int Sorszam
        {
            get
            {
                return this._sorszam;
            }
        }


        private string _csaladnev;

        public string Csaladnev {
            get 
            {
                return this._csaladnev;
            }
            set 
            {
                this._csaladnev = Szemely.Nagybetusse(value);
            } 
        }


        //private string _vezeteknev;

        //public string Vezeteknev
        //{
        //    get
        //    {
        //        return this._vezeteknev;
        //    }

        //    set
        //    {
        //        this._vezeteknev = value;
        //    }
        //}

        public string Vezeteknev;

        public string TeljesNev
        {
            get
            {
                return $"{this.Csaladnev} {this.Vezeteknev}";
            }
        }


        public Szemely(string csaladnev, string vezeteknev)
        {
            staticSorszam++;
            this._sorszam = staticSorszam;
            this.Csaladnev = csaladnev;
            this.Vezeteknev = vezeteknev;
        }

        public Szemely(string teljesnev)
        {
            staticSorszam++;
            this._sorszam = staticSorszam;

            string[] nevek = teljesnev.Split(" ");

            this.Csaladnev = nevek[0];
            this.Vezeteknev = nevek[1];
        }

        public Szemely()
        {
            staticSorszam++;
            this._sorszam = staticSorszam;
        }

        public override string ToString()
        {
            return $"{this.Sorszam}. {this.TeljesNev}";
        }

        static public string Nagybetusse(string s) => s.ToUpper()[0] + s.Substring(1);

    }
}
