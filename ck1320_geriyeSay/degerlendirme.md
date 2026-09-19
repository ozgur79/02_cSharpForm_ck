# Değerlendirme — ck1320 Geriye sayım

1. `timer1_Tick` içindeki `if (s == 0)` bloğu ne işe yarıyor?
   > Cevap notu: Sayaç sıfıra inince Timer'ı `Stop()` ile durduruyor — yoksa sayaç
   > eksilere (−1, −2...) devam ederdi.

2. `s` değişkeni neden `btnBaslat_Click`te değil, alan olarak tanımlandı?
   > Cevap notu: `btnBaslat_Click` SADECE bir kez çalışıp `s`ye başlangıç değerini veriyor;
   > `timer1_Tick` ise her saniye tekrar tekrar çalışıp `s`yi azaltıyor — ikisinin AYNI
   > `s`ye erişmesi gerekiyor, bu da ancak alan olursa mümkün.

3. SEN YAP'taki `timer1.Stop();` eklemesi neden gerekiyordu?
   > Cevap notu: "Geriye Say"a ikinci kez basmak `timer1.Start()`ı tekrar çağırır ama
   > Timer zaten çalışıyorsa bu bir şeyi bozmaz — asıl risk `s`nin yarım sayımdayken
   > ANİDEN yeni bir başlangıç değeri alması; önce durdurmak sayımı temiz sıfırlıyor.
