using System;

namespace Usem.OrnekSiniflar
{
    class Kisi
    {
        // Veri
        private static int nufus;
        public readonly string ad;

        public int IdProp
        {
            get;
            set;
        }

        private int id; // field - alan - değişken

        // Constructor
        public Kisi(string ad)
        {
            this.ad = ad;
        }
        // Overload - Aşırı yükleme
        public Kisi(int id, string ad)
        {
            this.ad = ad;
            this.id = id;
        }

        //Metotlar - Davranışlar
        public int Get()
        {
            return this.id;
        }
        public void Set(int i)
        {
            if (i != 0)
            {
                this.id = i;
            }
        }







        public void Selamlama()
        {
            Console.WriteLine("Merhaba, ben " + ad);
        }

        public void Dogdu()
        {
            nufus += 1;
        }

        // Metot static olmayan ? Nufusu yazdıracak
        public void NufusNedir()
        {
            Console.WriteLine(nufus);
        }
    }
}
