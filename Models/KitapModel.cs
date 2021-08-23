using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kitap.Entity;

namespace Kitap.Models
{
    public class KitapModel
    {
        public int Id { get; set; }
        public string isim { get; set; }
        public double fiyat { get; set; }
        public string Kondisyon { get; set; }
        public int KondisyonId { get; set; }
        public int KategoriId { get; set; }
        public string Yazar { get; set; }
        public string ResimUrl { get; set; }
    }
}