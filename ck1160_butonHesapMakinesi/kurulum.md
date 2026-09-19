# ck1160 — Buton hesap makinesi

## Senaryo

Dört ayrı buton (+, -, *, /), dört ayrı işlem yapıyor. Klasik hesap makinesi.

## Hazırlık

1. `Unite06` projeni aç.
2. **Project > Add Windows Form**, adı `Ders08_ButonHesapMakinesi`.
3. Kontroller:

| kontrol | Name | Text |
|---|---|---|
| TextBox | `txtSayi1` |  |
| TextBox | `txtSayi2` |  |
| Button | `btnTopla` | + |
| Button | `btnCikar` | - |
| Button | `btnCarp` | * |
| Button | `btnBol` | / |
| Label | `lblSonuc` | (boşalt) |

## Hangi event

Her butona sırayla çift tıkla, `kod.cs`'teki ilgili bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers08`, Text "Ders 08 — Buton Hesap Makinesi".
`new Ders08_ButonHesapMakinesi().Show();`

## Çalıştı mı?

- 10 ve 4 ile her dört butonu da dene: 14, 6, 40, 2,5 çıkmalı.
