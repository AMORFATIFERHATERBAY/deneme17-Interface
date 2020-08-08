using System;
using System.Collections;

namespace deneme17_Interface
{

    abstract class Sekil
    {
        protected double mBoy;
        protected double mEn;

        public Sekil(double boy, double en)
        {
            this.Boy = boy;
            this.En = en;
        }
        abstract public double Boy
        {
            get;
            set;
        }
        abstract public double En
        {
            get;
            set;
        }
        abstract public double Area();
        abstract public void EkranYaz();
    }
}
