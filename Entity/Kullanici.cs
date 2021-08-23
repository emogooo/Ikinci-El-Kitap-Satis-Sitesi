using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Web;

namespace Kitap.Entity
{
    public class Kullanici
    {
        public Kullanici()
        {
            kitaplar = new List<Kitap>();
            aktif = true;
        }
        public int Id { get; set; }
        [DisplayName("Kullanıcı")]
        public string kullanici_adi { get; set; }
        public string kullanici_sifresi { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string eposta { get; set; }
        public bool aktif { get; set; }
        public List<Kitap> kitaplar { get; set; }
    }
}