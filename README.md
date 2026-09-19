# C# Form (WinForms) — Lise Müfredatı

Lise (9-12. sınıf) Bilişim Teknolojileri/meslek dersi için Windows Form Application
müfredatı. Buton, metin kutusu, liste, zamanlayıcı — ve bunların hepsinin altında yatan
**nesne tabanlı programlama**.

> **Ön koşul: [01_cSharpGiris_ck](https://github.com/ozgur79/01_cSharpGiris_ck)**
> Bu derslerde değişken, operatör, karar yapısı (`if`), döngü (`for`, `while`), dizi,
> fonksiyon ve `Convert.ToInt32` bilindiği varsayılır. Console derslerini bitirmeden
> buraya başlama — burada yeni olan dil değil, **yüzey**.

## Nasıl kullanılır

Bu müfredatta **ders başına yeni proje açılmaz.** Her ünite için bir kez proje açarsın,
her ders o projeye yeni bir form ekler:

1. Ünitenin ilk dersinde Visual Studio'da bir **Windows Forms Application** aç, adını
   ünitenin adı yap (`Unite05` gibi).
2. Her derste `Project > Add Windows Form` ile dersin istediği adda yeni bir form ekle.
3. Ders klasöründeki `kurulum.md`'yi izle: hangi kontrolü sürükleyeceğin, ne ad vereceğin,
   hangi olaya çift tıklayacağın orada yazıyor.
4. `kod.cs`teki blokları, açılan olay gövdelerinin **içine** yapıştır.
5. `Form1` senin menü formun: her derse bir buton ekle, butonun içine tek satır yaz —
   `new Ders03_BuyuSakla().Show();`
6. `degerlendirme.md`'deki soruları çalış — dersi gösterdikten sonra sorulacak.

Ünite bitince elinde boş klasörler değil, menüsünden bütün derslerine girilebilen
**çalışan tek bir uygulama** kalır.

Bu repoda proje dosyası (`.sln`/`.csproj`/`.Designer.cs`) yoktur — sadece yapıştıracağın
kod parçaları. Proje her zaman senin kendi Visual Studio'nda oluşturulur.

## Üniteler

| ünite | konu | durum |
|---|---|---|
| 05 (ck1000-ck1099) | Form ve nesne ile tanışma — buton, metin kutusu, etiket, olay | yayında |
| 06 (ck1100-ck1199) | Formda hesap ve karar — Console'da öğrendiğinin forma taşınması | planlandı |
| 07 (ck1200-ck1299) | Nesne tabanlı programlama girişi — `new`, sınıf, nesne, kapsam | planlandı |
| 08 (ck1300-ck1399) | Zaman ve olay — Timer, fare olayları, küçük oyunlar | planlandı |
| 09 (ck1400-ck1499) | Liste, görsel, çok formlu uygulama + bitirme projesi | planlandı |

## Ders sırası

| # | proje adı | konu | durum |
|---|-----------|------|-------|
| 1 | ck1000_formuTani | Form, Toolbox/Properties, Name kuralı, ilk olay, menü formu | yayında |
| 2 | ck1010_ilkOlay | İlk olay: butona basınca formun rengini değiştir | yayında |
| 3 | ck1020_formNesnesi | Formun kendisi de bir nesne (Left/Top/Opacity/Text) | yayında |
| 4 | ck1030_butonuBuyutSakla | Özellik ile metot farkı (büyüt/sakla) | yayında |
| 5 | ck1040_oneAlArkayaGonder | Öne al / arkaya gönder + bool durum | yayında |
| 6 | ck1050_ozellikleriBirlikte | Enabled/Visible/BackColor/Size bir arada | yayında |
| 7 | ck1060_odaklanma | Odaklanma: Focus() ve Clear() | yayında |
| 8 | ck1070_textBoxtanLabela | Veri taşı: TextBox → Label | yayında |
| 9 | ck1080_textBoxtanMessageBoxa | Veri taşı: TextBox → MessageBox (ünite 05 kapanışı) | yayında |

(Sıradaki dersler için plan: `winforms-plan.md`.)

## Lab ortamı

Okul laboratuvarı: Windows 8 + Visual Studio 2013. Dersler sürüme bağlı yazılmaz; daha
yeni bir Visual Studio'da da aynı adımlar geçerlidir.
