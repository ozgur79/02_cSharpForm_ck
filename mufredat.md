# Müfredat — WinForms hattı (ck1000-ck1499)

Ders listesi ve kara kutu takip tablosu. Her onaylanan derste bu dosya güncellenir.
Üretim planı ve gerekçeler: `winforms-plan.md`.

## Ders listesi

| ders | konu | ünite | zincir (dil) | zincir (arayüz) | kaynak | durum |
|------|------|-------|---------------|-------------------|--------|-------|
| ck1000_formuTani | Form, Toolbox/Properties, Name verme kuralı, ilk olay (Click), menü formu kurulumu | 05 | — (yeni dil kavramı yok) | Console → WinForms geçişi | eski proje 500WFAbutonTextboxGroupbox + ünite projesi modeli | onaylandı |
| ck1010_ilkOlay | İlk olay: butona çift tıkla, Click gövdesine kod yaz (`this.BackColor`) | 05 | — | `this`, Click olayı | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 1, `500WFAbutonTextboxGroupbox`, button1_Click) | onaylandı |
| ck1020_formNesnesi | Formun kendisi de bir nesne: `this.Left`, `this.Top`, `this.Opacity`, `this.Text` | 05 | — | özellik pekiştirme | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 1, button6/9/5/12/10_Click; Opacity'ye sınır kontrolü eklendi — kaynakta yoktu) | onaylandı |
| ck1030_butonuBuyutSakla | Özellik ile metot farkı: butonu büyüt (özellik), sakla (metot) | 05 | — | özellik vs metot — yeni ayrım | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 2, `501OnArkaSaklaGoster`, button1/3_Click; onaylı numuneden (`ornek/ck1030`) uyarlandı, form adı çakışmayı önlemek için `Ders03`→`Ders04` yapıldı) | onaylandı |
| ck1040_oneAlArkayaGonder | Öne al / arkaya gönder + durumu tutan `bool` (kapsama ilk bakış) | 05 | — | `bool` alan — kapsam ön izlemesi | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 2, button2_Click) | onaylandı |
| ck1050_ozellikleriBirlikte | `Enabled`, `Visible`, `BackColor`, `Size` bir arada | 05 | — | özellik pekiştirme | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 3, `507sizeVisibleColorEnable`; DateTime/MessageBox handler'ı tema dışı olduğu için kullanılmadı) | onaylandı |
| ck1060_odaklanma | Odaklanma: `txtAd.Focus()`, `Clear()` | 05 | — | hazır metot pekiştirme | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 4, `502WFAyazdirOdaklan`; `Select(1,5)` SEN YAP'a taşındı) | onaylandı |
| ck1070_textBoxtanLabela | Veri taşı: TextBox → Label | 05 | — | kontroller arası atama | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 5, `508textBoxıLabeleAktar`) | onaylandı |
| ck1080_textBoxtanMessageBoxa | Veri taşı: TextBox → MessageBox — ünite 05 kapanışı | 05 | — | hazır metot pekiştirme, kapanış | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 6, `509TextBoxtanMessageBoxaAktar`) | onaylandı |
| ck1100_ikiSayiTopla | İki sayıyı topla: Convert.ToInt32 forma taşındı, MessageBox ile göster | 06 | değişken/dönüşüm pekiştirme | — | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 7, `503WFAlabelToplama`; ck1100/1110 için üç kaynak vardı [7,8,9], ck1100/1110'a 7 ve türevi kullanıldı, 8 ck1112'ye taşındı, 9 içerik olarak 7'yle örtüştüğü için ayrı ders yapılmadı) | onaylandı |
| ck1110_sonucuLabelaYaz | Sonucu geri yaz: lblSonuc.Text = toplam.ToString() | 06 | `.ToString()` (Convert'in tersi) | — | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 7'nin devamı, ck1070 ile birleşimi) | onaylandı |
| ck1112_fonksiyonlaToplama | Fonksiyonla toplama (ek pekiştirme — ck1100/1110'un fazlalık kaynağı) | 06 | fonksiyon + form birleşimi | — | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 8, `503WFAmetod_ile`) | onaylandı |
| ck1120_modAlma | Mod alma, kalan | 06 | `%` pekiştirme | — | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 10, `511modAlma`) | onaylandı |
| ck1130_ortalama | Üç sayının ortalaması (double, virgül sorunu, biriktirici + sıfırla) | 06 | biriktirici pekiştirme | — | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 11, `518ortalama`) | onaylandı |
| ck1140_ifIleKarar | if ile karar: girilen boşsa/eşitse uyar (kare mi dikdörtgen mi) | 06 | if/else pekiştirme | — | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 12, `515ifButonLabelTextbox`) | onaylandı |
| ck1150_gizliParola | Gizli parola: PasswordChar, doğru/yanlış kontrolü | 06 | `&&` pekiştirme | — | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 13, `516gizliParola`; gerçek isim/parola yerine ck0240'taki kurgusal `ogrenci`/`kalfa123`) | onaylandı |
| ck1160_butonHesapMakinesi | Buton hesap makinesi (4 buton, 4 işlem) | 06 | operatör pekiştirme | — | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 14, `513butonHesapMak`; `int`→`double` bölme küsuratı için) | onaylandı |
| ck1170_comboBoxIleSecim | ComboBox ile işlem seçimi (SelectedIndex) | 06 | karar zinciri pekiştirme | — | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 15, `512comboboxHesapMak`) | onaylandı |
| ck1180_radioButtonIleSecim | RadioButton ile işlem seçimi (Checked) | 06 | karar pekiştirme | — | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 16, `514radioButonHesapMak`; kaynakta sadece Toplama (radioButton1) tam yazılmıştı, diğer 3 SEN YAP'a bırakıldı) | onaylandı |
| ck1190_forDonguForma | for döngüsünü forma taşı: sonucu Label'a biriktirerek yaz — ünite 06 kapanışı | 06 | döngü + string biriktirme pekiştirme | — | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 17, `520for`) | onaylandı |
| ck1191_kisiselBilgiGorunurluk | Koşula göre bir GroupBox'ı göster/gizle (ek pekiştirme) | 06 | `Visible` + `&&` pekiştirme | — | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 35, `16_2_combobox`; kaynaktaki çok sayıda iç içe koşul tek bir net örneğe indirgendi, `TextChanged`+`try/catch` yerine buton-tetiklemeli tasarıma çevrildi — try/catch henüz öğretilmedi) | onaylandı |
| ck1192_manavAlisverisi | Manav alışverişi: ComboBox + ListBox + biriktirici (ek pekiştirme) | 06 | `ListBox.Items.Add` — yeni kontrol | — | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 40, `19manavAlisverisi`; madde 41 `500alisverisSepeti` neredeyse birebir aynı olduğu için atlandı) | onaylandı |
| ck1193_cepTelefoncuZincirleme | Birbirine bağlı iki ComboBox: marka seçince model listesi değişir (ek pekiştirme) | 06 | `Items.Clear/Add` kod içinde — yeni teknik | — | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 42, `20CepTelefoncu`) | onaylandı |
| ck1194_odemeHesaplayici | Ödeme hesaplayıcı: switch ile taksit — ünite 06 ek pekiştirme kapanışı | 06 | `switch` + yüzde formülü birleşimi, kapanış | — | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 34, `16_1_combobox`; kaynaktaki çok sayıda görünürlük dalı basitleştirildi, `try/catch` yerine `ReadOnly` TextBox ile hata riski önlendi) | onaylandı |

**Ünite 06 tamamlandı (15 ders, ck1100-ck1194).**

## Kara kutu takip tablosu

Bu hattın kendi kutuları (`object sender, EventArgs e`, `partial`, `InitializeComponent()`,
`this`) burada tutulur.

| yapı | ilk göründüğü ders | açılacağı yer | Merak Köşesi günlüğü | not |
|------|----------------------|-------------------|----------------------|-----|
| `public partial class <FormAdı> : Form` | ck1000 | ünite 07 | ck1010: "Form'un yapabildiği her şeyi yapabilir" demek, BackColor/Text/Left/Top bu yüzden çalışıyor (tur 2) | rotasyon sırası 1 |
| `InitializeComponent();` | ck1000 | ünite 07 | ck1020: Designer'da sürüklenen her kontrolü kodun haline getirip formun İLK açıldığı an çalıştırıyor (tur 2) | rotasyon sırası 2 |
| `object sender, EventArgs e` | ck1000 | ünite 07 (ck1240) | ck1030: "sender" = olayı kim başlattı; tek buton varken gerek yok, ck1240'ta beş butona tek kod yazınca lazım olacak (tur 2) | rotasyon sırası 3 |
| `new Ders01_FormuTani().Show();` | ck1000 | ünite 07 (ck1210/ck1290) | ck1070: yeni bir pencere/nesne oluşturup ekrana getiriyor, her derste az önce çizilen formun kopyasını açıyor (tur 2) | rotasyon sırası 4 — menü formunun satırı, her derste tekrar eder |

**Merak Köşesi günlüğü:** ck1000 → **atlandı (ders yüklü)**. ck1010/1020/1030/1070 sırayla
rotasyonun 2. turunu tamamladı (ck1040/1050/1060/1080 kendi yeni fikirleri ağır olduğu
için yük freniyle atladı — ck1040 bool/kapsam ön izlemesi, ck1050/1060/1080 pekiştirme
yoğun). Üçüncü ve son tur ünite 06'da devam edecek.

## Devralınan borç — 01'in kara kutuları

`01_cSharpGiris_ck` Console derslerinde öğrenciye "ünite 07'de açacağız" sözü verilen
kutular. Ünite 07 dersleri yazılırken 01'in `mufredat.md`'sindeki kara kutu tablosuna
bakılır (hangi kutuya ne söylenmiş), açılış gerçekleştiğinde o tablo gerçek ck numarasıyla
güncellenir.

| yapı | söz verilen yer | ödendiği ders |
|---|---|---|
| `using ...` (5 satır) | ünite 07 | ck1280 (planlandı) |
| `namespace` | ünite 07 | ck1260 (planlandı) |
| `class Program` | ünite 07 | ck1260 (planlandı) |
| `static void Main(string[] args)` | ünite 07 | ck1260 (planlandı) |
| `Console.ReadKey();` | ileride ayrı bir derste | henüz planlanmadı |
