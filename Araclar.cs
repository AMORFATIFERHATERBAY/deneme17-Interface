using System;
using System.Collections;

namespace deneme17_Interface
{
    interface IKlimaAcabilir
    {
        void KlimaAc();
    }

    abstract class Tasit
    {
        public double Agirlik
        {
            get; set;
        }
        public double Beygir
        {
            get; set;
        }

    }
    class Kamyon : Tasit
    {

    }
    class Otobüs : Tasit,IKlimaAcabilir
    {
       public void KlimaAc()
        {
           Console.WriteLine("Klima Açık"); 
        }
    }
    class Otomobil : Tasit,IKlimaAcabilir
    {
       public void KlimaAc()
        {
            Console.WriteLine("Klima Açık"); 
        }
    }

}
