# ck1010 — İlk olay: butona basınca formun rengini değiştir

## Senaryo

Bir butona bastığında, formun (pencerenin) arka plan rengi kırmızıya dönsün.

## Hazırlık

1. `Unite05` projeni aç (ck1000'de bir kez açmıştık).
2. **Project > Add Windows Form**, adını `Ders02_IlkOlay` yaz.
3. Forma şu kontrolü sürükle:

| kontrol | Name | Text |
|---|---|---|
| Button | `btnKirmizi` | Kırmızı Yap |

## Hangi event

`btnKirmizi`ya çift tıkla, `kod.cs`'teki bloğu gövdesine yapıştır.

## Menü formuna ekle

`Form1`e bir buton koy: `Name` `btnDers02`, `Text` "Ders 02 — İlk Olay". Çift tıkla,
gövdesine `new Ders02_IlkOlay().Show();` yaz.

## Çalıştı mı?

- "Kırmızı Yap" butonuna bas → formun arka planı kırmızı olmalı.
- Menü formundan "Ders 02" butonuna basınca bu form açılmalı.
