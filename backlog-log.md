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
