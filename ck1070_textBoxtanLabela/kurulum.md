# ck1070 — Veri taşı: TextBox → Label

## Senaryo

Kutuya yazdığın bir şey, butona basınca bir etikette görünsün.

## Hazırlık

1. `Unite05` projeni aç.
2. **Project > Add Windows Form**, adı `Ders08_TextBoxtanLabela`.
3. Kontroller:

| kontrol | Name | Text |
|---|---|---|
| TextBox | `txtGirilen` |  |
| Button | `btnAktar` | Aktar |
| Label | `lblSonuc` | (boşalt) |

## Hangi event

`btnAktar`a çift tıkla, `kod.cs`'teki bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers08`, Text "Ders 08 — TextBox'tan Label'a".
`new Ders08_TextBoxtanLabela().Show();`

## Çalıştı mı?

- Kutuya bir şey yaz, Aktar'a bas → etikette aynı yazı görünmeli.
