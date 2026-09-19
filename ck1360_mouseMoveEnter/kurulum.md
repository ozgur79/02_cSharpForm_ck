# ck1360 — MouseMove / MouseLeave: fare üstüne gelince

## Senaryo

Yeni bir olay ailesi: fare hareketleri. Bir butonun üzerine fareyle gelince bir mesaj,
üzerinden ayrılınca başka bir mesaj göreceğiz.

## Hazırlık

1. `Unite08` projeni aç.
2. **Project > Add Windows Form**, adı `Ders07_MouseMoveEnter`.
3. Bir buton (`btnUzerindenGec`, Text "Üzerimden geç") ve bir Label (`lblDurum`) ekle.
4. `btnUzerindenGec`in Properties'inde Events (yıldırım ikonu) sekmesine gir,
   `MouseMove` ve `MouseLeave` olaylarına çift tıkla (iki ayrı olay, aynı butonda).

## Hangi event

İlk blok `btnUzerindenGec_MouseMove` gövdesine, ikinci blok
`btnUzerindenGec_MouseLeave` gövdesine.

## Menü formuna ekle

`Form1`e buton: `btnDers07`, Text "Ders 07 — Mouse Move/Leave".
`new Ders07_MouseMoveEnter().Show();`

## Çalıştı mı?

- Fareyi butonun üzerine getirince `lblDurum` "Butonun üzerine geldiniz" yazmalı.
- Fareyi butondan çekince `lblDurum` "Çekildiniz..." yazmalı.
- Butona hiç TIKLAMADAN, sadece fareyi ÜZERİNDE gezdirerek bu değişimi görebilmelisin.
