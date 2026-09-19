# ck1420 — `Random rnd = new Random();` — kura çekme

## Senaryo

Bir isim listesinden RASTGELE bir isim seçip ikinci bir listeye taşıyacağız — sınıf
kurası gibi. Adı çekilen isim ilk listeden silinecek, bir daha çıkmayacak.

## Hazırlık

1. `Unite09` projeni aç.
2. **Project > Add Windows Form**, adı `Ders03_RastgeleKura`.
3. Bir TextBox (`txtIsim`), bir Buton (`btnEkle`, Text "Ekle"), iki ListBox
   (`lstBekleyenler`, `lstSecilenler`), bir Buton (`btnKuraCek`, Text "Kura Çek") ekle.
4. `btnEkle`ye ve `btnKuraCek`e çift tıkla.

## Hangi event

İlk blok `btnEkle_Click` gövdesine, ikinci blok `btnKuraCek_Click` gövdesine.

## Menü formuna ekle

`Form1`e buton: `btnDers03`, Text "Ders 03 — Rastgele Kura Çek".
`new Ders03_RastgeleKura().Show();`

## Çalıştı mı?

- `lstBekleyenler`e birkaç isim ekle, "Kura Çek"e bas — RASTGELE bir isim `lstSecilenler`e
  taşınmalı ve `lstBekleyenler`den kaybolmalı.
- Aynı isim İKİ KEZ çekilmemeli (silindiği için listede kalmıyor).
- `lstBekleyenler` boşken "Kura Çek"e basarsan program ÇÖKMEMELİ.
