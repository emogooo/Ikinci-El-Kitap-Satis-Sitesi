using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kitap.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            List<CiltTipi> ciltTipleri = new List<CiltTipi>()
            {
                new CiltTipi(){isim = "Karton Kapak" },
                new CiltTipi(){isim = "Ciltli" }
            };
            foreach (var ciltTipi in ciltTipleri)
            {
                context.CiltTipleri.Add(ciltTipi);
            }
            context.SaveChanges();

            List<Dil> diller = new List<Dil>()
            {
                new Dil(){isim = "Türkçe" },
                new Dil(){isim = "İngilizce" },
                new Dil(){isim = "Arapça" },
                new Dil(){isim = "Japonca" },
                new Dil(){isim = "Rusça" },
                new Dil(){isim = "Osmanlıca" }
            };
            foreach (var dil in diller)
            {
                context.Diller.Add(dil);
            }
            context.SaveChanges();

            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori(){isim = "Roman" },
                new Kategori(){isim = "Çocuk" },
                new Kategori(){isim = "Tarih" },
                new Kategori(){isim = "Sağlık" },
                new Kategori(){isim = "Ders" },
                new Kategori(){isim = "Din" },
                new Kategori(){isim = "Edebiyat" },
                new Kategori(){isim = "Bilim" },
                new Kategori(){isim = "Spor" },
                new Kategori(){isim = "Eğlence" },
            };
            foreach (var kategori in kategoriler)
            {
                context.Kategoriler.Add(kategori);
            }
            context.SaveChanges();

            List<Kondisyon> kondisyonlar = new List<Kondisyon>()
            {
                new Kondisyon(){isim = "Kötü" },
                new Kondisyon(){isim = "Normal" },
                new Kondisyon(){isim = "İyi" },
                new Kondisyon(){isim = "Yeni" }

            };
            foreach (var kondisyon in kondisyonlar)
            {
                context.Kondisyonlar.Add(kondisyon);
            }
            context.SaveChanges();

            List<Kullanici> kullanicilar = new List<Kullanici>()
            {
                new Kullanici(){kullanici_adi = "emirhan60",kullanici_sifresi="123456", ad="Emirhan",soyad="Aydın",eposta="emirhan60@gmail.com" },
                new Kullanici(){kullanici_adi = "ayse60",kullanici_sifresi="123456", ad="Ayşe",soyad="Deniz",eposta="ayse60@gmail.com" },
                new Kullanici(){kullanici_adi = "mehmet60",kullanici_sifresi="123456", ad="Mehmet",soyad="Demir",eposta="mehmet60@gmail.com" },
                new Kullanici(){kullanici_adi = "fatma60",kullanici_sifresi="123456", ad="Fatma",soyad="Kaya",eposta="fatma60@gmail.com" },
                new Kullanici(){kullanici_adi = "imge60",kullanici_sifresi="123456", ad="İmge",soyad="Yıldırım",eposta="imge60@gmail.com" }
            };
            foreach (var kullanici in kullanicilar)
            {
                context.Kullanicilar.Add(kullanici);
            }
            context.SaveChanges();

            List<Resim> resimler = new List<Resim>()
            {
                new Resim(){url = "https://i2.cnnturk.com/i/cnnturk/75/630x0/55e458c8ae78490d4c943d37.jpg" },
                new Resim(){url = "https://parlakjurnal.com/wp-content/uploads/2019/12/2020-Y%C4%B1l%C4%B1nda-Okunacak-8-Kitap-Tavsiyesi.jpg" },
                new Resim(){url = "https://cdn.kitapsec.com/image/urun/2018/09/15/s1536997935.jpg" },
                new Resim(){url = "https://productimages.hepsiburada.net/s/22/1500/9973404762162.jpg" },
                new Resim(){url = "https://cdn.cimri.io/image/1200x1200/kitapeitlerivefiyatlar_126253342.jpg" },
                new Resim(){url = "https://cdn.akakce.com/-/kral-sakir-7-kitap-takim-set-varol-yasaroglu-z.jpg" },
                new Resim(){url = "https://images.kitapsepeti.com/Content/global/images/products/1/1407213/the-book-of-m-kiyamet-basliyor-ciltli.jpg" },
                new Resim(){url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS6cdWaMbzCANg-Abh7leSvtgvVYMaChP9UUg&usqp=CAU" }
            };
            foreach (var resim in resimler)
            {
                context.Resimler.Add(resim);
            }
            context.SaveChanges();

            List<YayinEvi> yayinEvleri = new List<YayinEvi>()
            {
                new YayinEvi(){isim = "Martı" },
                new YayinEvi(){isim = "Doğan" },
                new YayinEvi(){isim = "Güneş" },
                new YayinEvi(){isim = "Aktif" },
                new YayinEvi(){isim = "Pasif" },
                new YayinEvi(){isim = "Kelebek" }
            };
            foreach (var yayinEvi in yayinEvleri)
            {
                context.YayinEvleri.Add(yayinEvi);
            }
            context.SaveChanges();

            List<Yazar> yazarlar = new List<Yazar>()
            {
                new Yazar(){ad = "Sait Faik", soyad="Abasıyanık"},
                new Yazar(){ad = "Adalet", soyad="Ağaoğlu"},
                new Yazar(){ad = "Yusuf", soyad="Akçura"},
                new Yazar(){ad = "Sabahattin", soyad="Ali"},
                new Yazar(){ad = "Melih Cevdet", soyad="Anday"}
            };
            foreach (var yazar in yazarlar)
            {
                context.Yazarlar.Add(yazar);
            }
            context.SaveChanges();

            List<Yonetici> yoneticiler = new List<Yonetici>()
            {
                new Yonetici(){kullanici_adi = "emirhanadmin",kullanici_sifresi="123456", ad="Emirhan",soyad="Aydın" },
                new Yonetici(){kullanici_adi = "ayseadmin",kullanici_sifresi="123456", ad="Ayşe",soyad="Deniz" }
            };
            foreach (var yonetici in yoneticiler)
            {
                context.Yoneticiler.Add(yonetici);
            }
            context.SaveChanges();

            List<Kitap> kitaplar = new List<Kitap>()
            {
                new Kitap(){isim = "Güller", yayin_tarihi="15.05.2009", sayfa_sayisi= 350, ozet = "Günlerden çok fırtınalı ve sağanaklı bir gündür. Tepenin yüceliklerindeki büyük şatoda bir kral, kraliçe ve yakışıklı oğulları prens oturmaktadır. Prens çok uzun yıllar boyunca kendi gibi iyi ahlaklı ve güzel bir prenses arar. Ancak bu kadar aramaya rağmen bulamamıştır ve bunun üzüntüsüyle şatoya geri dönmüştür. Durumu krala anlatacağı zaman kapı vurulur.", fiyat=25, KondisyonId=3, CiltTipiId=1, DilId=1, KullaniciId=1,YayinEviId=1,YazarId=1,KategoriId=1,ResimId=1 },
                new Kitap(){isim = "Papatyalar ve Sadık Dostum", yayin_tarihi="10.06.2015", sayfa_sayisi= 600, ozet = "Kapıyı açan kral karşısında sırılsıklam olmuş güzel mi güzel bir kız görür, hemen içeriye alır, kraliçe kızın bir prenses olamayacağını ve kızın asil olmadığını düşünerek prensin kızla evlenmesine karşı çıkar.", fiyat=15, KondisyonId=4, CiltTipiId=1, DilId=1, KullaniciId=2,YayinEviId=2,YazarId=2,KategoriId=2,ResimId=2 },
                new Kitap(){isim = "Ah Yarim Ben Ne Edim", yayin_tarihi="15.05.2010", sayfa_sayisi= 50, ozet = "Soğuk bir Noel arifesinde, kentin caddelerinde herkes eğlenirken küçük kız onları seyredip kendi kendine eğleniyordur.", fiyat=18, KondisyonId=1, CiltTipiId=1, DilId=1, KullaniciId=1,YayinEviId=3,YazarId=2,KategoriId=3,ResimId=4 },
                new Kitap(){isim = "Bir Of Çeksem Karşı ki Dağlar Yıkılır", yayin_tarihi="15.05.2011", sayfa_sayisi= 500, ozet = "Nasıl olsa üvey annem ve babam anlamaz diyerek sıcacık bir ev hayal ederken kibriti yakarak bitirir. Bu durumu fark edince ne yapacağını şaşırmış, korkmuş ve ölmüş büyük annesinden yardım dilenmeye, seslenmeye başlar.", fiyat=5, KondisyonId=2, CiltTipiId=1, DilId=1, KullaniciId=2,YayinEviId=4,YazarId=2,KategoriId=4,ResimId=4 },
                new Kitap(){isim = "Dileley Dileley Nazlı Yarim", yayin_tarihi="15.05.2012", sayfa_sayisi= 540, ozet = "Bir zamanlar yaşlı bir kraliçe varmış. Kraliçe güçlü, dediği dedik bir insanmış. Kimse bir dediğini iki etmezmiş. Kraliçe, bütün mevsimlerde bütün dünya ülkelerinde yetişen güllerden güzel güller yetiştirirmiş.", fiyat=9, KondisyonId=3, CiltTipiId=2, DilId=1, KullaniciId=5,YayinEviId=1,YazarId=3,KategoriId=5,ResimId=2 },
                new Kitap(){isim = "Sigara", yayin_tarihi="15.05.2013", sayfa_sayisi= 370, ozet = "Birden tatlı bir pembelik yayıldı. Kraliçenin yanaklarına, gözleri büyüdü, bir güneş gibi parladı ve kitabın yaprakları arasında pembe bir gül, dünyanın en güzel gülü beliriverdi.", fiyat=25, KondisyonId=3, CiltTipiId=1, DilId=1, KullaniciId=1,YayinEviId=4,YazarId=4,KategoriId=6,ResimId=3 },
                new Kitap(){isim = "Suçlar", yayin_tarihi="15.05.2014", sayfa_sayisi= 358, ozet = "Çekirge, pire ve uçan kaz bir gün saraya davet edilmişler. Kral üçünün arasında bir yarış düzenleyecek ve en yükseğe sıçrayana büyük bir ödül verecekmiş.", fiyat=35, KondisyonId=3, CiltTipiId=1, DilId=1, KullaniciId=5,YayinEviId=1,YazarId=1,KategoriId=7,ResimId=5 },
                new Kitap(){isim = "Teoriler", yayin_tarihi="15.05.2015", sayfa_sayisi= 3540, ozet = "Zamanın birinde okyanusların dibinde bir şato varmış. Burada kral büyük anne ve altı kız beraber yaşarmış. Bu kızlardan en küçüğü hepsinden güzelmiş.", fiyat=45, KondisyonId=4, CiltTipiId=1, DilId=1, KullaniciId=1,YayinEviId=2,YazarId=1,KategoriId=1,ResimId=6 },
                new Kitap(){isim = "Heidi Oyun Oynuyor", yayin_tarihi="12.05.2009", sayfa_sayisi= 450, ozet = "Kızlara yeryüzünü göstereceğine dair söz vermiş. Kızlar on beş yaşına geldiklerinde yeryüzünü görüp geri gelmişler. Kızların beşi geri dönmeyi ve eski yerinde yaşamayı kabullenirken en küçük kız ise dünyalı bir prense aşık olmuş ve bir an önce onun yanına gitmek istiyormuş. ", fiyat=55, KondisyonId=4, CiltTipiId=1, DilId=1, KullaniciId=1,YayinEviId=1,YazarId=5,KategoriId=2,ResimId=4 },
                new Kitap(){isim = "Minik Köpeklerle Gezi", yayin_tarihi="05.05.2009", sayfa_sayisi= 750, ozet = "Deniz kızı bunu yapamayacağını anlayınca daha fazla dayanamayarak oradan ayrılır. Kısa bir zaman gezindikten sonra vücudunun değiştiğini görür. Fazla zaman geçmeden deniz kızı hayata veda eder.", fiyat=9, KondisyonId=4, CiltTipiId=1, DilId=1, KullaniciId=2,YayinEviId=3,YazarId=1,KategoriId=3,ResimId=3 },
                new Kitap(){isim = "Hayatımın En Güzel Şarkısı", yayin_tarihi="11.05.2009", sayfa_sayisi= 300, ozet = "Fırtınadan sonra bir kara buğday tarlasından geçenler bilir. Kara buğday tarlası sanki kavrulmuş gibidir. Yaşlı söğüdün tam önünde bir kara buğday tarlası varmış. Kara buğday Pek kibirli imiş. Başı yükseklerden hiç inmezmiş.", fiyat=3, KondisyonId=2, CiltTipiId=2, DilId=1, KullaniciId=5,YayinEviId=1,YazarId=1,KategoriId=2,ResimId=2 },
                new Kitap(){isim = "Kader", yayin_tarihi="16.05.2009", sayfa_sayisi= 30, ozet = "Çocukların odasında, gar dolabın üstünde oldukça yüksek bir köşede domuz biçiminde içi ağzına kadar para dolu bir kumbara varmış. Gar dolabın tepesinde yer aldığı için odada olup biteni seyredebiliyor, karnındakilerle her şeyi satın alabileceğini düşünüyordu.", fiyat=7, KondisyonId=3, CiltTipiId=1, DilId=1, KullaniciId=1,YayinEviId=4,YazarId=4,KategoriId=4,ResimId=1 },
                new Kitap(){isim = "Sanatçı Dünyasına Bakış", yayin_tarihi="19.05.2009", sayfa_sayisi= 310, ozet = "Tabi içinde fırlayıp dört bir yana saçılan paralarda oradan oraya yuvarlanıyor, dans edip duruyordu. Paralar dünyaya yeniden gelmişçesine bir anlık dahi olsa özgürlüğün tadını çıkararak dans ederken domuz kumbaranın parçaları da bir kutuya konuyordu.", fiyat=11, KondisyonId=2, CiltTipiId=2, DilId=1, KullaniciId=5,YayinEviId=1,YazarId=1,KategoriId=6,ResimId=1 },
                new Kitap(){isim = "Romanlar", yayin_tarihi="07.05.2009", sayfa_sayisi= 30, ozet = "Büyütecin ne olduğunu, her şeyi yüz kat büyülten bir çeşit gözlük camı olduğunu herkes bilir. Bir damla suya büyüteçle bakıldığında binlerce küçük yaratık görünür. Oysa çıplak gözle bakarsak onların hiç birini göremeyiz.", fiyat=12, KondisyonId=3, CiltTipiId=1, DilId=1, KullaniciId=2,YayinEviId=1,YazarId=1,KategoriId=5,ResimId=4 },
                new Kitap(){isim = "II. Abdülhamid", yayin_tarihi="08.05.2009", sayfa_sayisi= 350, ozet = "Ama onlar her zaman o suyun içindedir. Bir zamanlar “dev amca” adında bir adam yaşarmış, güzel, ilginç olan her şeye sahip olmak istermiş eğer elde edemezse ya büyücüye başvurur yad kendi kendine binbir çeşit yol icat edermiş.", fiyat=60, KondisyonId=3, CiltTipiId=1, DilId=1, KullaniciId=1,YayinEviId=2,YazarId=2,KategoriId=4,ResimId=1 },
                new Kitap(){isim = "Sir Jonathan", yayin_tarihi="09.05.2009", sayfa_sayisi= 350, ozet = "Kızların beşi geri dönmeyi ve eski yerinde yaşamayı kabullenirken en küçük kız ise dünyalı bir prense aşık olmuş ve bir an önce onun yanına gitmek istiyormuş. Büyük anneleri haberi duyunca deniz büyücüsüne gidip çözüm aramış", fiyat=18, KondisyonId=3, CiltTipiId=1, DilId=1, KullaniciId=4,YayinEviId=1,YazarId=1,KategoriId=2,ResimId=2 },
                new Kitap(){isim = "Dedektif Gadget", yayin_tarihi="11.05.2009", sayfa_sayisi= 350, ozet = "Prens bunun konuşamıyor olduğunu fark edince kardeşi gibi davranmaya başlamış. Deniz kızı bu duruma çok üzülmüş. Kısa bir süre sonra prens başka biriyle evlenmeye karar vermiş. Durumdan haberdar olan büyük anne büyücüye gidip yardım istemiş.", fiyat=19, KondisyonId=3, CiltTipiId=1, DilId=1, KullaniciId=1,YayinEviId=3,YazarId=2,KategoriId=1,ResimId=5 },
                new Kitap(){isim = "Marvel Evreninde Bir Gün", yayin_tarihi="16.05.2009", sayfa_sayisi= 350, ozet = "Bu gülü kim görürse bir daha hiç mutsuz olmaz ve ölümsüzleşirmiş...", fiyat=15, KondisyonId=2, CiltTipiId=2, DilId=1, KullaniciId=3,YayinEviId=1,YazarId=1,KategoriId=5,ResimId=3 },
                new Kitap(){isim = "Dilenci Numarası Yaptık", yayin_tarihi="18.05.2009", sayfa_sayisi= 350, ozet = "Nasıl olsa üvey annem ve babam anlamaz diyerek sıcacık bir ev hayal ederken kibriti yakarak bitirir. Bu durumu fark edince ne yapacağını şaşırmış, korkmuş ve ölmüş büyük annesinden yardım dilenmeye, seslenmeye başlar.", fiyat=21, KondisyonId=1, CiltTipiId=1, DilId=1, KullaniciId=1,YayinEviId=1,YazarId=5,KategoriId=7,ResimId=5 },
                new Kitap(){isim = "Çok Tehlikeli Oldu", yayin_tarihi="17.05.2009", sayfa_sayisi= 350, ozet = "Durumu krala anlatacağı zaman kapı vurulur. Kapıyı açan kral karşısında sırılsıklam olmuş güzel mi güzel bir kız görür, hemen içeriye alır, kraliçe kızın bir prenses olamayacağını ve kızın asil olmadığını düşünerek prensin kızla evlenmesine karşı çıkar.", fiyat=35, KondisyonId=3, CiltTipiId=1, DilId=1, KullaniciId=2,YayinEviId=2,YazarId=4,KategoriId=1,ResimId=1 },
                new Kitap(){isim = "Boş İşler Müdürü", yayin_tarihi="15.05.2009", sayfa_sayisi= 350, ozet = "Hançeri alan deniz kızı prensin uyuduğu bir akşam kalbine saplamak istemiş. Ancak o sırada uyanan prens tebessüm ederek bana bir şey mi söyleyecektin demiş. Deniz kızı bunu yapamayacağını anlayınca daha fazla dayanamayarak oradan ayrılır.", fiyat=39, KondisyonId=4, CiltTipiId=2, DilId=1, KullaniciId=4,YayinEviId=1,YazarId=3,KategoriId=5,ResimId=2 },
            };
            foreach (var kitap in kitaplar)
            {
                context.Kitaplar.Add(kitap);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}