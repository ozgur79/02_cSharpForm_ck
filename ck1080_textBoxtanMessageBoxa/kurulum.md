# ck1080 — Veri taşı: TextBox → MessageBox (ünite 05 kapanışı)

## Senaryo

Kutuya yazdığın bir şey, butona basınca ayrı bir uyarı penceresinde (MessageBox) görünsün.

## Hazırlık

1. `Unite05` projeni aç.
2. **Project > Add Windows Form**, adı `Ders09_TextBoxtanMessageBoxa`.
3. Kontroller:

| kontrol | Name | Text |
|---|---|---|
| TextBox | `txtGirilen` |  |
| Button | `btnAktar` | Aktar |

## Hangi event

`btnAktar`a çift tıkla, `kod.cs`'teki bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers09`, Text "Ders 09 — TextBox'tan MessageBox'a".
`new Ders09_TextBoxtanMessageBoxa().Show();`

## Çalıştı mı?

- Kutuya bir şey yaz, Aktar'a bas → ayrı bir kutu (MessageBox) açılıp yazını göstermeli.
- Ünite 05 tamamlandı: menü formu + 9 form aynı projede, hepsi çalışıyor olmalı.
