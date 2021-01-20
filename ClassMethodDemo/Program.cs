using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdSoyad = "Çağrı Tanyıldızı";
            musteri1.MusteriYas = 20;
            musteri1.MusteriCinsiyet = "Erkek";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAdSoyad = "Engin Demiroğ";
            musteri2.MusteriYas = 30;
            musteri2.MusteriCinsiyet = "Erkek";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAdSoyad = "Mesut Özil";
            musteri3.MusteriYas = 32;
            musteri3.MusteriCinsiyet = "Erkek";

            Musteri musteri4 = new Musteri();
            musteri4.MusteriId = 4;
            musteri4.MusteriAdSoyad = "Ayşe Uslu";
            musteri4.MusteriYas = 26;
            musteri4.MusteriCinsiyet = "Kız";

            Musteri musteri5 = new Musteri();
            musteri5.MusteriId = 5;
            musteri5.MusteriAdSoyad = "Nazlı Toprak";
            musteri5.MusteriYas = 23;
            musteri5.MusteriCinsiyet = "Kız";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };
            MusteriManager musterimanager = new MusteriManager();

            Console.WriteLine("Müşteriler Eklendi");
            Console.WriteLine("");
            musterimanager.Ekle(musteri1);
            Console.WriteLine("");
            musterimanager.Ekle(musteri2);
            Console.WriteLine("");
            musterimanager.Ekle(musteri3);
            Console.WriteLine("");
            musterimanager.Ekle(musteri4);
            Console.WriteLine("");
            musterimanager.Ekle(musteri5);
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Müşteri Silindi : ");
            Console.WriteLine("");
            musterimanager.Sil(musteri1);
            Console.WriteLine("");
            musterimanager.Sil(musteri2);
            Console.WriteLine("");
            musterimanager.Sil(musteri3);
            Console.WriteLine("");
            musterimanager.Sil(musteri4);
            Console.WriteLine("");
            musterimanager.Sil(musteri5);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Müşteri Listelendi : ");
            Console.WriteLine("");
            musterimanager.Listele(musteri1);
            Console.WriteLine("");
            musterimanager.Listele(musteri2);
            Console.WriteLine("");
            musterimanager.Listele(musteri3);
            Console.WriteLine("");
            musterimanager.Listele(musteri4);
            Console.WriteLine("");
            musterimanager.Listele(musteri5);
            Console.WriteLine("------------------------------------");











        }
    }
}
