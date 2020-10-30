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
                if (Lakosok > value)
                {
                    Console.WriteLine("Lakosok száma nem csökkenhet!");
                }
                else
                {
                    if (Lakosok > MaxLakosok)
                    {
                        Console.WriteLine("Lakosok száma nem lehet több, mint a megengedett.");
                    }
                    else
                    {
                        lakosok = value;

                    }
                }    
                
                
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
                if (Hazak > value)
                {
                    if (MaxLakosok < Lakosok)
                    {
                        Console.WriteLine("Túl kevés ház!");
                    }
                    else
                    {
                        hazak = value;
                    }
                }
                else
                {
                    hazak = value;
                }
                
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
        public void uzletEpit(int db)
        {
            if (db == 0 || db < 0)
            {
                Console.WriteLine("A szám nem lehet 0 vagy minusz szám!");
            }
            else
            {
                double maxUzletek = lakosok / 20;
                uzletek += db;
                if (uzletek > maxUzletek)
                {
                    Math.Floor(maxUzletek);
                    uzletek = Convert.ToInt32(maxUzletek);
                    Console.WriteLine("Túl lépte a maximális üzletszámot.");
                }
            }
        }
        public int compareTo(Varos masik)
        {
            int szam;
            if (Alapterulet == masik.Alapterulet)
            {
                szam = 0;
            }
            else if (Alapterulet < masik.Alapterulet)
            {
                szam = -1;
            }
            else
            {
                szam = 1;
            }

            return szam;
        }


        public override string ToString()
        {
            return string.Format("{0} - Lakosok: {1}/{2} - Üzletek: {3} - Alapterület: {4} m² "
                                ,this.nev, this.lakosok, MaxLakosok, this.uzletek, Alapterulet);
        }


    }
}
