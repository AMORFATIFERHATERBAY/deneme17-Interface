using System;
using System.Collections;

namespace deneme17_Interface
{
     class Koleksiyon : IEnumerable
    {
        int[] Dizi;
        public Koleksiyon(int[] dizi)
        {
            this.Dizi = dizi;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ENumaralandirma(this);
        }
        class ENumaralandirma : IEnumerator
        {
            int indeks;
            Koleksiyon koleksiyon;
            public ENumaralandirma(Koleksiyon koleksiyon)
            {
                this.koleksiyon = koleksiyon;
                indeks = -1;
            }
            public void Reset()
            {
                indeks = -1;
            }
            public bool MoveNext()
            {
                indeks++;
                if (indeks < koleksiyon.Dizi.Length)
                    return true;
                else
                    return false;
            }
            object IEnumerator.Current
            {
                get {return (koleksiyon.Dizi[indeks]);}
            }
        }
    }

}
