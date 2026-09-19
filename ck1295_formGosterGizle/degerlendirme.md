# Değerlendirme — ck1295 Form göster/gizle

1. `Hide()` ile `Close()` arasındaki fark ne?
   > Cevap notu: `Hide()` nesneyi hafızada TUTAR, sadece görünmez yapar — `Show()` ile
   > geri getirilebilir. `Close()` nesneyi gerçekten kapatır/yok eder, geri getirilemez.

2. "Beni Gizle"ye bastıktan sonra FormA'nın programı hâlâ çalışıyor olduğunu nereden
   anlarsın?
   > Cevap notu: Görev Çubuğu'nda / Alt+Tab listesinde uygulama hâlâ görünür — sadece
   > pencere ekrandan kayboldu, program (ve FormA nesnesi) arka planda yaşamaya devam
   > ediyor.

3. `Application.OpenForms["Ders08_FormA"]` satırı ne işe yarıyor?
   > Cevap notu: Programın o an açık (gizli olsa bile) TÜM formlarını bir liste gibi
   > tutar; isimle arayıp bulmanı sağlar — FormB'nin, FormA'ya doğrudan bir referansı
   > olmasa bile FormA'yı bulup `Show()` çağırabilmesinin yolu bu.
