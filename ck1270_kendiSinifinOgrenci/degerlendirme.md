# Değerlendirme — ck1270 Kendi sınıfın

1. `ogr1` ve `ogr2` AYNI sınıftan (`Ogrenci`) üretildi ama farklı isim/numara taşıyor.
   Bu nasıl mümkün?
   > Cevap notu: `new Ogrenci()` her çağrıldığında bambaşka, bağımsız bir nesne üretir —
   > `ogr1.ad`'a "Ayşe" atamak `ogr2.ad`'ı etkilemez, tıpkı ck1230'daki butonlar gibi.

2. `Tanit()` metodu neden parametre almadan `ad` ve `numara`ya ulaşabiliyor?
   > Cevap notu: `Tanit()`, `Ogrenci` sınıfının KENDİ metodu — aynı sınıfın alanlarına
   > (ad, numara) doğrudan erişebilir, dışarıdan almasına gerek yok.

3. `class Ogrenci` ile Program.cs'teki `class Program` arasındaki fark ne?
   > Cevap notu: İkisi de sınıf ama Program `static` işaretliydi (hiç nesne üretilmez),
   > Ogrenci `static` DEĞİL — bu yüzden `new Ogrenci()` ile istediğin kadar bağımsız
   > nesne üretebiliyorsun.
