# ck1060 — Odaklanma: Focus() ve Clear()

## Senaryo

Bir metin kutusuna örnek bir yazı bas, imleci ona götür, sonra tek tuşla temizle.

## Hazırlık

1. `Unite05` projeni aç.
2. **Project > Add Windows Form**, adı `Ders07_Odaklanma`.
3. Kontroller:

| kontrol | Name | Text |
|---|---|---|
| TextBox | `txtAd` |  |
| Button | `btnYazdir` | Yazdır |
| Button | `btnOdaklan` | Odaklan |
| Button | `btnTemizle` | Temizle |

## Hangi event

Her butona sırayla çift tıkla, `kod.cs`'teki ilgili bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers07`, Text "Ders 07 — Odaklanma". `new Ders07_Odaklanma().Show();`

## Çalıştı mı?

- Yazdır'a bas → kutuya bir yazı gelir.
- Odaklan'a bas → imleç kutuya gider (kutunun kenarı vurgulanır).
- Temizle'ye bas → kutu boşalır.
