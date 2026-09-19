# ck1120 — Mod alma

## Senaryo

Bir sayı gir, 2'ye ve 3'e bölümünden kalanı gör.

## Hazırlık

1. `Unite06` projeni aç.
2. **Project > Add Windows Form**, adı `Ders04_ModAlma`.
3. Kontroller:

| kontrol | Name | Text |
|---|---|---|
| TextBox | `txtSayi` |  |
| Button | `btnMod2` | Mod 2 |
| Button | `btnMod3` | Mod 3 |
| Label | `lblSonuc` | (boşalt) |

## Hangi event

Her butona sırayla çift tıkla, `kod.cs`'teki ilgili bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers04`, Text "Ders 04 — Mod Alma". `new Ders04_ModAlma().Show();`

## Çalıştı mı?

- 7 yaz, Mod 2'ye bas → "1" görünmeli. Mod 3'e bas → "1" görünmeli.
