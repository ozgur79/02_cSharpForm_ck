# Değerlendirme — ck0530 Butonu büyüt, butonu sakla

Öğrenci formu çalıştırıp gösterdikten sonra sorulur.

1. `btnBuyu.Width += 20;` ve `btnSakla.Hide();` — biri özellik, biri metot. Hangisi hangisi,
   nasıl ayırt ettin?
   > Cevap notu: Width özellik (değer atanıyor, `=` var), Hide metot (parantezi var, iş
   > yapıyor). "Sonunda parantez varsa metot" demesi yeterli; terimleri karıştırıp kuralı
   > doğru söylüyorsa kabul et.

2. Butonun eski genişliğini hiçbir yerde bir değişkende saklamadın, ama her tıklamada
   büyüdü. Genişlik nerede duruyor?
   > Cevap notu: Butonun kendisinde. Nesne kendi durumunu taşır — asıl kazanım bu.
   > "Bilgisayar hatırlıyor" cevabı yarım; "buton hatırlıyor" demesi hedef.

3. Eklediğin Göster butonunu göster. İçine ne yazdın?
   > Cevap notu: `btnSakla.Show();` olmalı. Sık yapılan hata `btnGoster.Show();` yazmak —
   > gizlenen buton hangisiyse onu göstermek gerekir. Bu hatayı yaptıysa, kendi butonuna
   > basabildiğini yani zaten görünür olduğunu fark ettir.
