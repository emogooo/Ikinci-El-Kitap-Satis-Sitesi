using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Web;

namespace Kitap.Entity
{
    public class Resim
    {
        public Resim()
        {
            aktif = true;
        }
        public int Id { get; set; }
        [DisplayName("Resim")]
        public string url { get; set; }
        public bool aktif { get; set; }
    }
}