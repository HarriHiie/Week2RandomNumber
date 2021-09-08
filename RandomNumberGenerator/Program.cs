using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int MyRandomNumber = rnd.Next(1, 11);



            //programm genereerib juhuslikku numbrit 1-10
            //programm kontrollib kas genereeritud number on
            //suurem kui 5
            //kui number on suurem kui 5 siis konsool kuvab
            //"juhuslik number on(myrandomnumber), see on suurem
            //kui 5"
            //kui number on väiksm kui 5 siis konsool kuvab
            //juhuslik number on(myrandomnumber), see on väiksem
            //kui 5
            //kui number on 5, siis konsool kuvab "juhslik number on 5"


            Console.WriteLine(MyRandomNumber);
            if (MyRandomNumber > 5)
            {
                Console.WriteLine($"juhuslik Number on {MyRandomNumber} see on suurm, kui 5");
            }
            else if (MyRandomNumber < 5)
            {
                Console.WriteLine($"Juhuslik number on {MyRandomNumber} see on väiksem kui 5");
            }
            else
            {
             Console.WriteLine($"Juhuslik number ongi 5");
            }














        }
    }
}
