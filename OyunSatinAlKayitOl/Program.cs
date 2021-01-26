using System;

namespace OyunSatinAlKayitOl
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu1 = new Oyuncu();
            oyuncu1.Isim = "Tuğçe";
            oyuncu1.SoyIsim = "Pak";
            oyuncu1.TcNo = "123";
            oyuncu1.DogumTarihi = "17/07/2000";

            Oyuncu oyuncu2 = new Oyuncu();
            oyuncu2.Isim = "Deniz";
            oyuncu2.SoyIsim = "Pak";
            oyuncu2.TcNo = "124";
            oyuncu2.DogumTarihi = "07/08/2008";

            Oyuncu oyuncu3 = new Oyuncu();
            oyuncu3.Isim = "Emre";
            oyuncu3.SoyIsim = "Özyüzücüler";
            oyuncu3.TcNo = "321";
            oyuncu3.DogumTarihi = "25/01/2000";


            OyuncuManager oyuncuManager = new OyuncuManager();
            oyuncuManager.EDevletKontrol(oyuncu1);
            oyuncuManager.EDevletKontrol(oyuncu2);
            oyuncuManager.EDevletKontrol(oyuncu3);

            oyuncuManager.KayitOlustur(oyuncu1);
            oyuncuManager.KayitOlustur(oyuncu2);
            oyuncuManager.KayitOlustur(oyuncu3);

            oyuncuManager.KayitSil(oyuncu1);
            oyuncuManager.KayitSil(oyuncu2);
            oyuncuManager.KayitSil(oyuncu3);



            KampanyasizUrun ksizUrun1 = new KampanyasizUrun();
            ksizUrun1.GelecekKampanyaTarihi = "Gelecek haftasonu .";
            ksizUrun1.UrunAdi = "Korku Oyunu";
            ksizUrun1.UrunFiyati = 100;
            ksizUrun1.UrunKategori = 5;

            KampanyaliUrun kliUrun1 = new KampanyaliUrun();
            kliUrun1.KampanyaTuru = ("%50 indirim.");
            kliUrun1.UrunAdi = "Yarış Oyunu";
            kliUrun1.UrunFiyati = 90;
            kliUrun1.UrunKategori = 1;


            string [] oyuncular = { oyuncu1.Isim, oyuncu2.Isim, oyuncu3.Isim };
            foreach (string item in oyuncular)
            {
                Console.WriteLine(item + " " + "adlı oyuncu yeni oyun satın aldı");
            }


            



























        }
    }
}
