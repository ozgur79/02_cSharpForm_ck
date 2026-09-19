# ck1380 — Timer + buton: göster/gizle döngüsü

## Senaryo

Bir buton, Timer sayesinde saniyede bir görünüp kaybolacak — görününce tıklayabilirsen
puan kazanacaksın.

## Hazırlık

1. `Unite08` projeni aç.
2. **Project > Add Windows Form**, adı `Ders09_GosterGizle`.
3. Bir buton (`btnHedef`, Text "Tıkla Bana") ve bir Label (`lblPuan`, Text "Puan: 0")
   ekle.
4. Bir **Timer** sürükle, `Interval` = `800`, `Enabled` = `true` yap.
5. `timer1`e ve `btnHedef`e çift tıkla.

## Hangi event

İlk blok sınıfın içine (alan), ikinci blok `timer1_Tick` gövdesine, üçüncü blok
`btnHedef_Click` gövdesine.

## Menü formuna ekle

`Form1`e buton: `btnDers09`, Text "Ders 09 — Göster/Gizle".
`new Ders09_GosterGizle().Show();`

## Çalıştı mı?

- Buton her 0.8 saniyede bir görünür/kaybolur olmalı.
- Buton görünürken tıklarsan `lblPuan` 1 artmalı.
