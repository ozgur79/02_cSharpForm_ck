# ck1270 — Kendi sınıfın: class Ogrenci

## Senaryo

Şimdiye kadar hep BAŞKASININ sınıfından nesne ürettin (`new Button()`, `new Form2()`).
Bu ders kendi sınıfını yazıyorsun: `class Ogrenci` — adı, numarası olan ve kendini
tanıtabilen bir nesne üreteceksin.

## Hazırlık

1. `Unite07` projeni aç.
2. **Project > Add Class**, adı `Ogrenci` (dosya: `Ogrenci.cs`, ayrı bir form DEĞİL).
3. **Project > Add Windows Form**, adı `Ders06_KendiSinifin`.
4. Forma bir buton (`btnTanit`, Text "Tanıt") ve bir liste kutusu (`lstSonuc`) ekle.
5. Butona çift tıkla (`Click` olayı açılır).

## Hangi event

İlk blok `Ogrenci.cs` dosyasının İÇİNE (class Form1/Ders06 değil, kendi dosyası). İkinci
blok `btnTanit_Click` gövdesine.

## Menü formuna ekle

`Form1`e buton: `btnDers06`, Text "Ders 06 — Kendi Sınıfın".
`new Ders06_KendiSinifin().Show();`

## Çalıştı mı?

- Tıklayınca liste kutusunda İKİ farklı öğrencinin adı+numarası ayrı ayrı görünmeli —
  ikisi birbirinden BAĞIMSIZ olmalı (birinin adını değiştirmek diğerini etkilememeli).
