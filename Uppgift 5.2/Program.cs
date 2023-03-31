using System;
namespace uppgift5._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal vill du skriva in?");
            int x = Convert.ToInt32(Console.ReadLine());

            int[] y = new int[x];

            Console.WriteLine("Skriv in " + x + " heltal.");

            for (int i = 0; i < x; i++)
            {
                y[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Du skrev:");

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Tal " + (i+1) + ":" + y[i]);
            }
        }
    }
}