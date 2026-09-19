# Değerlendirme — ck1030 Butonu büyüt, butonu sakla

1. `btnBuyu.Width += 20;` ve `btnSakla.Hide();` — biri özellik, biri metot. Hangisi hangisi,
   nasıl ayırt ettin?
   > Cevap notu: Width özellik (değer atanıyor, `=` var), Hide metot (parantezi var, iş
   > yapıyor). "Sonunda parantez varsa metot" demesi yeterli.

2. Butonun eski genişliğini hiçbir yerde bir değişkende saklamadın, ama her tıklamada
   büyüdü. Genişlik nerede duruyor?
   > Cevap notu: Butonun kendisinde. Nesne kendi durumunu taşır — asıl kazanım bu.

3. Eklediğin Göster butonuna ne yazdın?
   > Cevap notu: `btnSakla.Show();` olmalı. Sık yapılan hata `btnGoster.Show();` yazmak —
   > gizlenen buton hangisiyse onu göstermek gerekir.
