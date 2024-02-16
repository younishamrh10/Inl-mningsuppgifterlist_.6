using System;
using System.Collections.Generic;

namespace Inlämningsuppgifterlist_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in namnet på de maten du vill köpa");
            string maten = Console.ReadLine().ToLower();
            string[] varor = maten.Split(' ');

            Console.WriteLine(" skriv in matens pris:");
            string priser = Console.ReadLine();
            string[] deladpriser = priser.Split(' ');

            Dictionary<string, int> köplista = new Dictionary<string, int>();

            for (int i = 0; i < varor.Length; i++)
            {
                köplista[varor[i]] = int.Parse(deladpriser[i]);
            }

            Console.WriteLine("skriv in din kölista");
            string svar = Console.ReadLine().ToLower();
            string[] deladssvar = svar.Split(' ');

            int sum = 0;
            for (int i = 0; i < deladssvar.Length; i++)
            {
                sum += köplista[deladssvar[i]];
            }

            Console.WriteLine("Priser för kölistan blir" + sum);
        }
    }
}