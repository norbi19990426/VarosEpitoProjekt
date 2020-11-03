using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarosEpitoProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Varos v = new Varos();
            List<Varos> varos = new List<Varos>();
            varos.Add(new Varos("Debrecen",3));
            varos.Add(new Varos("Tiszacsege",2));
            varos.Add(new Varos("Budapest",1));

            int meret = 0;
            int korok = 1;
            char dontes = ' ';
            Console.WriteLine("Mi legyen a városod neve?: ");
            string varosNev = Console.ReadLine();
            do
            {
                Console.WriteLine("Mekkora legyen a mérete? (1-3): ");
                meret = Convert.ToInt32(Console.ReadLine());
            } while (meret < 1 || meret > 3);

            Varos felhasznaloVaros = new Varos(varosNev, meret);

            do
            {
                Console.WriteLine("\nKörök száma: {0}\n",korok);

                foreach (var adatok in varos)
                {
                    Console.WriteLine(adatok+"\n");
                }
                Console.WriteLine(felhasznaloVaros+"\n");

                switch (felhasznaloVaros.menu())
                {
                    case 'a': felhasznaloVaros.aMenu(); break;
                    case 'b': felhasznaloVaros.bMenu(); break;
                    case 'c': felhasznaloVaros.cMenu(); break;
                    default: dontes = 'd';break;
                }
                if (korok % 2 == 0)
                {
                    foreach (var adatok in varos)
                    {
                        adatok.Hazak += 15;
                        adatok.Lakosok += 10;
                    }
                }
                else
                {
                    foreach (var adatok in varos)
                    {
                        adatok.uzletEpit(10);
                        adatok.Lakosok += 20;
                    }
                }


                korok++;
            } while (felhasznaloVaros.dMenu(dontes) != 0 && korok != 20);

           


        }
    }
}
