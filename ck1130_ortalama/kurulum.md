# ck1130 — Üç sayının ortalaması (biriktirici + sıfırla)

## Senaryo

Aynı butona her bastığında bir sayı daha eklenip ortalama güncellensin. 0 girip basınca
her şey sıfırlansın.

## Hazırlık

1. `Unite06` projeni aç.
2. **Project > Add Windows Form**, adı `Ders05_Ortalama`.
3. Kontroller:

| kontrol | Name | Text |
|---|---|---|
| TextBox | `txtSayi` |  |
| Button | `btnEkle` | Ortalama |
| Label | `lblSonuc` | (boşalt) |

## Hangi event

`btnEkle`ye çift tıkla, `kod.cs`'teki bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers05`, Text "Ders 05 — Ortalama". `new Ders05_Ortalama().Show();`

## Çalıştı mı?

- 4 gir, bas → "1. sayıyı girdiniz, ortalama: 4".
- 6 gir, bas → "2. sayıyı girdiniz, ortalama: 5".
- 0 gir, bas → "İşlem Bitmiştir..." uyarısı, etiket boşalmalı.
