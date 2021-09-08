using System;

namespace EpicDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat
            //iga mängija viskab täringut 1-6
            //programm kuvab nende visete tulemused ja kuvab ka kes on võitja
            //ehk kes viskas suuremat

            Random rnd = new Random();

            int MyRandomNumber = rnd.Next(1, 7);

            int MyRandomNumber = rnd.Next(1, 7);
        }
    }
}
