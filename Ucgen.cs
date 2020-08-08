using System;
using System.Collections;

namespace deneme17_Interface
{
    class Ucgen : Sekil
    {
        private string ucgenTuru;
        public Ucgen(string turu, double boy, double en) : base(boy, en)
        {
            this.ucgenTuru = turu;
        }

         override public double Boy
        {
            get { return mBoy; }
            set { mBoy = value; }
        }

        override public double En
        {
            get { return mEn; }
            set { mEn = value; }
        }

        override public double Area()
        {
            return mEn*mBoy/2;
        }
        override public void EkranYaz()
        {
            Console.WriteLine("\nUcgenin boyu    : {0}", mBoy);
            Console.WriteLine("Ucgenin eni      : {0}", mEn);
            Console.WriteLine("Ucgenin Türü  : {0}", ucgenTuru);
            Console.WriteLine("Ucgenin alanı    : {0}\n", Area());
        }
    }


}
