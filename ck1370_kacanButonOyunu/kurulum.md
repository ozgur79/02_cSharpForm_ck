# ck1370 — Kaçan buton oyunu

## Senaryo

Fareyle formun içinde bir yol izleyeceksin — yanlış yere değersen "Yandınız!", doğru
butona ulaşırsan "Tebrikler!" Altı buton, hepsi MouseMove'a bağlı.

## Hazırlık

1. `Unite08` projeni aç.
2. **Project > Add Windows Form**, adı `Ders08_KacanButonOyunu`.
3. Altı buton ekle (`btn1`...`btn6`), formun her yerine YAYARAK yerleştir (bazıları uzun
   çubuk gibi, bazıları küçük — bir labirent gibi düşün). `btn6`'yı en son, ulaşılması
   zor bir köşeye koy.
4. Her butona MouseMove olayı bağla (Properties > Events > MouseMove'a çift tıkla).

## Hangi event

Her blok, aynı numaralı butonun `MouseMove` gövdesine.

## Menü formuna ekle

`Form1`e buton: `btnDers08`, Text "Ders 08 — Kaçan Buton Oyunu".
`new Ders08_KacanButonOyunu().Show();`

## Çalıştı mı?

- Fareyi `btn1`-`btn5`'ten herhangi birinin üzerinden geçirince "Yandınız!" çıkmalı.
- Fareyi `btn6`'nın üzerinden geçirince "Tebrikler:)" çıkmalı.
