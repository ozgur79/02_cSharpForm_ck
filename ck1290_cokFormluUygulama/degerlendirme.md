# Değerlendirme — ck1290 Çok formlu uygulama

1. `new Ders07_KapanisFormum().Show();` satırı çalışınca Form1 neden kapanmıyor?
   > Cevap notu: `Show()`, yeni bir nesneyi ekrana EKLER, var olan hiçbir formu kapatmaz —
   > `Close()` farklı bir şey yapardı. İki nesne birbirinden bağımsız yaşıyor.

2. Ünite 05'ten beri hep aynı satırı (`new DersXX().Show();`) yazdın. Bu satırın "sınıf"
   ve "nesne" kavramlarıyla bağlantısı ne?
   > Cevap notu: `DersXX` bir sınıf (Microsoft'un `Form`undan türeyen), `new DersXX()`
   > o sınıftan BİR nesne üretiyor, `Show()` de o nesneyi ekrana koyuyor — Button/Ogrenci
   > ile yaptığın işin aynısı, sadece burada üretilen nesne bir Form.

3. Form1'in kendisi de bir sınıftan (`Form1`) üretilmiş bir nesne mi? Nerede üretiliyor?
   > Cevap notu: Evet — ck1260'ta gördüğün `Program.cs`'teki `Application.Run(new
   > Form1());` satırında üretiliyor. Program açılırken üretilen İLK ve TEK Form1 nesnesi.
