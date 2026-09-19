# ck1240 — Hepsine tek olay bağla, sender ile hangisine basıldığını bul

## Senaryo

ck1230'daki 5 butonun HEPSİ aynı Click olayına bağlanacak. Hangisine basıldığını
`sender` parametresiyle anlayacağız.

## Hazırlık

1. `Unite07` projeni aç.
2. **Project > Add Windows Form**, adı `Ders04_TekOlaySender`.
3. Forma çift tıkla (`Load` olayı açılır).

## Hangi event

`Ders04_TekOlaySender_Load` gövdesine ilk bloğu yapıştır. İkinci blok (`btn_Click`
metodu) gövdenin DIŞINA, sınıfın içine gider.

## Menü formuna ekle

`Form1`e buton: `btnDers04`, Text "Ders 04 — Tek Olay, Sender".
`new Ders04_TekOlaySender().Show();`

## Çalıştı mı?

- 5 buton görünmeli. Her birine bastığında, o butonun ÜZERİNDEKİ yazı "Tıklandı!"
  olarak değişmeli — sadece bastığın buton, diğerleri değil.
