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
            this.lakosok = MaxLakosok/2;
        }
        public Varos() { }
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
                if (lakosok > value)
                {
                    Console.WriteLine("Lakosok száma nem csökkenhet!");
                }
                else
                {
                    
                    if (lakosok > MaxLakosok)
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
                
                return hazak * 6;
               
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
                    Console.WriteLine("{0}: Túl lépte a maximális üzletszámot.",this.nev);
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
        public char menu()
        {
            char dontes;

            do
            {
                Console.WriteLine("a.) Lakosok betelepítése \n" +
                                  "b.) Ház építés \n" +
                                  "c.) Üzlet építés \n" +
                                  "d.) Kilépés");
                Console.WriteLine("Válassz egy menüpontot: ");
                dontes = Convert.ToChar(Console.ReadLine());
            } while (dontes != 'a' && dontes != 'b' && dontes != 'c' && dontes != 'd');

            return dontes;
        }
        public void aMenu()
        {
            Console.WriteLine("Mennyi lakost szeretne betelepíteni?: ");
            int ember = Convert.ToInt32(Console.ReadLine());

            this.lakosok += ember;
        }
        public void bMenu()
        {
            Random rnd = new Random();
            int veletlenSzam = rnd.Next(10, 21);
            this.hazak += veletlenSzam;
        }
        public void cMenu()
        {
            uzletEpit(10);
        }
        public int dMenu(char dontes)
        { 
            return dontes == 'd' ? 0 : 1; 
        }
        public void nyertes(string nev, double alapterulet)
        {
            if (Alapterulet > alapterulet)
            {
                Console.WriteLine("{0} nyert {1} alapterülettel",this.nev,Alapterulet);
            }
            else
            {
                Console.WriteLine("{0} nyert {1} alapterülettel",nev , alapterulet);

            }
        }
        public override string ToString()
        {
            return string.Format("{0} - Lakosok: {1}/{2} - Üzletek: {3} - Alapterület: {4} m² "
                                ,this.nev, this.lakosok, MaxLakosok, this.uzletek, Alapterulet);
        }


    }
}
