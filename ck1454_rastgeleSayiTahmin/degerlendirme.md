# Değerlendirme — ck1454 Rastgele sayı tahmin oyunu

1. `a` neden Form'un `Load` olayında bir kez üretiliyor, `btnDeneBakalim_Click` içinde
   HER tıklamada değil?
   > Cevap notu: Sayı bir kez seçilip SABİT kalmalı ki tahmin etmenin bir anlamı olsun —
   > her tıklamada yeniden üretilseydi asla doğru bilinemezdi.

2. Doğru tahminde `this.Close();` neden çağrılıyor?
   > Cevap notu: Oyun bitti, form artık ihtiyaç değil — `Close()` formu tamamen kapatıp
   > nesneyi sonlandırıyor (ck1395'teki gibi).

3. `hak == 3` kontrolü `else` bloğunun İÇİNDE, doğru tahmin kontrolünün DIŞINDA neden?
   > Cevap notu: Hak sadece YANLIŞ tahminlerde artmalı — doğru bilince oyun zaten
   > `Close()` ile bitiyor, hak sayısının önemi kalmıyor.
