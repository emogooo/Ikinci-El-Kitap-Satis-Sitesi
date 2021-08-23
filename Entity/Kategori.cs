using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Kitap.Entity
{
    public class Kategori
    {
        public Kategori()
        {
            kitaplar = new List<Kitap>();
            aktif = true;
        }
        public int Id { get; set; }

        [DisplayName("Kategori Adı")]
        public string isim { get; set; }

        [DisplayName("Kategori Aktif mi?")]
        public bool aktif { get; set; }
        public List<Kitap> kitaplar { get; set; }
    }
}