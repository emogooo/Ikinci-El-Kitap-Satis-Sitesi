using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kitap.Entity;

namespace Kitap.Controllers
{
    [Authorize]
    public class KitapController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Kitap
        public ActionResult Index()
        {
            var kitaplar = db.Kitaplar.Include(k => k.CiltTipi).Include(k => k.Dil).Include(k => k.Kategori).Include(k => k.Kondisyon).Include(k => k.Kullanici).Include(k => k.Resim).Include(k => k.YayinEvi).Include(k => k.Yazar);
            return View(kitaplar.ToList());
        }

        // GET: Kitap/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kitap.Entity.Kitap kitap = db.Kitaplar.Find(id);
            if (kitap == null)
            {
                return HttpNotFound();
            }
            return View(kitap);
        }

        // GET: Kitap/Create
        public ActionResult Create()
        {
            ViewBag.CiltTipiId = new SelectList(db.CiltTipleri, "Id", "isim");
            ViewBag.DilId = new SelectList(db.Diller, "Id", "isim");
            ViewBag.KategoriId = new SelectList(db.Kategoriler, "Id", "isim");
            ViewBag.KondisyonId = new SelectList(db.Kondisyonlar, "Id", "isim");
            ViewBag.KullaniciId = new SelectList(db.Kullanicilar, "Id", "kullanici_adi");
            ViewBag.ResimId = new SelectList(db.Resimler, "Id", "url");
            ViewBag.YayinEviId = new SelectList(db.YayinEvleri, "Id", "isim");
            ViewBag.YazarId = new SelectList(db.Yazarlar, "Id", "ad");
            return View();
        }

        // POST: Kitap/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,isim,yayin_tarihi,sayfa_sayisi,ozet,fiyat,KondisyonId,CiltTipiId,DilId,KullaniciId,YayinEviId,YazarId,KategoriId,ResimId,aktif")] Kitap.Entity.Kitap kitap)
        {
            if (ModelState.IsValid)
            {
                db.Kitaplar.Add(kitap);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CiltTipiId = new SelectList(db.CiltTipleri, "Id", "isim", kitap.CiltTipiId);
            ViewBag.DilId = new SelectList(db.Diller, "Id", "isim", kitap.DilId);
            ViewBag.KategoriId = new SelectList(db.Kategoriler, "Id", "isim", kitap.KategoriId);
            ViewBag.KondisyonId = new SelectList(db.Kondisyonlar, "Id", "isim", kitap.KondisyonId);
            ViewBag.KullaniciId = new SelectList(db.Kullanicilar, "Id", "kullanici_adi", kitap.KullaniciId);
            ViewBag.ResimId = new SelectList(db.Resimler, "Id", "url", kitap.ResimId);
            ViewBag.YayinEviId = new SelectList(db.YayinEvleri, "Id", "isim", kitap.YayinEviId);
            ViewBag.YazarId = new SelectList(db.Yazarlar, "Id", "ad", kitap.YazarId);
            return View(kitap);
        }

        // GET: Kitap/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kitap.Entity.Kitap kitap = db.Kitaplar.Find(id);
            if (kitap == null)
            {
                return HttpNotFound();
            }
            ViewBag.CiltTipiId = new SelectList(db.CiltTipleri, "Id", "isim", kitap.CiltTipiId);
            ViewBag.DilId = new SelectList(db.Diller, "Id", "isim", kitap.DilId);
            ViewBag.KategoriId = new SelectList(db.Kategoriler, "Id", "isim", kitap.KategoriId);
            ViewBag.KondisyonId = new SelectList(db.Kondisyonlar, "Id", "isim", kitap.KondisyonId);
            ViewBag.KullaniciId = new SelectList(db.Kullanicilar, "Id", "kullanici_adi", kitap.KullaniciId);
            ViewBag.ResimId = new SelectList(db.Resimler, "Id", "url", kitap.ResimId);
            ViewBag.YayinEviId = new SelectList(db.YayinEvleri, "Id", "isim", kitap.YayinEviId);
            ViewBag.YazarId = new SelectList(db.Yazarlar, "Id", "ad", kitap.YazarId);
            return View(kitap);
        }

        // POST: Kitap/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,isim,yayin_tarihi,sayfa_sayisi,ozet,fiyat,KondisyonId,CiltTipiId,DilId,KullaniciId,YayinEviId,YazarId,KategoriId,ResimId,aktif")] Kitap.Entity.Kitap kitap)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kitap).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CiltTipiId = new SelectList(db.CiltTipleri, "Id", "isim", kitap.CiltTipiId);
            ViewBag.DilId = new SelectList(db.Diller, "Id", "isim", kitap.DilId);
            ViewBag.KategoriId = new SelectList(db.Kategoriler, "Id", "isim", kitap.KategoriId);
            ViewBag.KondisyonId = new SelectList(db.Kondisyonlar, "Id", "isim", kitap.KondisyonId);
            ViewBag.KullaniciId = new SelectList(db.Kullanicilar, "Id", "kullanici_adi", kitap.KullaniciId);
            ViewBag.ResimId = new SelectList(db.Resimler, "Id", "url", kitap.ResimId);
            ViewBag.YayinEviId = new SelectList(db.YayinEvleri, "Id", "isim", kitap.YayinEviId);
            ViewBag.YazarId = new SelectList(db.Yazarlar, "Id", "ad", kitap.YazarId);
            return View(kitap);
        }

        // GET: Kitap/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kitap.Entity.Kitap kitap = db.Kitaplar.Find(id);
            if (kitap == null)
            {
                return HttpNotFound();
            }
            return View(kitap);
        }

        // POST: Kitap/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kitap.Entity.Kitap kitap = db.Kitaplar.Find(id);
            db.Kitaplar.Remove(kitap);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
