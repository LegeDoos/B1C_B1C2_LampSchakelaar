using System;
using System.Collections.Generic;

namespace B1C_B1C2_LampSchakelaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voorbeeld lamp en schakelaar");

            Schakelaar schakelaar = new Schakelaar();
            schakelaar.Lampen = new List<Lamp>();
            for (int i = 0; i < 100; i++)
            {
                Lamp deLamp = new Lamp();
                schakelaar.Lampen.Add(deLamp);
            }

            schakelaar.Omschakelen();

            Console.WriteLine($"Aantal lampen in de lijst {schakelaar.Lampen.Count}");

            Dimschakelaar dimSchakelaar = new Dimschakelaar();
            
        }
    }
}
