using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kitap.Entity
{
    public class Yonetici
    {
        public Yonetici()
        {
            aktif = true;
        }
        public int Id { get; set; }
        public string kullanici_adi { get; set; }
        public string kullanici_sifresi { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public bool aktif { get; set; }
    }
}