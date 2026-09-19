# Değerlendirme — ck1350 Trafik lambası

1. `sayac == 3` olunca neden kırmızıdan sarıya geçiliyor, `sayac == 1` ya da `2`de değil?
   > Cevap notu: Kırmızının 3 SANİYE sürmesi isteniyor — Timer 1 saniyede bir tetiklendiği
   > için 3 tetiklenme (3 saniye) geçmeden geçiş yapılmamalı.

2. `sayac = 0;` satırı en sonda (`sayac == 6` bloğunda) neden var?
   > Cevap notu: Döngü baştan başlasın diye — bu satır olmasaydı sayaç sonsuza kadar
   > artardı, `if`lerden hiçbiri BİR DAHA doğru olmazdı, lamba hep yeşilde kalırdı.

3. Formun `Load` olayında neden `btnUst.BackColor = Color.Red;` var?
   > Cevap notu: Form ilk açıldığında Timer henüz hiç Tick üretmemiş oluyor —
   > `sayac == 0` durumunda kırmızının yanıyor olması için başlangıç rengi Load'da elle
   > veriliyor.
