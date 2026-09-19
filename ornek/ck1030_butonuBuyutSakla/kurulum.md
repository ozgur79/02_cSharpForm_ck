# ck1030 — Butonu büyüt, butonu sakla

## Senaryo

Bir butona her bastığında buton biraz büyüsün. Başka bir butona bastığında ise o buton
ekrandan kaybolsun. İkisi de aynı şeye benziyor ama koda bakınca farkı göreceksin.

## Hazırlık

1. `Unite05` projeni aç. (Yoksa ck1000'e dön, orada bir kez açtık.)
2. **Project > Add Windows Form** de, adını `Ders03_BuyuSakla` yaz.
3. Açılan boş forma aşağıdaki iki butonu sürükle:

| kontrol | Name | Text |
|---|---|---|
| Button | `btnBuyu` | Tıkla |
| Button | `btnSakla` | Sakla |

> `Name` özelliğini Properties penceresinden değiştir — `button1` diye bırakma.
> Kural: buton `btn`, metin kutusu `txt`, etiket `lbl` ile başlar.

4. `btnBuyu`ya **çift tıkla** — VS senin için `btnBuyu_Click` gövdesini açar. `kod.cs`teki
   ilgili bloğu buraya yapıştır. Sonra forma geri dön, `btnSakla`ya çift tıkla, onun
   bloğunu da oraya yapıştır.

## Menü formuna ekle

`Form1`e (menü formu) bir buton koy: Name `btnDers03`, Text "Ders 03 — Büyü/Sakla".
Çift tıkla, gövdesine tek satır yaz:

```csharp
new Ders03_BuyuSakla().Show();
```

Artık projeyi çalıştırdığında menüden bu derse girebilirsin.

## Çalıştı mı?

- `Tıkla` butonuna 5 kez bas → buton her seferinde biraz büyümeli.
- `Sakla` butonuna bir kez bas → buton kaybolmalı, form açık kalmalı.
