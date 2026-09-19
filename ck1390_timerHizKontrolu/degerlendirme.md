# Değerlendirme — ck1390 Timer ile hız kontrolü

1. `timer1.Interval = zaman;` satırı NE ZAMAN etkili oluyor — formu yeniden mi başlatman
   gerekiyor?
   > Cevap notu: Hayır, ANINDA — Timer çalışırken bile Interval'i değiştirebilirsin,
   > bir sonraki Tick yeni süreye göre gelir.

2. SEN YAP'ta neden `if (zaman > 50)` kontrolü eklemen istendi?
   > Cevap notu: `zaman` sıfıra veya eksiye düşerse `Interval` geçersiz bir değer alır
   > ve program çöker — kontrol, azaltmayı sadece güvenli bir sınırın (50'nin) üstündeyken
   > yapıyor.

3. `btnGosterge`nin yanıp sönme hızı neyi gösteriyor?
   > Cevap notu: `timer1`in GERÇEK Interval'ini — `zaman` küçüldükçe Tick daha sık
   > tetikleniyor, gösterge butonu daha hızlı görünüp kayboluyor; gözle "hız" ölçen bir
   > araç gibi çalışıyor.
