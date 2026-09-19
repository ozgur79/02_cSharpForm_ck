# Değerlendirme — ck1180 RadioButton ile işlem seçimi

1. RadioButton'larda neden aynı anda sadece biri işaretli kalabiliyor, ComboBox'ta da
   böyle miydi?
   > Cevap notu: Aynı formda/gruptaki RadioButton'lar otomatik olarak birbirini
   > dışlar — biri işaretlenince diğerleri otomatik boşalır. ComboBox zaten liste
   > olduğu için tek seçim doğaldı.

2. Dört RadioButton için dört ayrı CheckedChanged yazmak, ck1170'teki tek if/else if
   zincirinden neden daha çok kod tekrarı içeriyor?
   > Cevap notu: Her RadioButton kendi olayını tetikliyor, ortak bir "hangisi seçili"
   > sorgusu yok — bu yüzden aynı Convert satırları her gövdede tekrar yazılıyor.
