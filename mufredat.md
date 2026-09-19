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

| ck1200_perdeyiKaldir | Perdeyi kaldır: Designer.cs'i oku, kontrollerin arkasındaki `new`+`Controls.Add`'i gör — ünite 07 açılış | 07 | — | `new` (kontroller için) — gözlem | (kaynak yok — ck kendi tasarımı, Designer.cs okuması) | onaylandı |
| ck1210_kendiButonunuUret | Kendi butonunu kod ile üret: `new Button()`, `Click +=` ilk kez | 07 | — | `+=` ile olay bağlama — ilk kez | (kaynak yok — ck kendi tasarımı) | onaylandı |
| ck1220_konumlandirVeYazi | Ürettiğin butonu konumlandır, yazısını ver | 07 | — | özellik = nesnenin sıfatı | (kaynak yok — ck kendi tasarımı) | onaylandı |
| ck1230_forIleBesButon | `for` ile 5 buton üret: aynı sınıftan çok nesne, her biri kendi özelliğini taşır | 07 | döngü + dizi zinciri (ck0670) pekiştirme | sınıf/nesne ayrımı | (kaynak yok — ck kendi tasarımı) | onaylandı |
| ck1240_tekOlaySenderIle | Hepsine tek olay bağla, `sender` ile hangisine basıldığını bul — `object sender, EventArgs e` kapanır | 07 | cast (ck0650/ck0790) pekiştirme | olay + nesne kimliği | (kaynak yok — ck kendi tasarımı) | onaylandı |
| ck1250_alanVsYerelDegisken | Kapsam dersi: sayacı handler içinde tanımla → sıfırlanıyor, sınıf seviyesine taşı → hatırlıyor | 07 | — | alan (field) vs yerel değişken | (kaynak yok — ck kendi tasarımı; ck1040'ın kapsam ön izlemesine bağlanır) | onaylandı |
| ck1260_iskeletKapaniyor | `namespace`, `class Program`, `static Main`, `partial`, `InitializeComponent()` — beş kutu birden kapanıyor | 07 | — | **iskelet kutuları kapanır** (Console'dan devralınan 3 + bu hattın kendi 2 kutusu) | (kaynak yok — ck kendi tasarımı, Program.cs + Form1.cs okuması) | onaylandı |
| ck1270_kendiSinifinOgrenci | Kendi sınıfın: `class Ogrenci` (ad, numara, `Tanit()`), iki bağımsız nesne üret | 07 | — | kendi sınıfını yazma | (kaynak yok — ck kendi tasarımı) | onaylandı |
| ck1280_usingKapaniyor | `using System.Windows.Forms;` satırını sil, ne bozuluyor gör — `using` kutusu kapanır | 07 | — | **`using` kara kutusu kapanır** | (kaynak yok — ck kendi tasarımı, deneysel gözlem) | onaylandı |
| ck1290_cokFormluUygulama | Çok formlu uygulama: ünite başından beri yaptığın `new DersXX().Show();`in adı buymuş — ünite 07 kapanış | 07 | — | nesne üretmenin gerçek kullanımı, kapanış | (kaynak yok — ck kendi tasarımı) | onaylandı |
| ck1295_formGosterGizle | Form göster/gizle: `Hide()`/`Show()` ile iki form arasında geçiş (ek pekiştirme) | 07 | — | `Hide()` — yeni hazır metot | arsiv/14cSharpFormÇekirdekKodlar.txt (madde 39, `001formKolay/30_formlar_arasi_gecis`) | onaylandı |

**Ünite 07 tamamlandı (11 ders, ck1200-ck1295) — nesne tabanlı programlama girişi,
Console'un ve bu hattın kendi iskelet kutularının kapandığı ünite.**

## Kara kutu takip tablosu

Bu hattın kendi kutuları (`object sender, EventArgs e`, `partial`, `InitializeComponent()`,
`this`) burada tutulur.

| yapı | ilk göründüğü ders | açılacağı yer | Merak Köşesi günlüğü | not |
|------|----------------------|-------------------|----------------------|-----|
| `public partial class <FormAdı> : Form` | ck1000 | ck1260 (**kapandı**) | ck1010 (tur 2): "Form'un yapabildiği her şeyi yapabilir" demek. ck1260 (tur 3, **emekli**): `partial` iki dosyayı (Designer.cs/Form1.cs) tek sınıfta birleştirir, `: Form` miras kutusu | rotasyon sırası 1 |
| `InitializeComponent();` | ck1000 | ck1260 (**kapandı**) | ck1020 (tur 2): Designer'da sürüklenen her kontrolü kodun haline getirip formun İLK açıldığı an çalıştırıyor. ck1260 (tur 3, **emekli**): Form1() constructor'ının içinde, form ekrana gelmeden hemen önce çağrıldığı gösterildi | rotasyon sırası 2 |
| `object sender, EventArgs e` | ck1000 | ck1240 (**kapandı**) | ck1030 (tur 2): "sender" = olayı kim başlattı. ck1240 (tur 3, **emekli**): 5 butona tek kod yazınca `(Button)sender` cast'iyle hangisine basıldığı bulundu | rotasyon sırası 3 |
| `new Ders01_FormuTani().Show();` | ck1000 | ck1290 (**kapandı**) | ck1070 (tur 2): yeni bir pencere/nesne oluşturup ekrana getiriyor. ck1290 (tur 3, **emekli**): desenin adı "çok formlu uygulama" — sınıf/nesne bilgisiyle geriye dönük açıklandı | rotasyon sırası 4 — menü formunun satırı, her derste tekrar eder |

**Merak Köşesi günlüğü:** ck1000 → **atlandı (ders yüklü)**. ck1010/1020/1030/1070 tur 2'yi
tamamladı (ck1040/1050/1060/1080 yük freniyle atladı). Ünite 06'da tur 3 için uygun bir
ders çıkmadı (tüm ünite 06 dersleri kendi pekiştirme yüküyle doluydu) — üçüncü tur ünite
07'nin kendi kapanış derslerine (ck1240, ck1260, ck1290) taşındı; oradaki kapanışlar hem
tur 3 hem resmi emeklilik oldu. **Rotasyonun 4 kutusu da artık emekli, ünite 07 sonunda
hiçbiri geriye kalmadı.**

## Devralınan borç — 01'in kara kutuları

`01_cSharpGiris_ck` Console derslerinde öğrenciye "ünite 07'de açacağız" sözü verilen
kutular. Ünite 07 dersleri yazılırken 01'in `mufredat.md`'sindeki kara kutu tablosuna
bakılır (hangi kutuya ne söylenmiş), açılış gerçekleştiğinde o tablo gerçek ck numarasıyla
güncellenir.

| yapı | söz verilen yer | ödendiği ders |
|---|---|---|
| `using ...` (5 satır) | ünite 07 | ck1280 (**ödendi**) |
| `namespace` | ünite 07 | ck1260 (**ödendi**) |
| `class Program` | ünite 07 | ck1260 (**ödendi**) |
| `static void Main(string[] args)` | ünite 07 | ck1260 (**ödendi**) |
| `Console.ReadKey();` | ileride ayrı bir derste | henüz planlanmadı |

**Not:** `01_cSharpGiris_ck/mufredat.md`'deki kara kutu tablosu bu dört satır için de
gerçek ck numarasıyla (ck1260/ck1280) güncellenmeli — bkz. backlog.md.
