# ck1390 — Timer ile hız kontrolü (Interval'i koddan değiştir) — ünite 08 kapanışı

## Senaryo

Bir Timer'ın hızını, ÇALIŞIRKEN, iki butonla artırıp azaltacaksın. Yanıp sönen küçük bir
buton, hızın değiştiğini gözle görmeni sağlayacak.

## Hazırlık

1. `Unite08` projeni aç.
2. **Project > Add Windows Form**, adı `Ders10_HizKontrolu`.
3. İki buton ekle: `btnYavaslat` (Text "Yavaşlat"), `btnHizlandir` (Text "Hızlandır").
4. Küçük bir üçüncü buton ekle: `btnGosterge` (Text boş bırakılabilir).
5. Bir **Timer** sürükle, `Interval` = `500`, `Enabled` = `true` yap.
6. `timer1`e, `btnYavaslat`a ve `btnHizlandir`a çift tıkla.

## Hangi event

İlk iki blok sınıfın içine (alanlar), üçüncü blok `timer1_Tick`e, dördüncü blok
`btnYavaslat_Click`e, beşinci blok `btnHizlandir_Click`e.

## Menü formuna ekle

`Form1`e buton: `btnDers10`, Text "Ders 10 — Hız Kontrolü".
`new Ders10_HizKontrolu().Show();`

## Çalıştı mı?

- `btnGosterge` başlangıçta 500ms aralıkla yanıp sönmeli.
- "Yavaşlat"a her basışta yanıp sönme YAVAŞLAMALI.
- "Hızlandır"a her basışta yanıp sönme HIZLANMALI.
