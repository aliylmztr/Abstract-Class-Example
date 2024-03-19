using System;

namespace AbstractClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Ocak ocak = new Ocak();
            Console.WriteLine("Ocak gün saati: " + ocak.gunSaati());

            Subat subat = new Subat();
            Console.WriteLine("Şubat gün saati: "+ subat.gunSaati());

            Mart mart = new Mart();
            Console.WriteLine("Mart gün saati: "+ mart.gunSaati());

            Console.ReadLine();
        }
    }
}
