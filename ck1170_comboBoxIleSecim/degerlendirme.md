# Değerlendirme — ck1170 ComboBox ile işlem seçimi

1. `cmbIslem.SelectedIndex` neden 0'dan başlıyor, 1'den değil?
   > Cevap notu: Listeler (ve diziler) C#'ta hep 0'dan başlar — ck0665'teki dizi
   > indeksleriyle aynı kural, ilk eleman her zaman indis 0'dır.

2. Bu ders ck1160'a göre neden daha az kod tekrarı içeriyor?
   > Cevap notu: ck1160'ta her buton kendi `Convert.ToDouble` satırlarını tekrar
   > ediyordu; burada dönüşüm bir kez yapılıp `if/else if` zinciriyle sadece SONUÇ
   > hesabı değişiyor.
