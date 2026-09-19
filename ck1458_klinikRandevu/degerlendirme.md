# Değerlendirme — ck1458 Klinik randevu kaydı

1. `lstAdSoyad` ve `lstPoliklinik`e AYNI ANDA `Add` çağırmak neden önemli?
   > Cevap notu: İki liste birbirinden BAĞIMSIZ kontroller — biri güncellenip diğeri
   > güncellenmezse sıralar kayar, 3. hastanın adı bir listede 3. satırda, diğerinde
   > farklı bir satırda görünebilirdi.

2. `cmbPoliklinik.SelectedItem == null` kontrolü ne zaman doğru olur?
   > Cevap notu: Kullanıcı ComboBox'tan HİÇBİR seçim yapmadıysa `SelectedItem` boş
   > (`null`) kalır — ck1410'daki `SelectedIndex == -1` kontrolünün ComboBox'taki karşılığı.

3. SEN YAP'taki `SelectedIndexChanged` olayı ne zaman tetikleniyor?
   > Cevap notu: Kullanıcı ListBox'ta FARKLI bir satıra her tıkladığında — Click'ten
   > farklı, özellikle "seçim değişti" anını yakalıyor.
