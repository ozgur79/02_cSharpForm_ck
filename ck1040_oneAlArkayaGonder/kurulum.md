# ck1040 — Öne al / arkaya gönder

## Senaryo

İki buton üst üste dursun. Tek bir butona her bastığında, üstteki en alta insin (ya da tam
tersi) — sırayla değişsin.

## Hazırlık

1. `Unite05` projeni aç.
2. **Project > Add Windows Form**, adı `Ders05_OneArkaya`.
3. Kontroller (ikisini ÜST ÜSTE gelecek şekilde konumlandır):

| kontrol | Name | Text |
|---|---|---|
| Button | `btnUst` | Üstteki |
| Button | `btnAlt` | Alttaki |
| Button | `btnDegistir` | Sırayı Değiştir |

## Hangi event

`btnDegistir`e çift tıkla, `kod.cs`'teki bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers05`, Text "Ders 05 — Öne/Arkaya". `new Ders05_OneArkaya().Show();`

## Çalıştı mı?

- Sırayı Değiştir'e her basışta, hangi buton üstteyse yer değiştirmeli (öndeki arkaya
  gider, arkadaki öne gelir).
