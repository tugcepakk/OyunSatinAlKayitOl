using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatinAlKayitOl
{
    class KampanyasizUrun: IUrun
    {
        public string GelecekKampanyaTarihi { get; set; }
        public string UrunAdi { get; set; }
        public int UrunKategori { get; set ; }
        public int UrunFiyati { get ; set ; }
    }
}
