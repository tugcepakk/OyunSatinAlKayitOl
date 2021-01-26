using OyunSatinAlKayitOl;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatinAlKayitOl
{
    class OyuncuManager
    {
        public void EDevletKontrol (Oyuncu oyuncu) 
        {
            Console.WriteLine(oyuncu.Isim +" "+ oyuncu.SoyIsim +" "+"İsimli oyuncunun E-devlet kontrolü yapıldı.");
            
        }

        public void KayitOlustur (Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Isim + " " + oyuncu.SoyIsim + " " + "İsimli oyuncunun kaydı oluşturuldu.");
        }


        public void KayitSil (Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Isim + " " + oyuncu.SoyIsim + " " + "İsimli oyuncunun kaydı silindi.");
        }





    }
}
