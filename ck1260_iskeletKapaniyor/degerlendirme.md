# Değerlendirme — ck1260 İskelet kapanıyor

1. `namespace Unite05` ne işe yarıyor?
   > Cevap notu: Projedeki tüm sınıfları bir çatı altında topluyor; başka bir projede
   > aynı isimde bir sınıf olsa bile namespace farklı olduğu için karışmaz.

2. `static void Main()` neden "programın başladığı yer" olarak adlandırılıyor?
   > Cevap notu: Bilgisayar programı çalıştırdığında ilk çalışacak kod satırı burasıdır —
   > `Application.Run(new Form1());` satırı da Form1'i üretip ekrana koyan satırdır.

3. Console'daki `class Program`/`static Main` ile buradaki AYNI mı, yoksa WinForms'a özel
   farklı bir şey mi?
   > Cevap notu: Aynı kutu — her iki projede de C# programının "buradan başla" noktası bu
   > ikisi. Fark sadece içindeki tek satırda: Console'da ekrana yazı yazıyordu, burada
   > formu ekrana getiriyor.

4. `partial class Form1` neden iki dosyaya (`Form1.cs` ve `Form1.Designer.cs`) bölünmüş?
   > Cevap notu: Biri VS'in ürettiği (Designer.cs — sürükle-bırak satırları), diğeri
   > senin yazdığın (Form1.cs — Click gövdeleri). `partial` ikisini derlerken TEK sınıf
   > gibi birleştiriyor; böylece VS'in ürettiği koda dokunmadan kendi kodunu yazabiliyorsun.

5. Console'da her programın sonunda duran `Console.ReadKey();` WinForms'ta neden yok?
   > Cevap notu: O satırın işi programı kapanmadan bekletmekti. WinForms'ta bu işi
   > `Application.Run(new Form1());` görüyor — form ekranda açık kaldığı sürece program
   > da kapanmıyor, ayrı bir "bekle" satırına gerek kalmıyor.
