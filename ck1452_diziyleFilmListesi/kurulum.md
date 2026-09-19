# ck1452 — Diziyle film listesi (ek pekiştirme)

## Senaryo

ListBox yerine bu kez sabit boyutlu bir DİZİ kullanacağız — Console'daki dizi/foreach
bilgini (ck0670, ck0705) WinForms'a taşıyoruz. Dizi dolunca uyarı verecek.

## Hazırlık

1. `Unite09` projeni aç.
2. **Project > Add Windows Form**, adı `Ders07_DiziyleFilmListesi`.
3. Bir Label (Text "Film Adını Girin"), bir TextBox (`txtFilm`), bir Buton
   (`btnEkle`, Text "Film Ekle"), bir Buton (`btnGoster`, Text "Göster") ekle.
4. `btnEkle`ye ve `btnGoster`e çift tıkla.

## Hangi event

İlk iki blok sınıfın içine (alanlar), üçüncü blok `btnEkle_Click` gövdesine, dördüncü
blok `btnGoster_Click` gövdesine.

## Menü formuna ekle

`Form1`e buton: `btnDers07`, Text "Ders 07 — Diziyle Film Listesi".
`new Ders07_DiziyleFilmListesi().Show();`

## Çalıştı mı?

- 3 film ekleyebilmelisin. 4.'yü eklemeye çalışırsan "Dizinin kapasitesi dolu" uyarısı
  çıkmalı, program çökmemeli.
- "Göster"e basınca eklediğin filmlerin HER BİRİ ayrı bir MessageBox'ta sırayla çıkmalı.
