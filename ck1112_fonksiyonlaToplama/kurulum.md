# ck1112 — Fonksiyonla toplama (ek pekiştirme)

## Senaryo

ck1100'deki aynı toplama, ama hesaplamayı Console'daki ck0760 gibi ayrı bir metoda
(fonksiyona) taşıyoruz.

## Hazırlık

1. `Unite06` projeni aç.
2. **Project > Add Windows Form**, adı `Ders03_FonksiyonlaToplama`.
3. Kontroller:

| kontrol | Name | Text |
|---|---|---|
| TextBox | `txtSayi1` |  |
| TextBox | `txtSayi2` |  |
| Button | `btnTopla` | Topla |

## Hangi event

`btnTopla`ya çift tıkla, `kod.cs`'teki ilk bloğu gövdesine yapıştır. İkinci blok
(`Topla` metodu) `btnTopla_Click`'in DIŞINA, sınıfın içine gider.

## Menü formuna ekle

`Form1`e buton: `btnDers03`, Text "Ders 03 — Fonksiyonla Toplama".
`new Ders03_FonksiyonlaToplama().Show();`

## Çalıştı mı?

- Kutulara 3 ve 4 yaz, Topla'ya bas → "7" yazan bir uyarı penceresi açılmalı.
