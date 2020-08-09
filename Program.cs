using System;
using System.Collections;

namespace deneme17_Interface
{

    class Program
    {
        public static void Test(IEnumerable dizi)
        {
            var a =dizi;
        }
        public static void Test(Koleksiyon2 dizi)
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] dizi = { 2, 3, 5, 4, 1, 9, 8, 7 };
            
            Koleksiyon k = new Koleksiyon(dizi);
            Koleksiyon h = new Koleksiyon(dizi);
            Koleksiyon2 k1 = new Koleksiyon2(dizi);
            Koleksiyon3 k3 = new Koleksiyon3(dizi);
            Test(k3);
            Test(k);
            Test(h);
            Test(k1);

            k.SonaEkle(10);
            int[] dizi2 = dizi;
            dizi2[3] = 0;

            foreach (int s in dizi2)
                Console.Write(s + " ");
            Console.WriteLine();



            foreach (var i in k)
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

            Otobüs otobüs = new Otobüs();
            otobüs.KlimaAc();


        }
    }
}
