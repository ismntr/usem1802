using System;
using System.Threading;

namespace Usem.OrnekSiniflar
{
    public class GeriSayim
    {
        // Veri
        private int sayac;
        private string mesaj;
        // Metot
        public GeriSayim(int sayi)
        {
            //
            this.sayac = sayi;
        }
        public GeriSayim(int sayi, string mesaj)
        {
            //
            this.sayac = sayi;
            this.mesaj = mesaj;
        }
        public void Baslat()
        {
            // 
            Thread.Sleep(sayac * 1000); // milisaniye
            if (mesaj != null)
            {
                Console.WriteLine(mesaj);
            }
        }
    }
}