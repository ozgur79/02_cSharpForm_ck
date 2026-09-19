# ck1440 — PictureBox + ImageList: resim değiştir

## Senaryo

Yeni bir kontrol ailesi: `PictureBox` (resim gösteren kutu) ve `ImageList` (görünmez bir
resim deposu). Bir butona her basışta PictureBox'taki resmi sırayla değiştireceğiz.

## Hazırlık

1. `Unite09` projeni aç.
2. **Project > Add Windows Form**, adı `Ders05_PictureBoxImageList`.
3. Toolbox'tan bir **ImageList** sürükle (görünmez, adı `imageList1`). Properties'te
   `Images` satırının yanındaki `...`ya tıkla, **kendi bilgisayarından en az 3 resim**
   (jpg/png, ne olursa olsun) ekle.
4. Bir **PictureBox** (`picGoster`, `SizeMode` = `StretchImage`) ve bir Buton
   (`btnSonraki`, Text "Sonraki Resim") ekle.
5. `btnSonraki`e çift tıkla.

## Hangi event

İlk blok sınıfın içine (alan), ikinci blok `btnSonraki_Click` gövdesine.

## Menü formuna ekle

`Form1`e buton: `btnDers05`, Text "Ders 05 — PictureBox + ImageList".
`new Ders05_PictureBoxImageList().Show();`

## Çalıştı mı?

- Her "Sonraki Resim"e basışta PictureBox'taki resim SIRAYLA değişmeli.
- Son resimden sonra tekrar İLK resme dönmeli (döngü).
