using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kitap.Entity;
using Kitap.Models;

namespace Kitap.Controllers
{
    public class HomeController : Controller
    {
        public DataContext context = new DataContext();
        public ActionResult Index()
        {
            IEnumerable<KitapModel> kitaplar = context.Kitaplar.Where(i => i.aktif).Select(i => new KitapModel()
            {
                Id = i.Id,
                isim = i.isim,
                fiyat = i.fiyat,
                Kondisyon = i.Kondisyon.isim,
                KondisyonId = i.KondisyonId,
                Yazar = i.Yazar.ad + " " + i.Yazar.soyad,
                ResimUrl = i.Resim.url

            }).ToList();
            return View(kitaplar);
        }
        [Authorize]
        public ActionResult Detay(int id)
        {
            KitapDetayModel kitap = context.Kitaplar.Where(i => id == i.Id).Select(i => new KitapDetayModel()
            {
                isim = i.isim,
                yayin_tarihi = i.yayin_tarihi,
                sayfa_sayisi = i.sayfa_sayisi,
                ozet = i.ozet,
                fiyat = i.fiyat,
                Kondisyon = i.Kondisyon.isim,
                CiltTipi = i.CiltTipi.isim,
                Dil = i.Dil.isim,
                KullaniciAd = i.Kullanici.ad + " " + i.Kullanici.soyad,
                KullaniciEposta = i.Kullanici.eposta,
                YayinEvi = i.YayinEvi.isim + " Yayınları",
                Yazar = i.Yazar.ad + " " + i.Yazar.soyad,
                Kategori = i.Kategori.isim,
                Resim = i.Resim.url

            }).FirstOrDefault();
            return View(kitap);
        }
        public ActionResult Liste(int? id)
        {
            IEnumerable<KitapModel> kitaplar = context.Kitaplar.Where(i => i.aktif).Select(i => new KitapModel()
            {
                Id = i.Id,
                isim = i.isim,
                fiyat = i.fiyat,
                Kondisyon = i.Kondisyon.isim,
                KondisyonId = i.KondisyonId,
                KategoriId = i.KategoriId,
                Yazar = i.Yazar.ad + " " + i.Yazar.soyad,
                ResimUrl = i.Resim.url

            }).AsQueryable();

            if (id!=null)
            {
                kitaplar = kitaplar.Where(i => i.KategoriId == id);
            }
            return View(kitaplar.ToList());
        }

        [ChildActionOnly]
        public PartialViewResult KategoriMenu()
        {
            List<Kategori> kategoriler = context.Kategoriler.Where(i => i.aktif).ToList();
            return PartialView("KategoriMenu", kategoriler);
        }

        
    }
}