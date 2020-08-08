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
        }
    }
}
