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
        public void SonaEkle(int sayi)
        {
            Array.Resize(ref Dizi, Dizi.Length + 1);

            Dizi[Dizi.GetUpperBound(0)] = sayi;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ENumaralandirma(this);
        }
        class ENumaralandirma:IEnumerator
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
            public object Current
            {
                get { return (koleksiyon.Dizi[indeks]); }
            }
        }
    }
    class Koleksiyon2
    {
        int[] Dizi;
        public Koleksiyon2(int[] dizi)
        {
            this.Dizi = dizi;
        }
        public void SonaEkle(int sayi)
        {
            Array.Resize(ref Dizi, Dizi.Length + 1);

            Dizi[Dizi.GetUpperBound(0)] = sayi;
        }
        public ENumaralandirma GetEnumerator()
        {
            return new ENumaralandirma(this);
        }
        public class ENumaralandirma
        {
            int indeks;
            Koleksiyon2 koleksiyon;
            public ENumaralandirma(Koleksiyon2 koleksiyon)
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
            public object Current
            {
                get { return (koleksiyon.Dizi[indeks]); }
            }
        }
    }

 class Koleksiyon3 : IEnumerable
    {
        int[] Dizi;
        public Koleksiyon3(int[] dizi)
        {
            this.Dizi = dizi;
        }
        public void SonaEkle(int sayi)
        {
            Array.Resize(ref Dizi, Dizi.Length + 1);

            Dizi[Dizi.GetUpperBound(0)] = sayi;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ENumaralandirma(this);
        }
        class ENumaralandirma:IEnumerator
        {
            int indeks;
            Koleksiyon3 koleksiyon;
            public ENumaralandirma(Koleksiyon3 koleksiyon)
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
            public object Current
            {
                get { return (koleksiyon.Dizi[indeks]); }
            }
        }
    }
    
}

