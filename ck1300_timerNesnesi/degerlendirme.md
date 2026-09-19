# Değerlendirme — ck1300 Timer nesnesi

1. `Interval = 1000` ne anlama geliyor?
   > Cevap notu: 1000 milisaniye = 1 saniye. Timer, Interval'de yazılan süre kadar zaman
   > geçtikçe Tick olayını tekrar tekrar tetikler.

2. "Durdur"a basınca sayaç neden sıfırlanmıyor, olduğu yerde kalıyor?
   > Cevap notu: `Stop()` sadece Tick'in tetiklenmesini durduruyor, `saniye` alanının
   > değerine dokunmuyor — alan (ck1250) kalıcı olduğu için değeri korunuyor.

3. `saniye` neden alan (sınıfın içinde, metodun dışında) olarak tanımlandı, `timer1_Tick`
   içinde değil?
   > Cevap notu: Yerel değişken olsaydı her Tick'te sıfırdan başlardı (ck1250'deki hata),
   > sayaç hiç ilerleyemezdi — alan olduğu için bir önceki Tick'in değerini hatırlıyor.
