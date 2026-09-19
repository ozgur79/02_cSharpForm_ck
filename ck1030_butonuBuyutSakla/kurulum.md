# ck1030 — Butonu büyüt, butonu sakla

## Senaryo

Bir butona her bastığında buton biraz büyüsün. Başka bir butona bastığında ise o buton
ekrandan kaybolsun. İkisi de aynı şeye benziyor ama koda bakınca farkı göreceksin.

## Hazırlık

1. `Unite05` projeni aç.
2. **Project > Add Windows Form** de, adını `Ders04_BuyuSakla` yaz.
3. Açılan boş forma aşağıdaki iki butonu sürükle:

| kontrol | Name | Text |
|---|---|---|
| Button | `btnBuyu` | Tıkla |
| Button | `btnSakla` | Sakla |

> `Name` özelliğini Properties penceresinden değiştir — `button1` diye bırakma.

4. `btnBuyu`ya çift tıkla, `kod.cs`'teki ilgili bloğu yapıştır. Forma geri dön, `btnSakla`ya
   çift tıkla, onun bloğunu da yapıştır.

## Menü formuna ekle

`Form1`e bir buton koy: `Name` `btnDers04`, `Text` "Ders 04 — Büyü/Sakla". Çift tıkla,
gövdesine `new Ders04_BuyuSakla().Show();` yaz.

## Çalıştı mı?

- `Tıkla` butonuna 5 kez bas → buton her seferinde biraz büyümeli.
- `Sakla` butonuna bir kez bas → buton kaybolmalı, form açık kalmalı.
