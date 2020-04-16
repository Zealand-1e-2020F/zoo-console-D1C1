using System;

namespace Zoo_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Zoo!");

            //Dyr elefant = new Dyr("Elefant","græs");

            Aborre aborreFisk = new Aborre("","");

            //Console.WriteLine(elefant.DyreNavn);
            Console.WriteLine(aborreFisk.ToString());

        }
    }
}
