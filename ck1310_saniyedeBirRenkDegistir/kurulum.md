# ck1310 — Saniyede bir renk değiştir

## Senaryo

Formun arka planı, hiçbir butona basmadan, KENDİ KENDİNE saniyede bir siyah/beyaz arasında
geçiş yapacak — Timer'ın Enabled özelliğiyle "otomatik başlama"yı göreceğiz.

## Hazırlık

1. `Unite08` projeni aç.
2. **Project > Add Windows Form**, adı `Ders02_RenkDegistir`.
3. Toolbox'tan bir **Timer** sürükle. Properties'te `Interval` = `500`, **`Enabled` =
   `true`** yap (ck1300'de Enabled'a hiç dokunmamıştık — bu kez form açılır açılmaz
   çalışsın istiyoruz).
4. `timer1`e çift tıkla (`Tick` olayı açılır).

## Hangi event

İlk blok sınıfın içine (alan), ikinci blok `timer1_Tick` gövdesine.

## Menü formuna ekle

`Form1`e buton: `btnDers02`, Text "Ders 02 — Renk Değiştir".
`new Ders02_RenkDegistir().Show();`

## Çalıştı mı?

- Formu açar açmaz (hiçbir butona basmadan) arka plan yarım saniyede bir siyah/beyaz
  arasında yanıp sönmeli.
