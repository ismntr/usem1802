using System;
using System.Collections.Generic;
using System.Text;
using Usem.Oyunlar;

namespace Usem.Ana
{
    class Program
    {
        static void Main(string[] args)
        {
            var BizimTahta = Tahta.TahtaOlustur();



















            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.WriteLine($"{BizimTahta[i, j].x} - {BizimTahta[i, j].y} - {BizimTahta[i, j].dolu} ");
                }
            }

            // List<Kart> BizimDeste = DesteOlustur(); // Karıştırma opsiyonlu 
            // DesteTumGoster(BizimDeste);

            // KartDagit();
            // Kart seçme 1? 5?
            // Kart Dağıtma 

        }


        private static void KartDagit(int kisiSayisi, int kartSayisi, List<Kart> dagitilacakDeste)
        {
            var d = dagitilacakDeste;

            // parameter kontrol :  temel kontrol 0'da buyuk. 

            // desteden n tane kart alma işi : alınan kartları versin yeter d listesi güncellemeli 
            // Bu metot genel olarak da kullanılabilir

            // Dağıtmak mümkün mü?
            // Kalan kart ne yapılacak? Çağıran metota bırakılabilir...

        }

        private static void DesteTumGoster(List<Kart> deste)
        {
            foreach (var k in deste)
            {
                Console.WriteLine($"{k.grup}{k.deger}");
            }

            // Console.OutputEncoding = Encoding.Unicode;
            // Console.WriteLine("\u263A"); // 
        }

        private static List<Kart> DesteOlustur(bool karisik = false)
        {
            // bool karisik;

            // 4 * 13 Deste ? 
            // Özel bir deste için veriler
            string[] gruplar = {
                "maça",
                "kupa",
                "karo",
                "sinek"
            };

            string[] degerSimgeler = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            int[] degerler = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            // Deste için veri yapısı (oyun ile ilgili)
            List<Kart> deste = new List<Kart>();

            foreach (var g in gruplar)
            {
                foreach (var d in degerSimgeler) // d? "A" "1"
                {
                    // Kart üret
                    Kart k = new Kart();
                    k.grup = g;
                    k.degerSimge = d;
                    k.deger = degerler[Array.IndexOf(degerSimgeler, d)]; // d nin indeksini bul, aynı indeksi degerler dizisinde kullan 
                    k.kapali = true;
                    // Kart deste ekle
                    deste.Add(k);
                }
            }


            if (karisik)
            {
                deste = DesteKaristir(deste);
            }
            return deste;

        }

        private static List<Kart> DesteKaristir(List<Kart> d)
        {
            // Karıştırma algoritması yaz
            var karisikDeste = d;
            Console.WriteLine("Deste karıştırıldı...");
            return karisikDeste;
        }
    }


    class Kutucuk
    {
        public bool dolu = false;
        public string x;
        public string y;
    }

    class Tahta
    {
        public static Kutucuk[,] TahtaOlustur()
        {
            // Grid sistemi Kutucuk'lar ile gerçeklenecek. 
            // Koordinatlardaki değerleri tut x,y
            int x = 8;
            int y = 8;

            Kutucuk[,] tahta = new Kutucuk[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    var kutu = new Kutucuk();
                    kutu.x = i.ToString();
                    kutu.y = j.ToString();
                    tahta[i, j] = kutu;
                }
            }

            var k = tahta[3, 2];
            return tahta;
        }
    }
}
