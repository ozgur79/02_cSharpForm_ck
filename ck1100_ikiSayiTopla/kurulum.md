# ck1100 — İki sayıyı topla (ünite 06 girişi)

## Senaryo

İki kutuya sayı gir, Topla'ya bas, sonucu bir uyarı penceresinde gör. Console'da
`Convert.ToInt32(Console.ReadLine())` yapıyorduk — burada aynı dönüşüm, sadece kaynak
`Console.ReadLine()` değil bir `TextBox`.

## Hazırlık

1. **Project > Add Windows Form**, adı `Ders01_IkiSayiTopla` (yeni ünite: `Unite06`
   projesini bu dersle aç).
2. Kontroller:

| kontrol | Name | Text |
|---|---|---|
| TextBox | `txtSayi1` |  |
| TextBox | `txtSayi2` |  |
| Button | `btnTopla` | Topla |

## Hangi event

`btnTopla`ya çift tıkla, `kod.cs`'teki bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers01`, Text "Ders 01 — İki Sayı Topla". `new Ders01_IkiSayiTopla().Show();`

## Çalıştı mı?

- Kutulara 3 ve 4 yaz, Topla'ya bas → "7" yazan bir uyarı penceresi açılmalı.
