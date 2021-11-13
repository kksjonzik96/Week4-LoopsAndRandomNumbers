using System;

namespace GuessGameThreeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbri ara arvata 
            // siis arvuti voidab
            //*programm genereerib juhusliku numbrit ühte korda.


            Random rnd = new Random();
            int myRandomNumber = rnd.Next(1, 11);

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("See on arvamis mäng, sa pead ära arvama numbri. Sul on kolm katset.");
                Console.WriteLine("Sisesta oma arv:");

                int userResult = Convert.ToInt32(Console.ReadLine());

                if (userResult == myRandomNumber)
                {

                    Console.WriteLine($"Sinu võit, numbrid klappisid: sinu poolt sisestatud number on {userResult} ja peidetud number oli  {myRandomNumber}");
                    break;

                }
                else if (i == 2)
                {

                    Console.WriteLine($"Sorry aga arvuti voitis!");
                    break;

                }
                else
                {

                    i++;
                    Console.WriteLine($"Kaotasid, proovi uuesti.");

                }
                
            }
        }
    }
}
