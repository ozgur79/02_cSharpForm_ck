# ck1140 — if ile karar: kare mi dikdörtgen mi

## Senaryo

En ve boy gir, ikisi eşitse "Kare", değilse "Dik" (dikdörtgen) yazsın.

## Hazırlık

1. `Unite06` projeni aç.
2. **Project > Add Windows Form**, adı `Ders06_IfIleKarar`.
3. Kontroller:

| kontrol | Name | Text |
|---|---|---|
| TextBox | `txtEn` |  |
| TextBox | `txtBoy` |  |
| Button | `btnAnaliz` | Analiz |
| Label | `lblSonuc` | (boşalt) |

## Hangi event

`btnAnaliz`e çift tıkla, `kod.cs`'teki bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers06`, Text "Ders 06 — If ile Karar". `new Ders06_IfIleKarar().Show();`

## Çalıştı mı?

- En=5, Boy=5 → "Kare". En=5, Boy=8 → "Dik".
