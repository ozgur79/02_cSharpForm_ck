# Değerlendirme — ck1280 using kapanıyor

1. `using System.Windows.Forms;` satırını silince hangi kelimenin altı kırmızı çizildi,
   neden?
   > Cevap notu: `Form` kelimesi — C#, `Form`'un `System.Windows.Forms` adresinde
   > yaşadığını `using` sayesinde biliyordu; satır silinince adresi bilemedi.

2. `System.Windows.Forms.Form` yazınca (tam adresle) hata neden gitti?
   > Cevap notu: `using`, kısayol sağlıyordu ama ZORUNLU değildi — tam adresi elle
   > yazarsan `using`e hiç gerek kalmaz, sadece daha uzun yazmış olursun.

3. `Ogrenci` sınıfının kullanıldığı satırlarda neden hiç `using` gerekmedi?
   > Cevap notu: `Ogrenci`, aynı projede, AYNI namespace'in (Unite07) içinde tanımlı —
   > `using`e sadece BAŞKA bir namespace'teki isimlere ulaşmak için ihtiyaç var.
