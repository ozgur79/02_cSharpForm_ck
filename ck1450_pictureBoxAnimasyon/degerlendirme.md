# Değerlendirme — ck1450 PictureBox animasyon

1. Bu ders hangi ÜÇ önceki fikri bir araya getiriyor?
   > Cevap notu: ck1440'ın resim değiştirme mantığı (index + ImageList), ünite 08'in
   > Timer'ı (kendiliğinden tekrar eden Tick) ve ck1330'un tek-butonla durdur/devam
   > deseni.

2. `if (btnBaslatDurdur.Text == "Başlat")` satırı ck1330'daki `bool calisiyor`dan farklı
   bir yöntemle AYNI işi nasıl yapıyor?
   > Cevap notu: ck1330 durumu ayrı bir `bool` alanda tutuyordu; burada durumun kendisi
   > butonun Text'inde saklanıyor — Text zaten "Başlat"/"Durdur" arasında değiştiği için
   > ayrı bir değişkene gerek kalmadı.

3. Timer'ın Interval'i küçültülünce (300'den 100'e) animasyon nasıl değişiyor?
   > Cevap notu: Resimler daha SIK değişiyor — göz için daha "akıcı" ama daha HIZLI bir
   > animasyon oluyor, tıpkı ck1390'daki hız kontrolü gibi.
