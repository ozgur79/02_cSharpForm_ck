# ck1110 — Sonucu Label'a yaz

## Senaryo

ck1100'deki aynı toplama, ama sonucu bir uyarı penceresi yerine kalıcı bir etikette
göster.

## Hazırlık

1. `Unite06` projeni aç.
2. **Project > Add Windows Form**, adı `Ders02_SonucuLabelaYaz`.
3. Kontroller:

| kontrol | Name | Text |
|---|---|---|
| TextBox | `txtSayi1` |  |
| TextBox | `txtSayi2` |  |
| Button | `btnTopla` | Topla |
| Label | `lblSonuc` | (boşalt) |

## Hangi event

`btnTopla`ya çift tıkla, `kod.cs`'teki bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers02`, Text "Ders 02 — Sonucu Label'a Yaz".
`new Ders02_SonucuLabelaYaz().Show();`

## Çalıştı mı?

- Kutulara 3 ve 4 yaz, Topla'ya bas → etikette "7" görünmeli (uyarı penceresi açılmamalı).
