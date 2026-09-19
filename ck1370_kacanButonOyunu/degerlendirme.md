# Değerlendirme — ck1370 Kaçan buton oyunu

1. Her butonun kendi `MouseMove` metodu var, ama hepsi aynı işi yapıyor. Bu ck1240'taki
   `sender` çözümünden neden farklı?
   > Cevap notu: ck1240'ta AYNI metot 5 butona bağlıydı, `sender` ile hangisi olduğu
   > bulunuyordu. Burada her butonun KENDİ metodu var — bu daha çok tekrar demek, SEN
   > YAP'ta bunu birleştiriyoruz.

2. SEN YAP'ta `btn2_MouseMove` içine `btn1_MouseMove(sender, e);` yazmak ne işe yarıyor?
   > Cevap notu: `btn2`nin kendi metodunu ÇAĞIRMAK yerine, `btn1`in metodunu kendi
   > `sender`/`e`siyle çağırıyor — kod tekrarı yerine tek bir yerden çalıştırma.

3. `btn6` neden farklı bir mesaj ("Tebrikler:)") gösteriyor?
   > Cevap notu: `btn6_MouseMove` içindeki satır BAŞKA — `MessageBox.Show("Yandınız!");`
   > değil, kazanma mesajı. Her metot bağımsız, istediğin farklı kodu yazabilirsin.
