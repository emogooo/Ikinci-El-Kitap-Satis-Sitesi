using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kitap.Models
{
    public class KitapDetayModel
    {
        public string isim { get; set; }
        public string yayin_tarihi { get; set; }
        public int sayfa_sayisi { get; set; }
        public string ozet { get; set; }
        public double fiyat { get; set; }
        public string Kondisyon { get; set; }
        public string CiltTipi { get; set; }
        public string Dil { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciEposta { get; set; }
        public string YayinEvi { get; set; }
        public string Yazar { get; set; }
        public string Kategori { get; set; }
        public string Resim { get; set; }
    }
}