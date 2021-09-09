using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada numbrit -10 kuni 10;
            //programm kontrollib seda numbrit;
            //kui nr on positiivne, konsool kuvab "positive.";
            //kui nr on negatiivne, konsool kuvab "negative.";
            //kui nr on 0, siis konsool kuvab "null.";

            Console.WriteLine("Tere, palun valige -10 kuni 10-ni.");

            int num;

            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Teie valitud number on positiivne.");
            }
            else if (num < 0)
            {
                Console.WriteLine("Teie sisestatud number on negatiivne.");
            }
            else
            {
                Console.WriteLine("Teie valitud number on null.");
            }
            Console.ReadLine();
        }
    }
}
