# ck1000 — Formu tanı

## Senaryo

İlk pencereni yapıyorsun. Üzerinde bir buton ve bir yazı alanı olacak; butona bastığında
yazı değişecek. Console'da program açılır, çalışır, kapanırdı — burada pencere açık kalır
ve **sen bir şey yapana kadar bekler**.

## Hazırlık

Bu ünitede **her ders için yeni proje açmayacaksın.** Bir kez proje açıyorsun, her ders o
projeye yeni bir form ekliyor.

1. Visual Studio'da **File > New Project > Windows Forms Application** aç, adını `Unite05`
   koy. Karşına boş bir gri pencere (`Form1`) gelir.
2. Ekranı tanı — üç bölge kullanacaksın:
   - **Toolbox** (sol kenar): sürükleyeceğin hazır parçalar. Button, Label, TextBox burada.
     Görünmüyorsa `View > Toolbox`.
   - **Properties** (sağ alt): seçili parçanın ayarları. `Name`, `Text`, renk, boyut.
     Görünmüyorsa parçaya sağ tıkla > `Properties`.
   - **Solution Explorer** (sağ üst): projendeki dosyalar.
3. `Form1` senin **menü formun** olacak. Seç, Properties'ten `Text` değerini
   `Ünite 05 - Menü` yap. (Pencerenin başlığında bu yazar.)
4. **Project > Add Windows Form** de, adını `Ders01_FormuTani` yaz. Yeni bir boş form açılır.
5. Bu yeni forma Toolbox'tan şu ikisini sürükle ve Properties'ten adlarını ver:

| kontrol | Name | Text |
|---|---|---|
| Button | `btnSelamla` | Selamla |
| Label | `lblMesaj` | (boşalt — Text kutusunu tamamen sil) |

> **Name'i mutlaka değiştir.** VS ilk hâlde `button1`, `label1` diye adlandırır. Bu adlarla
> 20 kontrollü bir formda hangisi hangisi anlaşılmaz. Kural: buton `btn`, etiket `lbl`,
> metin kutusu `txt` ile başlar; devamı ne işe yaradığını söyler.

## Hangi event

`Ders01_FormuTani` formundaki **`btnSelamla`ya çift tıkla**. VS senin için
`btnSelamla_Click` adında boş bir gövde açar. `kod.cs`teki ilk bloğu buraya yapıştır.

## Menü formuna ekle

`Form1`e (menü formu) Toolbox'tan bir Button sürükle:

| kontrol | Name | Text |
|---|---|---|
| Button | `btnDers01` | Ders 01 — Formu Tanı |

Bu butona da çift tıkla, `kod.cs`teki ikinci bloğu gövdesine yapıştır. Bundan sonra her
derste menü formuna bir buton daha ekleyeceksin.

## Çalıştı mı?

- **F5** ile çalıştır → önce menü formu açılmalı, başlığında "Ünite 05 - Menü" yazmalı.
- "Ders 01 — Formu Tanı" butonuna bas → ikinci bir pencere açılmalı.
- İkinci penceredeki "Selamla" butonuna bas → etiketin yazısı değişmeli.
- İki pencere de aynı anda açık kalmalı; menü formu kapanmamalı.
