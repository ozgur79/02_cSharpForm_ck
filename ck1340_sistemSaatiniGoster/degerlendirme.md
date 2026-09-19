# Değerlendirme — ck1340 Sistem saatini göster

1. `DateTime.Now` neyi veriyor?
   > Cevap notu: Bilgisayarın o anki tarih VE saatini — `Random` gibi, senin üretmediğin,
   > hazır bir kaynaktan okunan bir değer.

2. Saatin sürekli güncellenmesini sağlayan ne?
   > Cevap notu: `Enabled = true` olan Timer'ın her saniye Tick tetiklemesi — her Tick'te
   > `DateTime.Now` YENİDEN okunuyor, o anki saat her seferinde taze geliyor.

3. `ToLongTimeString()` ile `ToShortTimeString()` arasındaki fark ne?
   > Cevap notu: Long, saniyeyi de gösterir ("14:23:07"); Short saniyeyi atlar ("14:23") —
   > ikisi de AYNI `DateTime` değerini, sadece farklı ayrıntı düzeyinde metne çeviriyor.
