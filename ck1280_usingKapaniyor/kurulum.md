# ck1280 — using kapanıyor: satırı sil, ne bozuluyor gör

## Senaryo

Bu ders bir şey İNŞA ETMİYOR — `using` satırının GERÇEKTE ne işe yaradığını, onu SİLEREK
göreceksin. Kara kutu kapanıyor.

## Hazırlık

1. `Unite07` projeni aç.
2. `Ders06_KendiSinifin.cs` dosyasının en üstündeki `using System.Windows.Forms;`
   satırını SİL (geçici olarak).
3. Projeyi derle (Build > Build Solution, ya da F6).

## Hangi event

Yok — kod eklemiyorsun, var olan bir satırı geçici olarak siliyorsun.

## Menü formuna ekle

Yok.

## Çalıştı mı?

- Derleme HATA vermeli. Dosyanın en üstündeki `public partial class Ders06_KendiSinifin :
  Form` satırındaki `Form` kelimesinin altı kırmızı çizilmeli — C#, `Form` diye bir isim
  bilmiyor artık.
- Hata mesajını oku (`CS0246` gibi bir kod göreceksin), sonra `using
  System.Windows.Forms;` satırını GERİ ekle, hata gitmeli.
