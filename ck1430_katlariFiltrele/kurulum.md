# ck1430 — ListBox + for + if: katlarını filtrele

## Senaryo

Kullanıcı bir sayı girsin, 1-100 arasındaki SADECE o sayının katlarını (tam bölünenleri)
bir ListBox'ta listeleyelim.

## Hazırlık

1. `Unite09` projeni aç.
2. **Project > Add Windows Form**, adı `Ders04_KatlariFiltrele`.
3. Bir TextBox (`txtSayi`), bir Buton (`btnListele`, Text "Katlarını Listele"), bir
   ListBox (`lstKatlar`) ekle.
4. `btnListele`ye çift tıkla.

## Hangi event

Blok `btnListele_Click` gövdesinin içine.

## Menü formuna ekle

`Form1`e buton: `btnDers04`, Text "Ders 04 — Katlarını Filtrele".
`new Ders04_KatlariFiltrele().Show();`

## Çalıştı mı?

- TextBox'a `7` yazıp "Katlarını Listele"ye basınca listede 7, 14, 21, 28... 98
  görünmeli (100'e kadar 7'nin katları).
- Tekrar farklı bir sayıyla denersen ESKİ liste TEMİZLENİP yenisi gelmeli.
