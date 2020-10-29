using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarosEpitoProjekt
{
    class Varos
    {
        private string nev;
        private int lakosok;
        private int hazak;
        private int uzletek;

        public Varos(string nev, int meret)
        {
            this.nev = nev;
            switch (meret)
            {
                case 1: this.hazak = 150; this.uzletek = 20;
                    break;
                case 2: this.hazak = 300; this.uzletek = 45;
                    break;
                case 3: this.hazak = 450; this.uzletek = 50;
                    break;
            }
            this.lakosok = MaxLakosok / 2;
        }
        
        public string Nev
        {
            get
            {
                return nev;
            }
        }
        public int Lakosok
        {
            get
            {
                return lakosok;
            }
            set
            {
                lakosok = value;
            }
        }
        public int Hazak
        {
            get
            {
                return hazak;
            }
            set
            {
                hazak = value;
            }
        }
        public int Uzletek
        {
            get
            {
                return uzletek;
            }
        }
        public int MaxLakosok
        {
            get
            {
                if (lakosok != 0)
                {
                    return lakosok;
                }
                else
                {
                    return hazak * 6;
                }
            }
        }
        public double Alapterulet
        {
            get
            {
                return hazak * 110 + uzletek * 85.5;
            }
        }


        public override string ToString()
        {
            return string.Format("{0} - Lakosok: {1}/{2} - Üzletek: {3} - Alapterület: {4} m² "
                                ,this.nev, this.lakosok, MaxLakosok, this.uzletek, Alapterulet);
        }


    }
}
