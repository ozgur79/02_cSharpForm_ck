# Değerlendirme — ck1395 Zamanlı quiz sorusu

1. `btnCevapla_Click`in en başında `timer1.Stop();` neden var?
   > Cevap notu: Öğrenci cevaplayıp form kapanmadan ÖNCE Timer'ın 10 saniye sonra
   > ayrıca "Süre doldu" göstermesini engellemek için — cevap verildiyse süre artık
   > önemli değil.

2. `this.Close();` ile ck1295'teki `this.Hide();` arasındaki fark ne?
   > Cevap notu: `Close()` formu gerçekten KAPATIR (nesne yok olur, geri `Show()` ile
   > açılamaz); `Hide()` sadece görünmez yapar, nesne hafızada yaşamaya devam eder.

3. Bu derste RadioButton (ck1180) ve Timer (ck1300) NEDEN aynı derste birlikte
   kullanılabiliyor?
   > Cevap notu: İkisi birbirinden TAMAMEN bağımsız kontroller — biri kullanıcının
   > seçimini tutuyor, diğeri zamanı sayıyor; aynı formda aynı anda var olmaları hiçbir
   > çakışma yaratmıyor.
