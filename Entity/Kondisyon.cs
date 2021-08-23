using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Web;

namespace Kitap.Entity
{
    public class Kondisyon
    {
        public Kondisyon()
        {
            aktif = true;
        }
        public int Id { get; set; }
        [DisplayName("Kondisyon")]
        public string isim { get; set; }
        public bool aktif { get; set; }
    }
}