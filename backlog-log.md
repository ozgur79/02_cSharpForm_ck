# Backlog geçmişi

Append-only. Hiçbir madde silinmez.

## 2026-09-05 — proje kuruldu
`01_cSharpGiris_ck` ikiye bölündü: Console 01'de kaldı, WinForms + nesne tabanlı
programlama bu projeye ayrıldı (Ev'de Tasarım Karar 19). Ortak ck kimliği ve değişmeyen
kurallar üst klasöre taşındı (`D:\Atolye\cSharp\CLAUDE.md`); bu projenin `CLAUDE.md`'si
sadece kendi kapsamını yazar. `winforms-plan.md` ve `ornek/ck1030_butonuBuyutSakla/`
01'den buraya taşındı. Numaralandırma sıfırlanmadı: ck1000'den devam eder.

## 2026-09-19 — numara alanı kaydı (ck0500-0999 → ck1000-1499)
01'in numara alanı (ck0000-ck0499), 01'in kendi dil zincirine ait yeni bir arşiv parçasıyla
(`12cSharpÇekirdekKodlar.txt`, 61 madde — while/do-while/switch/dizi/fonksiyon/random/
zamanlama/renk) fiilen doldu. Özgür 01'i ck0000-ck0999'a genişletmeyi, 02'yi ck1000'den
başlatmayı onayladı. Bu projenin tek dersi `ck0500_formuTani` → `ck1000_formuTani`,
numunesi `ornek/ck0530_butonuBuyutSakla` → `ornek/ck1030_butonuBuyutSakla` olarak `git mv`
ile (geçmiş korunarak) yeniden adlandırıldı; `winforms-plan.md`, `mufredat.md`, `README.md`,
`backlog.md`, `kimlik_ck_form.txt`, `CLAUDE.md`/`AGENTS.md` içindeki tüm ck05xx-ck09xx
numaraları +500 kaydırıldı (ünite sırası ve aralık genişlikleri aynı kaldı). Henüz üretim
başlamadığı için (Durum: "Üretim beklemede") içerik değişmedi, sadece numaralar kaydı.

## 2026-09-19 — Ünite 07 tamamlandı (11 ders, ck1200-ck1295)

Nesne tabanlı programlama girişi. Özgür arsiv/14 için "Hiç durma, hepsini üret" dedi —
tüm ünite kesintisiz üretildi, kaynak zaten arsiv/14'ten neredeyse tükenmişti; ck1200-1290
(10 ders) ck'nin kendi tasarımı (arsiv kaynağı yok, sıra dil/arayüz zincirinden geldi),
sadece ck1295 arsiv/14'ten (madde 39, `001formKolay/30_formlar_arasi_gecis`).

Bu ünite hem bu hattın kendi iskelet kutularını (`partial class : Form`,
`InitializeComponent()`, `object sender`, `new DersXX().Show();`) hem Console'dan
devralınan borcu (`using`, `namespace`, `class Program`, `static Main`, `Console.ReadKey`)
kapattı — hepsi rotasyonun 3. turuyla aynı derste, resmi emeklilikle birleşti:
- `object sender, EventArgs e` → ck1240 (5 butona tek Click, `(Button)sender` cast'i)
- `partial class : Form`, `InitializeComponent()`, `namespace`, `class Program`,
  `static Main` → ck1260 (Program.cs + Form1.cs okuması, tek derste 5 kutu)
- `using ...` → ck1280 (satır silinip derlenerek deneysel gösterim)
- `new DersXX().Show();` → ck1290 (desenin adı "çok formlu uygulama" olarak kondu)
- `Console.ReadKey();` için WinForms'ta neden karşılığı OLMADIĞI ck1260'ta ayrıca
  açıklandı (`Application.Run` formu açık tuttuğu sürece programın kapanmaması)

`01_cSharpGiris_ck/mufredat.md`'deki kara kutu tablosu bu 5 satır için gerçek numaralarla
(`02_cSharpForm_ck/ck1260`, `ck1280`) güncellendi — Console tarafındaki kod.cs dosyalarında
sahte numara zaten kullanılmadığı için (hep genel "ünite 07" dendiği için) geriye dönük
kod.cs düzeltmesi gerekmedi.

`ck1250_alanVsYerelDegisken` alan/yerel değişken kapsam dersini SEN YAP'ta bizzat
deneyerek (sayacı önce alan, sonra yerel yapıp farkı gözlemleyerek) işledi — ck0040'taki
`bool` alanının kapsam ön izlemesine geri bağlandı.

`ck1270_kendiSinifinOgrenci`, öğrencinin ilk kez BAŞKASININ değil KENDİ sınıfını
(`class Ogrenci`) yazdığı ders — `new Button()`/`new Form2()` alışkanlığının `new
Ogrenci()`ye taşındığı kapanış noktası.

`mufredat.md`, `README.md` güncellendi (ünite 07 "yayında"). Hiçbiri `dotnet run` ile
test edilemedi (WinForms) — doğrulama sadece kod okuması ve derleme mantığıyla yapıldı,
gerçek test Özgür'ün elle tıklamasını bekliyor (`Test-Gunlugu.md`).

## 2026-09-19 — Ünite 08 tamamlandı (11 ders, ck1300-ck1395)

Zaman ve olay: Timer, fare olayları. arsiv/14 madde [28]/[29] çakışması "sen seç" ile
çözüldü — ikisi (`522butonileHizKontrolu` ve `...MOD_KULLANMADAN`) TAMAMEN aynı kod
olduğu için [28] kullanıldı, [29] atlandı (bonus derse taşınacak fark yoktu).

Kaynak sadıklığı ve sapmalar:
- ck1300 kaynağı (madde 18) Timer'ı MouseMove tabanlı bir oyunla karıştırıyordu — ilk
  Timer dersi olduğu için sadece Timer ayrıştırıldı, mouse kısmı zaten ck1360'a planlıydı.
- ck1350 kaynağının (madde 23/24) `%` tabanlı mantığı hem hatalı hem kod-yorum çelişkiliydi
  (yorumda "yeşil" yazan blok kırmızı/beyaz atıyordu) — basit eşik sayacıyla
  (`sayac==3/4/6`) baştan, doğru ve anlaşılır şekilde yazıldı.
- ck1380 kaynağı (madde 27) `Random` ile butonu rastgele konuma taşıyordu — Random
  ck1420'ye kadar yasak olduğu için bu kısım kaldırıldı; ders başlığı zaten sadece
  "göster/gizle" dediği için içerik kaybı olmadı.
- ck1390'ın kaynağında (madde 28) alt sınır kontrolü YOKTU (Interval sıfıra/eksiye
  düşüp çökebilirdi) — bu eksiklik silinmedi, SEN YAP'a çevrilip öğrenciye buldurtuldu.
- ck1395 (ek pekiştirme, madde 44) kaynağındaki "sende iş yok" gibi sert bir ifade
  "Üzgünüz, cevap yanlış" olarak yumuşatıldı — lise hedef kitlesi kuralı.

`mufredat.md`, `README.md` güncellendi (ünite 08 "yayında"). Hiçbiri test edilemedi
(WinForms) — gerçek test Özgür'ün elle tıklamasını bekliyor.

## 2026-09-19 — Ünite 09 temel dersleri tamamlandı (9 ders, ck1400-ck1458)

Liste, görsel, Random'ın gerçek çıkışı. arsiv/14'ün numaralı maddeleri artık TÜKENDİ —
her madde ya bir derse dönüştü ya da (madde 29 tam kopya, madde 36/41/43 daha önce ünite
06'da elenmişti) neden atlandığı kayıtlı.

Kaynak sadıklığı ve sapmalar:
- ck1400/1410/1420, madde 30'un (`526listbox_if_random`) TEK kodunu üç aşamalı derse
  bölüyor: önce sade `Items.Add` (1400), sonra `RemoveAt`/`SelectedIndex` ile elle silme
  (1410, kaynakta yok — ck'nin kendi tasarımı, kavramsal ara basamak), sonunda kaynağın
  asıl fikri olan Random'lı kura çekme (1420) — Random'ın ck0530'dan beri ertelenen GERÇEK
  ilk kullanımı burada.
- ck1440 kaynağı (madde 32) 3 PictureBox'ı karşılaştırıp "kaçı aynı" diyen bir oyundu —
  tek PictureBox'ta "sonraki resim" mantığına indirgendi, resim dosyaları repo'ya
  girmediği için (proje dosyası yasağı) öğrenci kendi resimlerini ImageList'e ekliyor.
- ck1450 kaynağı (madde 33) 3 PictureBox + 3 ayrı Timer'lı bir slot makinesiydi — aynı
  fikrin 3 katı tekrarı yeni bir kavram katmadığı için TEK PictureBox + TEK Timer'a
  indirgendi, ck1440'ın index mantığı + Timer + ck1330'un durdur/devam deseni birleşti.
- ck1454 kaynağının (madde 38) hak sayma mantığı BOZUKTU — doğru tahminde de `hak`
  artıyor, form hiç kapanmıyordu; düzeltilip `this.Close()` ile temiz bir bitiş eklendi.
- ck1458 (madde 45, `900hastarandevu`) kaynağı ÇOK karmaşıktı (2D dizi, T.C. doğrulama,
  DateTimePicker, sıra/çağırma sistemi, ~100 satır) — sadece "ad+poliklinik kaydet, iki
  ListBox'ı senkron tut" fikri bırakılıp geri kalanı atıldı; bu ünitenin hedef kitlesine
  (henüz 2D dizi görmemiş öğrenciler) uygun tek katmanlı bir versiyon.

**Açık karar — bitirme projesi (ck1460-ck1490) ÜRETİLMEDİ.** winforms-plan.md'nin
tanımı ("öğrenci kendi uygulamasını üretir, menü + 3 form") somut bir kapsam/rubric
içermiyor; "bitti" tanımını Özgür koyduğu için içerik üretilmeden Özgür'le netleştirilmesi
bekleniyor (bkz. `backlog.md`).

`mufredat.md`, `README.md` güncellendi (ünite 09 temel dersler "yayında", bitirme
"bekliyor"). Hiçbiri test edilemedi (WinForms) — gerçek test Özgür'ün elle tıklamasını
bekliyor.
