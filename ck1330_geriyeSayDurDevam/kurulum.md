# ck1330 — Geriye sayımı durdur / devam ettir

## Senaryo

ck1320'deki sayımı, TEK bir butonla hem başlat hem duraklat hem devam ettir hâline
getireceğiz — butonun Text'i duruma göre değişecek.

## Hazırlık

1. `Unite08` projeni aç.
2. **Project > Add Windows Form**, adı `Ders04_GeriyeSayDurDevam`.
3. Bir Label, bir TextBox (`txtSayi`), bir Buton (`btnBaslatDurdur`, Text "Geriye Say"),
   bir Label (`lblSayac`) ekle.
4. Bir **Timer** sürükle, `Interval` = `1000` yap.
5. `btnBaslatDurdur`a ve `timer1`e çift tıkla.

## Hangi event

İlk iki blok sınıfın içine (alanlar), üçüncü blok `timer1_Tick`e, dördüncü blok
`btnBaslatDurdur_Click`e.

## Menü formuna ekle

`Form1`e buton: `btnDers04`, Text "Ders 04 — Durdur/Devam".
`new Ders04_GeriyeSayDurDevam().Show();`

## Çalıştı mı?

- İlk basışta sayım başlamalı, buton Text'i "Durdur" olmalı.
- İkinci basışta sayım DURMALI (kaldığı sayıda donmalı), buton Text'i "Devam Et" olmalı.
- Üçüncü basışta sayım KALDIĞI YERDEN devam etmeli (baştan başlamamalı).
