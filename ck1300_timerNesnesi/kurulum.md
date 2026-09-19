# ck1300 — Timer nesnesi: Interval, Start(), Stop(), Tick

## Senaryo

Yeni bir kontrol: `Timer`. Görünmez ama düzenli aralıklarla (senin belirlediğin süre) bir
olay tetikleyen bir nesne. Bir saniyede bir artan bir sayaç yapacağız.

## Hazırlık

1. `Unite08` adında yeni bir **Windows Forms Application** aç.
2. Toolbox'tan **Timer**'ı forma sürükle (görünmez bir kontrol olarak alta düşer, adı
   `timer1`).
3. `timer1`in Properties'inde `Interval` = `1000` yap (1000 milisaniye = 1 saniye).
4. Forma bir Label (`lblSayac`, Text "0") ve iki buton ekle: `btnBaslat` (Text "Başlat"),
   `btnDurdur` (Text "Durdur").
5. `timer1`e çift tıkla (`Tick` olayı açılır). Ayrıca her iki butona da çift tıkla.

## Hangi event

İlk blok (`saniye` alanı) sınıfın içine hiçbir metodun dışına, ikinci blok `timer1_Tick`
gövdesine, üçüncü blok `btnBaslat_Click`e, dördüncü blok `btnDurdur_Click`e.

## Menü formuna ekle

`Form1`e buton: `btnDers01`, Text "Ders 01 — Timer". `new Ders01_TimerNesnesi().Show();`

## Çalıştı mı?

- "Başlat"a basınca sayaç her saniye 1 artmalı (0, 1, 2, 3...).
- "Durdur"a basınca sayaç OLDUĞU yerde durmalı (sıfırlanmamalı).
- "Başlat"a tekrar basınca kaldığı yerden devam etmeli.
