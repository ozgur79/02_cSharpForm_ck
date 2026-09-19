# ck1454 — Rastgele sayı tahmin oyunu (ek pekiştirme)

## Senaryo

Form açılırken 1-8 arası rastgele bir sayı seçilecek (öğrenci GÖRMEYECEK). Kullanıcının
3 hakkı olacak, doğru bilirse tebrik, hakları biterse doğru cevap gösterilecek.

## Hazırlık

1. `Unite09` projeni aç.
2. **Project > Add Windows Form**, adı `Ders08_RastgeleSayiTahmin`.
3. Bir Label (Text "Tahminin:"), bir TextBox (`txtTahmin`), bir Buton (`btnDeneBakalim`,
   Text "Dene Bakalım"), bir Label (`lblKalanHak`, SEN YAP'ta kullanılacak) ekle.
4. Formun kendisine çift tıkla (`Load` olayı açılır), `btnDeneBakalim`e de çift tıkla.

## Hangi event

İlk iki blok sınıfın içine (alanlar), üçüncü blok `Ders08_RastgeleSayiTahmin_Load`
gövdesine, dördüncü blok `btnDeneBakalim_Click` gövdesine.

## Menü formuna ekle

`Form1`e buton: `btnDers08`, Text "Ders 08 — Rastgele Sayı Tahmin".
`new Ders08_RastgeleSayiTahmin().Show();`

## Çalıştı mı?

- Yanlış tahminlerde "şansını dene" tarzı bir mesaj çıkmalı, form kapanmamalı.
- 3. yanlış tahminden sonra doğru cevap gösterilip form KAPANMALI.
- Doğru tahmin edersen tebrik mesajı çıkmalı (hakların bitmesini beklemeden).
