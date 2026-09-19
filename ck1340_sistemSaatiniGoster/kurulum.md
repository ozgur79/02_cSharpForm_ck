# ck1340 — Sistem saatini göster

## Senaryo

Formda, bilgisayarın o anki saatini gösteren, sürekli güncellenen bir saat yapacağız.

## Hazırlık

1. `Unite08` projeni aç.
2. **Project > Add Windows Form**, adı `Ders05_SistemSaati`.
3. İki Label ekle: `lblSaat` ve `lblTarih` (ikincisi SEN YAP'ta kullanılacak).
4. Bir **Timer** sürükle, `Interval` = `1000`, **`Enabled` = `true`** yap.
5. `timer1`e çift tıkla.

## Hangi event

Blok `timer1_Tick` gövdesine.

## Menü formuna ekle

`Form1`e buton: `btnDers05`, Text "Ders 05 — Sistem Saati".
`new Ders05_SistemSaati().Show();`

## Çalıştı mı?

- Formu açar açmaz `lblSaat`te o anki saat görünmeli ve her saniye güncellenmeli.
