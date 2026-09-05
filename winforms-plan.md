---
title: WinForms müfredat önerisi (ünite 05-09)
created: 2026-09-05
status: onaylandı (2026-09-05) — üretim planı
---

# WinForms müfredatı — üretim planı

Özgür 2026-09-05'te dört kararı da onayladı: ünite başına tek proje · iskelet kutuları
ünite 07'de açılır · rotasyon freni (3 tur) · OOP'ta önce Button sonra kendi sınıfın.

Kaynak: `E:\11OkulDesler2026\01NTP\Projects-2024-DersteAnlatılanlar` içindeki **500-529**
numaralı 33 WinForms projesi (Özgür'ün önceki yıllarda derste fiilen anlattıkları) +
Console tarafında ck0010-ck0080 ile kurulan zincir.

## 0. Numaralandırma: eski klasör numaraların zaten müfredat

Özgür'ün eski numaralandırması ile ck numaralandırması birebir örtüşüyor — 500'ler WinForms,
700 OOP. Ünite haritası:

| ünite | ck aralığı | konu |
|---|---|---|
| 00-04 | ck0000-ck0499 | Console (mevcut hat) |
| **05** | ck0500-ck0599 | Form ve nesne ile tanışma |
| **06** | ck0600-ck0699 | Formda hesap ve karar |
| **07** | ck0700-ck0799 | **Nesne tabanlı programlama girişi** (kara kutular burada kapanır) |
| **08** | ck0800-ck0899 | Zaman ve olay (Timer, fare) |
| **09** | ck0900-ck0999 | Liste, görsel, çok formlu uygulama |

Sıra bilinçli: **Timer ve Random, OOP'tan sonra**. Çünkü `timer1.Start()` ve
`Random rnd = new Random();` satırları nesne bilgisi olmadan ezberdir; ünite 07'den sonra
tanıdık olurlar. Eski 506 ve 526 projeleri tam olarak bu iki satırla başlıyor.

## 1. Öğrenci tarafındaki klasör sorunu

Bugünkü model: ders başına bir VS projesi = `.sln` + `.suo` + `.csproj` + `bin/` + `obj/`
+ bazen `Backup/` + `UpgradeLog.htm`. 100 WinForms dersi = 100 klasör, binlerce dosya.
Eski arşivde 171 klasör var; sorun orada gözle görülüyor.

**Karar: ünite başına tek proje, ders başına yeni Form.**
Öğrenci ünite 05 için bir kez `Unite05` projesi açar; her ders `Add > Windows Form` ile
`Ders01_Tikla.cs`, `Ders02_Odaklan.cs` ekler. `Form1` bir **menü formu** olur, her derse bir
buton. Ünite bitince öğrencinin elinde 12 boş klasör değil, **çalışan tek bir uygulama**
kalır — sunulabilir, GitHub'a atılabilir, veliye gösterilebilir.

Kazanç üç katlı:
1. 100 klasör yerine 5 klasör.
2. Menü formundaki `new Ders01_Tikla().Show();` satırı, ünite 07'deki nesne üretme dersinin
   provası olur — öğrenci kavramı öğrenmeden önce eliyle yapmış olur.
3. `bin/obj` şişkinliği tek yerde kalır, `.gitignore` ile temizlenir.

**Bedeli dürüstçe:** aynı projedeki bir formda derleme hatası varsa ünitedeki diğer formlar
da çalışmaz. Lab'da bir öğrenci takılırsa dersin geri kalanı kilitlenebilir. Hafifletme:
hatalı form geçici olarak projeden çıkarılabilir (`Exclude From Project`) — bu da
öğretilebilir bir beceri.

Repo tarafı değişmez: ck yine **proje dosyası push etmez**, sadece `kurulum.md` + `kod.cs`.

## 2. Ünite 05 — Form ve nesne ile tanışma (ck0500-ck0599)

Amaç: "Sürüklediğin her şey bir **nesne**." Terim verilmez, deneyimletilir.

| ck | konu | kaynak | çekirdek |
|---|---|---|---|
| ck0500 | Formu tanı: Toolbox, Properties, Name verme kuralı (`btnTikla`, `txtSayi`, `lblSonuc`) | 500 | — |
| ck0510 | İlk olay: butona çift tıkla, `Click` gövdesine kod yaz | 500 | `this.BackColor = Color.Red;` |
| ck0520 | Formun kendisi de bir nesne: `this.Left`, `this.Top`, `this.Opacity`, `this.Text` | 500 | `this.Top -= 10;` |
| ck0530 | **Özellik ile metot farkı**: butonu büyüt (özellik), sakla (metot) | **501** | `button1.Height = 100;` / `button3.Hide();` |
| ck0540 | Öne al / arkaya gönder + durumu tutan `bool` | **501** | `SendToBack()` / `BringToFront()` |
| ck0550 | `Enabled`, `Visible`, `BackColor`, `Size` bir arada | 507 | — |
| ck0560 | Odaklanma: `txtAd.Focus()`, `Clear()` | 502 | — |
| ck0570 | Veri taşı: TextBox → Label | 508 | `lblSonuc.Text = txtAd.Text;` |
| ck0580 | Veri taşı: TextBox → MessageBox | 509 | `MessageBox.Show(txtAd.Text);` |

Ünite sonu: menü formu + 9 form, tek projede.

## 3. Ünite 06 — Formda hesap ve karar (ck0600-ck0699)

Amaç: Console'da öğrenilen her şeyin (dönüşüm, operatör, `if`, `for`) forma taşınması.
Yeni dil kavramı yok — **arayüz değişti, dil aynı kaldı**. "Az zamanda çok şey" hedefinin
en verimli ünitesi: öğrenci yeni bir şey öğrenmiyor, bildiğini yeni bir yüzeyde kullanıyor.

| ck | konu | kaynak |
|---|---|---|
| ck0600 | İki sayıyı topla: `Convert.ToInt32(txtSayi1.Text)` — Console'daki dönüşümün aynısı | 503, 510 |
| ck0610 | Sonucu geri yaz: `lblSonuc.Text = toplam.ToString();` | 503 |
| ck0620 | Mod alma, kalan | 511 |
| ck0630 | Üç sayının ortalaması (`double`, virgül sorunu) | 518 |
| ck0640 | `if` ile karar: girilen boşsa uyar | 515 |
| ck0650 | Gizli parola: `PasswordChar`, doğru/yanlış kontrolü | 516 |
| ck0660 | Buton hesap makinesi (4 buton, 4 işlem) | 513 |
| ck0670 | ComboBox ile işlem seçimi (`SelectedIndex`) | 512 |
| ck0680 | RadioButton ile işlem seçimi (`Checked`) | 514 |
| ck0690 | `for` döngüsünü forma taşı: sonucu Label'a biriktirerek yaz | 520 |

## 4. Ünite 07 — Nesne tabanlı programlama girişi (ck0700-ck0799)

**Console hattı boyunca Merak Köşesi'nde biriktirilen kara kutuların kapandığı yer.**
Perde tek seferde değil, sırayla kalkar.

| ck | ders | ne açılır |
|---|---|---|
| ck0700 | **Perdeyi kaldır:** `Form1.Designer.cs`'i aç, `this.button1 = new System.Windows.Forms.Button();` satırını göster. "Sürüklediğin her buton için VS bu satırı senin yerine yazmış." | `new` |
| ck0710 | Aynı satırı **sen yaz**: kod ile buton üret, forma ekle (`Controls.Add`) | nesne üretme |
| ck0720 | Ürettiğin butonu konumlandır, yazısını ver | özellik = nesnenin sıfatı |
| ck0730 | `for` ile 5 buton üret — **aynı sınıftan çok nesne, her biri kendi özelliğini taşır** | sınıf/nesne ayrımı |
| ck0740 | Hepsine tek olay bağla, `sender` ile hangisine basıldığını bul | olay + nesne kimliği |
| ck0750 | **Kapsam dersi:** sayacı handler içinde tanımla → her tıklamada sıfırlanıyor. Sınıf seviyesine taşı → hatırlıyor. | alan (field) vs yerel değişken |
| ck0760 | `class Program`, `static void Main`, `namespace` — Console'un iskeleti artık okunabilir | **iskelet kara kutuları kapanır** |
| ck0770 | Kendi sınıfın: `class Ogrenci` (ad, numara, `Yazdir()`), iki nesne üret, bağımsız olduklarını gör | kendi sınıfını yazma |
| ck0780 | `using` ne yapıyordu: `System.Windows.Forms` satırını sil, ne bozuluyor gör | **`using` kara kutusu kapanır** |
| ck0790 | Çok formlu uygulama: menü formundan `new Ders01().Show();` — ünite başından beri yaptığın şeyin adı buymuş | nesne üretmenin gerçek kullanımı |

Sıra bilinçli: **önce başkasının sınıfını kullan (Button), sonra kendi sınıfını yaz.**
`new Button()` tanıdık bir şeyin arkasını görmek; `new Ogrenci()` tanıdık bir hareketi yeni
bir yerde tekrarlamak. Ters sıra (önce soyut `class Ogrenci`) lisede tipik olarak
"ezberledim ama ne işe yaradığını bilmiyorum" ile sonuçlanır.

## 5. Ünite 08 — Zaman ve olay (ck0800-ck0899)

| ck | konu | kaynak |
|---|---|---|
| ck0800 | Timer nesnesi: `Interval`, `Start()`, `Stop()`, `Tick` olayı | 506 |
| ck0810 | Saniyede bir renk değiştir | 517 |
| ck0820 | Geri sayım (Label'a yaz, sıfırda dur) | 523 |
| ck0830 | Geri sayımı durdur / devam ettir | 524 |
| ck0840 | Sistem saatini göster (`DateTime.Now`) | 525 |
| ck0850 | Trafik lambası | 519 |
| ck0860 | `MouseMove` / `MouseEnter`: fare üstüne gelince | 504 |
| ck0870 | Kaçan buton oyunu | 505 |
| ck0880 | Timer + buton: göster/gizle döngüsü | 521 |
| ck0890 | Timer ile hız kontrolü (interval'i koddan değiştir) | 522 |

## 6. Ünite 09 — Liste, görsel, bitirme (ck0900-ck0999)

| ck | konu | kaynak |
|---|---|---|
| ck0900 | ListBox: `Items.Add`, `Items.Count` | 526 |
| ck0910 | ListBox'tan silme: `RemoveAt`, `SelectedIndex` | 526 |
| ck0920 | `Random rnd = new Random();` — artık bu satırı okuyabiliyorsun (kura çekme) | 526 |
| ck0930 | ListBox + `for` + `if`: filtreleme | 527 |
| ck0940 | PictureBox + ImageList: resim değiştir | 528 |
| ck0950 | PictureBox + ImageList + Timer: animasyon | 529 |
| ck0960-0990 | Bitirme projesi: öğrenci kendi uygulamasını üretir (menü + 3 form) | — |

## 7. Kara kutu takvimi (karara bağlandı)

İskelet kutuları (`using`, `namespace`, `class Program`, `static Main`, `Console.ReadKey`)
**ünite 07**'de açılır — mevcut `kod.cs` metinlerindeki "ünite 03" ibaresi bu yüzden
"ünite 07" olarak düzeltilir.

**Rotasyon freni:** bir iskelet kutusu üç kez Merak Köşesi'ne konu olduysa emekliye ayrılır,
ünite 07'ye kadar bir daha yazılmaz. Köşenin asıl işi o dersin **kendi yeni** kara kutusudur
(`Convert`, `Random`, `string[]`, `try`, `new`); iskelet rotasyonu yedektir.
