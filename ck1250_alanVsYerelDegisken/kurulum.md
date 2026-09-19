# ck1250 — Kapsam dersi: alan mı, yerel değişken mi?

## Senaryo

Bir buton her tıklandığında sayacı 1 artırıp bir etikette göstersin. Sayaç kalıcı mı
tutuluyor, yoksa her tıklamada sıfırdan mı başlıyor — deneyerek göreceğiz.

## Hazırlık

1. `Unite07` projeni aç.
2. **Project > Add Windows Form**, adı `Ders05_AlanVsYerel`.
3. Forma bir buton (`btnSay`, Text "Say") ve bir etiket (`lblSonuc`) ekle.
4. Butona çift tıkla (`Click` olayı açılır).

## Hangi event

`btnSay_Click` gövdesine KAVRAM bloğunu yapıştır. `sayac` satırı ise metodun DIŞINA,
sınıfın içine gider (aşağıda işaretli).

## Menü formuna ekle

`Form1`e buton: `btnDers05`, Text "Ders 05 — Alan vs Yerel".
`new Ders05_AlanVsYerel().Show();`

## Çalıştı mı?

- Her tıklamada sayı 1 artmalı: 1, 2, 3, 4...
- SEN YAP'taki denemeyi yaptıktan sonra sayı hep 1'de takılı kalmalı — bu HATA değil,
  dersin kendisi.
