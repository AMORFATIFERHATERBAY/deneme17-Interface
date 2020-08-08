using System;
using System.Collections;

namespace deneme17_Interface
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] dizi = { 2, 3, 5, 4, 1, 9, 8, 7 };
            Koleksiyon k = new Koleksiyon(dizi);

            foreach (int i in k)
                Console.Write(i + " ");
            Console.WriteLine();



            Sekil[] sekils = new Sekil[4];

            sekils[0] = new Dortgen(15, 20);
            sekils[1] = new Dortgen(20, 20);

            sekils[2] = new Ucgen("İkizkenar Ucgen", 10, 15);
            sekils[3] = new Ucgen("İkizkenar Ucgen", 12, 15);

            foreach (Sekil s in sekils)
                s.EkranYaz();
                
            sekils[0].Boy = 20;
            sekils[0].EkranYaz();


        }
    }
}
