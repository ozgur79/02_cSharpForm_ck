# ck1450 — PictureBox + ImageList + Timer: animasyon — ünite 09 kapanış

## Senaryo

ck1440'taki "butona basınca resim değişsin" fikrini Timer'la birleştirip KENDİLİĞİNDEN
değişen bir animasyon yapacağız — bir "Başlat/Durdur" butonuyla açıp kapatılabilen.

## Hazırlık

1. `Unite09` projeni aç.
2. **Project > Add Windows Form**, adı `Ders06_PictureBoxAnimasyon`.
3. Bir **ImageList** sürükle, en az 3 resim ekle (ck1440'taki gibi).
4. Bir **PictureBox** (`picGoster`, `SizeMode` = `StretchImage`) ve bir Buton
   (`btnBaslatDurdur`, Text "Başlat") ekle.
5. Bir **Timer** sürükle, `Interval` = `300` yap (Enabled varsayılan `false` kalsın).
6. `timer1`e ve `btnBaslatDurdur`a çift tıkla.

## Hangi event

İlk blok sınıfın içine (alan), ikinci blok `timer1_Tick` gövdesine, üçüncü blok
`btnBaslatDurdur_Click` gövdesine.

## Menü formuna ekle

`Form1`e buton: `btnDers06`, Text "Ders 06 — PictureBox Animasyon".
`new Ders06_PictureBoxAnimasyon().Show();`

## Çalıştı mı?

- "Başlat"a basınca resimler KENDİLİĞİNDEN, hızlıca sırayla değişmeli (bir animasyon
  gibi), buton Text'i "Durdur" olmalı.
- "Durdur"a basınca resim OLDUĞU yerde donmalı, buton Text'i "Başlat"a dönmeli.
