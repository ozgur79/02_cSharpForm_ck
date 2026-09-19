# ck1458 — Klinik randevu kaydı (ek pekiştirme, ünite 09 kapanış)

## Senaryo

Ünitenin son dersi: ComboBox (ck1170), ListBox (ck1400) ve TextBox pekiştirmesi bir arada
— bir hasta randevu formu. Ad, poliklinik ve randevu bilgisi ayrı ayrı listelere,
EŞ ZAMANLI (aynı sırada) eklenecek.

## Hazırlık

1. `Unite09` projeni aç.
2. **Project > Add Windows Form**, adı `Ders09_KlinikRandevu`.
3. Bir TextBox (`txtAdSoyad`), bir ComboBox (`cmbPoliklinik`, Items: "Dahiliye",
   "Kardiyoloji", "Çocuk Hastalıkları", "Cerrahi"), bir Buton (`btnKaydet`, Text
   "Randevu Al") ekle.
4. İki ListBox ekle: `lstAdSoyad`, `lstPoliklinik` (yan yana, sanki tek bir tablo gibi
   dursunlar).
5. `btnKaydet`e çift tıkla.

## Hangi event

Blok `btnKaydet_Click` gövdesinin içine.

## Menü formuna ekle

`Form1`e buton: `btnDers09`, Text "Ders 09 — Klinik Randevu".
`new Ders09_KlinikRandevu().Show();`

## Çalıştı mı?

- Ad Soyad boşken "Randevu Al"a basarsan uyarı çıkmalı, listelere hiçbir şey eklenmemeli.
- Doldurup basınca `lstAdSoyad` ve `lstPoliklinik`e AYNI SIRADA (aynı satırda) yeni bir
  kayıt eklenmeli — 3. hasta eklendiğinde her iki listede de 3. satırda aynı hastaya ait
  bilgiler durmalı.
