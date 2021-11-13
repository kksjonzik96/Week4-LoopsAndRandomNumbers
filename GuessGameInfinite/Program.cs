using System;

namespace GuessGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhusliku numbrit ühte korda.

            Random rnd = new Random();
            int myRandomNumber = rnd.Next(1, 11);

            int i = 0;
            
            while (i != 5)
            {
                Console.WriteLine("See on arvamis mäng, sa pead ära arvama numbri.");
                Console.WriteLine("Sisesta oma arv:");

                int userResult = Convert.ToInt32(Console.ReadLine());

                if ( userResult == myRandomNumber)
                {
                    
                    Console.WriteLine($"Sinu võit, numbrid klappisid: sinu poolt sisestatud number on {userResult} ja peidetud number oli  {myRandomNumber}");
         
                }
                else
                {
                    
                    Console.WriteLine($"Kaotasid, numbrid ei klappinud. Proovi uuest!");
                }
            }

        }
    }
}
