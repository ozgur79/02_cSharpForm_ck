# ck1210 — Sen yaz: kod ile buton üret

## Senaryo

ck1200'de VS'in yaptığını gördün. Şimdi AYNI ŞEYİ, Toolbox'a hiç dokunmadan, SADECE
kod yazarak yapacaksın.

## Hazırlık

1. `Unite07` projeni bu dersle aç.
2. **Project > Add Windows Form**, adı `Ders01_KendiButonunuUret`.
3. Forma HİÇBİR ŞEY sürükleme — Toolbox'a dokunma. Sadece formun kendisine çift tıkla
   (bu `Form1_Load` benzeri bir `Load` olayı açar, formun ADI otomatik `Ders01_KendiButonunuUret_Load`
   olur).

## Hangi event

Forma çift tıklayınca açılan `Ders01_KendiButonunuUret_Load` gövdesine `kod.cs`'teki
bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers01`, Text "Ders 01 — Kendi Butonunu Üret".
`new Ders01_KendiButonunuUret().Show();`

## Çalıştı mı?

- Formu çalıştır → üzerinde Toolbox'tan hiç sürüklemediğin bir buton görünmeli.
- Butona bas → bir uyarı penceresi açılmalı.
