using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Web;

namespace Kitap.Entity
{
    public class YayinEvi
    {
        public YayinEvi()
        {
            aktif = true;
        }
        public int Id { get; set; }
        [DisplayName("Yayın Evi")]
        public string isim { get; set; }
        public bool aktif { get; set; }
    }
}