using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Web;

namespace Kitap.Entity
{
    public class Yazar
    {
        public Yazar()
        {
            kitaplar = new List<Kitap>();
            aktif = true;
        }
        public int Id { get; set; }
        [DisplayName("Yazar")]
        public string ad { get; set; }
        public string soyad { get; set; }
        public bool aktif { get; set; }
        public List<Kitap> kitaplar { get; set; }
    }
}