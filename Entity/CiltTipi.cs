using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kitap.Entity
{
    public class CiltTipi
    {
        public CiltTipi()
        {
            aktif = true;
        }
        public int Id { get; set; }
        public string isim { get; set; }
        public bool aktif { get; set; }
        
    }
}