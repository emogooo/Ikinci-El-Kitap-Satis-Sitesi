using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Web;

namespace Kitap.Entity
{
    public class Kitap
    {
        public Kitap()
        {
            aktif = true;
        }
        public int Id { get; set; }
        [DisplayName("Kitap Adı")]
        public string isim { get; set; }
        [DisplayName("Yayın Tarihi")]
        public string yayin_tarihi { get; set; }
        [DisplayName("Sayfa Sayısı")]
        public int sayfa_sayisi { get; set; }
        [DisplayName("Özet")]
        public string ozet { get; set; }
        [DisplayName("Fiyat")]
        public double fiyat { get; set; }
        [DisplayName("Kondisyon")]
        public int KondisyonId { get; set; }
        [DisplayName("Cilt Tipi")]
        public int CiltTipiId { get; set; }
        [DisplayName("Dil")]
        public int DilId { get; set; }
        [DisplayName("Kullanıcı")]
        public int KullaniciId { get; set; }
        [DisplayName("Yayın Evi")]
        public int YayinEviId { get; set; }
        [DisplayName("Yazar")]
        public int YazarId { get; set; }
        [DisplayName("Kategori")]
        public int KategoriId { get; set; }
        [DisplayName("Resim")]
        public int ResimId { get; set; }
        [DisplayName("Satışta mı?")]
        public bool aktif { get; set; }
        public Kondisyon Kondisyon { get; set; }
        public CiltTipi CiltTipi { get; set; }
        public Dil Dil { get; set; }
        public Kullanici Kullanici { get; set; }
        public YayinEvi YayinEvi { get; set; }
        public Yazar Yazar { get; set; }
        public Kategori Kategori { get; set; }
        public Resim Resim { get; set; }
    }
}