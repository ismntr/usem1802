namespace Usem.Oyunlar
{
    // Kart oluşturmak için reçete, Kart tipi tanımlıyor
    class Kart
    {
        public string grup; // mutlaka belirlenmeli
        public string grupSimge; // mutlaka belirlenmeli
        public bool kapali; // default deger yeterli

        // Simge ve değer uyumlu olmalı
        public string degerSimge; // mutlaka belirlenmeli
        public int deger; // mutlaka belirlenmeli
    }
}