# ck1230 — for ile 5 buton üret: aynı sınıftan çok nesne

## Senaryo

ck1220'de 3 butonu tek tek yazdın (3 kez `new Button()`, 3 kez `Controls.Add`).
Şimdi bir `for` döngüsüyle 5 butonu TEK bir kod bloğuyla üreteceksin.

## Hazırlık

1. `Unite07` projeni aç.
2. **Project > Add Windows Form**, adı `Ders03_ForIleButon`. Yine Toolbox'a dokunma.
3. Forma çift tıkla (`Load` olayı açılır).

## Hangi event

`Ders03_ForIleButon_Load` gövdesine `kod.cs`'teki bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers03`, Text "Ders 03 — For ile 5 Buton".
`new Ders03_ForIleButon().Show();`

## Çalıştı mı?

- Formu çalıştır → alt alta dizilmiş 5 buton görünmeli, üzerlerinde "Buton 1"den
  "Buton 5"e kadar yazı olmalı.
