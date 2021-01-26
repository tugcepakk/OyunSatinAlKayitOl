using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatinAlKayitOl
{
    interface IUrun
    {
        public string UrunAdi { get; set; }
        public int UrunKategori { get; set; }
        public int UrunFiyati { get; set; }
    }
}
