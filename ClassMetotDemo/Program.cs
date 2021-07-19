using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 0001;
            musteri1.Ad = "Asus";
            musteri1.Soyad = "Computer";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 0002;
            musteri2.Ad = "Apple";
            musteri2.Soyad = "Phone";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 0003;
            musteri3.Ad = "Hp";
            musteri3.Soyad = "Computer";


            Musteri[] musteriler = new Musteri[]
            {
                musteri1,
                musteri2,
                musteri3
            };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Listele(musteriler);
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);

        }
    }
}
