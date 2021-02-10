using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "ismail", "ece", "ahsen", "berna" };
            //console.writeline(isimler[0]);
            //console.writeline(isimler[1]);
            //console.writeline(isimler[2]);
            //console.writeline(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "ahu";
            //console.writeline(isimler[4]);
            //console.writeline(isimler[0]);

            List<string> isimler2 = new List<string> { "ismail", "Ece", "Ahsen", "Berna", "Tuğçe" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);
            isimler2.Add("Hacer");
            Console.WriteLine(isimler2[5]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
