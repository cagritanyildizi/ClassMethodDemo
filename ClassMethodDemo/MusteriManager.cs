using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.MusteriId);
            Console.WriteLine("Müşterinin Adı Soyadı : " + musteri.MusteriAdSoyad);
            Console.WriteLine("Müşterinin Yaşı : " + musteri.MusteriYas);
            Console.WriteLine("Müşterinin Cinsiyeti : " + musteri.MusteriCinsiyet);
        }

        public void Sil (Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdSoyad);
        }

        public void Listele (Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdSoyad);
        }
    }
}
