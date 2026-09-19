# ck1350 — Trafik lambası

## Senaryo

Üç buton (kırmızı, sarı, yeşil), bir trafik lambası gibi sırayla renklenecek: 3 saniye
kırmızı, 1 saniye sarı, 2 saniye yeşil, sonra baştan.

## Hazırlık

1. `Unite08` projeni aç.
2. **Project > Add Windows Form**, adı `Ders06_TrafikLambasi`.
3. Üç buton ekle: `btnUst`, `btnOrta`, `btnAlt` (üst üste, dikey dizilmiş — bir trafik
   lambası gibi görünsün).
4. Bir **Timer** sürükle, `Interval` = `1000`, `Enabled` = `true` yap.
5. Formun kendisine çift tıkla (`Load` olayı açılır), `timer1`e de çift tıkla.

## Hangi event

İlk blok sınıfın içine (alan), ikinci blok `Ders06_TrafikLambasi_Load` gövdesine, üçüncü
blok `timer1_Tick` gövdesine.

## Menü formuna ekle

`Form1`e buton: `btnDers06`, Text "Ders 06 — Trafik Lambası".
`new Ders06_TrafikLambasi().Show();`

## Çalıştı mı?

- Form açılır açılmaz `btnUst` kırmızı olmalı.
- 3 saniye sonra `btnUst` beyaza dönüp `btnOrta` sarı olmalı.
- 1 saniye sonra `btnOrta` beyaza dönüp `btnAlt` yeşil olmalı.
- 2 saniye sonra `btnAlt` beyaza dönüp döngü baştan (kırmızı) başlamalı.
