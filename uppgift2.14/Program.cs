using System;


namespace Uppgift_2_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett decimaltal");
            double Tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett till decimaltal");
            double Tal2 = double.Parse(Console.ReadLine());
            

            


            double Produkt = Tal1 * Tal2;

            Console.WriteLine("summan av talen gånger multiplicerat av varandra är " + Produkt);


        }
    }
}
