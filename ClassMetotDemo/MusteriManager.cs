using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklenmiştir! " + musteri.Id + " " + musteri.Ad + " " + musteri.Soyad);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silinmiştir! " + musteri.Id + " " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (var Musteri in musteriler)
            {
                Console.WriteLine(Musteri.Id + " " + Musteri.Ad + " " + Musteri.Soyad);
            }
        }
    }
}
