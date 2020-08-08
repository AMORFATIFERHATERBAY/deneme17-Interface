using System;
using System.Collections;

namespace deneme17_Interface
{
    class Dortgen : Sekil
    {
        private bool mKareMi;
        public Dortgen(double boy, double en) : base(boy, en)
        {
            KareKontrol();
        }

        public bool KareMi
        {
            get { return mKareMi; }
        }

        override public double Boy
        {
            get { return mBoy; }
            set { mBoy = value; KareKontrol(); }
        }

        override public double En
        {
            get { return mEn; }
            set { mEn = value; KareKontrol(); }
        }

        override public double Area()
        {
            return mBoy * mEn;
        }

        override public void EkranYaz()
        {
            Console.WriteLine("\nDortgenin boyu    : {0}", mBoy);
            Console.WriteLine("Dortgenin eni      : {0}", mEn);
            Console.WriteLine("Dortgenin Kare mi  : {0}", KareMi ? "Evet" : "Hayir");
            Console.WriteLine("Dortgenin alanı    : {0}\n", Area());

        }

        // private bool KareKontrol()
        // {
        //     if (Boy == En)
        //         {mKareMi = true; return mKareMi;}
        //     else
        //          {mKareMi = false; return mKareMi;}

        // }
        private void KareKontrol()
        {
            if (Boy == En)
                mKareMi = true;
            else
                mKareMi = false;

        }
    }
}
