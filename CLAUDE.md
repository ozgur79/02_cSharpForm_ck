# 02_cSharpForm_ck — WinForms hattı

> **Önce şunu oku:** `D:\Atolye\cSharp` kökündeki kimlik dosyası — `AGENTS.md` (Codex) ya da
> `CLAUDE.md` (Claude); ikisinin ortak gövdesi aynıdır. csharpKalfa'nın kuralları orada yaşar,
> burada tekrar edilmez. O dosya da Kalfa'nın kuralları için `D:\Atolye` kökündeki kimlik
> dosyasına yönlendirir; zinciri eksiksiz izle. Bu dosya onun üstüne biner, onu yalanlamaz.
> Bazı araçlar üst dizinlerin kimlik dosyalarını kendiliğinden yüklemez — görmüyorsan
> **elle aç ve oku**, bu işin ilk adımıdır.

Kimlik, sert sınırlar, ders üretim döngüsü, isimlendirme ve **kara kutu doktrini** üst
klasördeki kimlik dosyasında (`D:\Atolye\cSharp\CLAUDE.md` / `D:\Atolye\cSharp\AGENTS.md`). Burada tekrar edilmez. Bu dosya sadece bu projenin
kendi kapsamını yazar.

## Kapsam

**ck1000-ck1499, ünite 05-09, WinForms (Windows Form Application) + nesne tabanlı
programlama.** Ön koşul: `01_cSharpGiris_ck` tamamlanmış olmak — öğrenci değişken, operatör,
karar yapısı, döngü, dizi, fonksiyon ve `Convert.ToInt32`'yi Console'da öğrenmiş varsayılır.
Numaralandırma sıfırlanmaz, 01'in bittiği yerden (ck1000) devam eder.

| ünite | ck aralığı | konu |
|---|---|---|
| 05 | ck1000-ck1099 | Form ve nesne ile tanışma |
| 06 | ck1100-ck1199 | Formda hesap ve karar (Console bilgisinin forma taşınması) |
| 07 | ck1200-ck1299 | **Nesne tabanlı programlama girişi — Console'un kara kutuları burada kapanır** |
| 08 | ck1300-ck1399 | Zaman ve olay (Timer, fare) |
| 09 | ck1400-ck1499 | Liste, görsel, çok formlu uygulama |

Ders ders plan ve gerekçeler: `winforms-plan.md`. Kaynak: Özgür'ün eski derslerindeki
500-529 numaralı projeler (`E:\11OkulDesler2026\01NTP\Projects-2024-DersteAnlatılanlar`).

**Devraldığın borç:** 01'deki Console dersleri boyunca öğrenciye "ünite 07'de açacağız"
diye söz verilen kara kutular — `using`, `namespace`, `class Program`, `static Main`,
`Console.ReadKey`. Bu sözü ünite 07 öder. 01'in `mufredat.md`'sindeki kara kutu tablosu
hangi kutuya ne söylendiğinin kaydıdır; ünite 07 dersleri yazılırken oraya bakılır ve
açılış gerçekleştiğinde o tablodaki "açılacağı yer" gerçek numarayla güncellenir.

## Teslim modeli: ünite başına tek proje, ders başına form

Öğrenci **ders başına yeni proje açmaz** — ünite başına bir kez açar (`Unite05`), her ders
o projeye `Add > Windows Form` ile yeni bir form ekler (`Ders03_BuyuSakla.cs`). `Form1`
menü formudur; her ders için bir buton taşır, butonun kodu `new Ders03_BuyuSakla().Show();`.

Gerekçe: ders başına bir proje = klasör + `.sln` + `.suo` + `bin` + `obj` yığını (eski
arşivde 171 klasör var, Özgür "modern değil" dedi). Bu modelde ünite sonunda öğrencinin
elinde boş klasörler değil **çalışan tek bir uygulama** kalır; ayrıca menüdeki
`new ...().Show();` satırı ünite 07'deki nesne üretme dersinin provası olur.

Bilinen bedeli: bir formdaki derleme hatası ünitedeki bütün formları durdurur. `kurulum.md`
gerektiğinde `Exclude From Project` ile hatalı formu geçici çıkarmayı öğretir.

## WinForms ders şablonu (istisnasız — üç dosya)

Onaylanmış numune: `ornek/ck1030_butonuBuyutSakla/` (Özgür 2026-09-05'te inceledi ve
onayladı). Biçim tartışması kapandı; yeni ders üretirken oradaki üç dosya kopyalanıp
doldurulur.

**1. `kurulum.md`** — beş bölüm, sırası sabit:
- **Senaryo** — öğrencinin ne yapacağını anlatan 2-3 cümle, terim yok.
- **Hazırlık** — hangi ünite projesine hangi adla form eklenecek
  (`Project > Add Windows Form` → `Ders03_BuyuSakla`), sonra kontrol tablosu:

  | kontrol | Name | Text |
  |---|---|---|

  `Name` **her zaman** verilir; `button1` bırakılmaz. Önek kuralı: `btn` / `txt` / `lbl` /
  `cmb` / `rdb` / `lst` / `pic` / `tmr`.
- **Hangi event** — hangi kontrole çift tıklanacak, hangi gövdeye hangi blok gidecek.
- **Menü formuna ekle** — `Form1`e eklenecek buton + tek satır:
  `new Ders03_BuyuSakla().Show();` (teslim modelinin gereği, her derste tekrarlanır).
- **Çalıştı mı?** — Özgür'ün elle deneyeceği 2-4 maddelik kontrol listesi. `Test-Gunlugu.md`'ye
  aynen geçer; boş bırakılamaz, çünkü WinForms dersinin "bitti"si Özgür'ün tıklamasıyla
  tanımlıdır.

**2. `kod.cs`** — Console şablonuyla aynı iskelet (başlık + KAVRAM + SEN YAP + MERAK KÖŞESİ),
üç farkla:
- **Tam dosya yok, sadece handler gövdeleri.** Her blok hangi gövdeye gideceğini kendi
  söyler: `// >>> btnBuyu_Click gövdesinin içine:`
- **Çerçeve notu WinForms'a göre değişir.** Console'un `using/namespace/class/Main`'i yerine:
  `public partial class <FormAdı> : Form` ve `InitializeComponent();`.
- **Merak Köşesi'nin WinForms kutuları:** `object sender, EventArgs e` · `partial` ·
  `InitializeComponent()` · `this`. Rotasyon ve üç-tur freni burada da geçerli.

**3. `degerlendirme.md`** — 1-3 soru + Özgür için cevap notu. En az bir soru **"neden böyle
oldu"** tipinde olmalı, "ne yazdın" tipinde değil. Öğrencinin sık yaptığı hata biliniyorsa
bir soru onu yoklar.

**`SEN YAP` kuralı (WinForms'a özel):** maddelerden en az biri öğrenciye **kendi kontrolünü
ekletir** (yeni buton/label koydurur). Sadece var olan satırı değiştirmek yetmez — forma
kontrol eklemek WinForms'ın asıl becerisi, her derste tekrarlanmalı.

## Doğrulama

Console'dan farkı: ck formu tıklayamaz. ck'nin işi kodun **derlendiğini** doğrulamak;
"gerçekten çalıştı mı" kararı Özgür'ün, `Test-Gunlugu.md`'ye o yazar. ck "test ettim"
demez, "yazdım, teste hazır" der.

## Durum

**Üretim beklemede** (2026-09-05, Özgür'ün kararı): plan ve numune hazır, ders üretimi
Özgür başlat diyene kadar başlamaz. Console hattı (01) devam ediyor.

**2026-09-19 numara kayması.** 01'in numara alanı (ck0000-ck0499) yeni bir arşiv parçasıyla
doldu; Özgür 01'i ck0000-ck0999'a genişletti, 02 ck1000'den başlayacak şekilde kaydı. Bu
projenin o ana kadarki tek dersi `ck0500_formuTani` → `ck1000_formuTani`, numunesi
`ornek/ck0530_butonuBuyutSakla` → `ornek/ck1030_butonuBuyutSakla` olarak yeniden adlandırıldı
(git mv, geçmiş korunarak). Tüm ck05xx-ck09xx referansları +500 kaydırıldı (ck05→ck10,
ck06→ck11, ck07→ck12, ck08→ck13, ck09→ck14) — ünite sırası/aralık genişlikleri değişmedi.

## Klasörler

Ortak dosya setine ek olarak:
- `winforms-plan.md` — ünite 05-09 ders listesi, onaylı üretim planı.
- `ornek/` — format numunesi. Öğrenciye gitmez, `mufredat.md`'ye girmez, ders sayılmaz.
