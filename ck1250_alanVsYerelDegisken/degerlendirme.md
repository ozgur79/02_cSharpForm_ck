# Değerlendirme — ck1250 Alan vs yerel değişken

1. SEN YAP'ta `sayac`'ı `btnSay_Click`'in içine taşıyınca sayı neden hep "1"de kaldı?
   > Cevap notu: Metodun içinde tanımlanan yerel değişken, metot her çağrıldığında
   > YENİDEN `0`'dan doğuyor. Click her tıklamada baştan çalıştığı için `sayac` hep
   > sıfırdan başlayıp bir artıp "1" oluyor, önceki tıklamayı hatırlamıyor.

2. `private int sayac = 0;` satırı neden sınıfın içinde ama HİÇBİR metodun içinde değil?
   > Cevap notu: Orası "alan" konumu — sınıfa ait, tüm metotların ortak erişebildiği bir
   > yer. Metot bitse bile alan yok olmaz, bir sonraki çağrıda kaldığı yerden devam eder.

3. ck1040'taki `bool` değişkenini hatırla — o da alan mıydı? Neden öyle tanımlanmıştı?
   > Cevap notu: Evet, alandı — buton her tıklandığında "önde mi arkada mı" durumunu
   > HATIRLAMASI gerekiyordu, yerel değişken olsaydı her tıklamada sıfırlanır, durum hiç
   > değişmemiş gibi görünürdü.
