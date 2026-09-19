# Değerlendirme — ck1100 İki sayıyı topla

1. `Convert.ToInt32(txtSayi1.Text)` satırındaki `txtSayi1.Text` neden doğrudan
   toplanamıyor, önce `Convert.ToInt32` ile çevriliyor?
   > Cevap notu: `.Text` her zaman string'tir (kutuya ne yazılırsa yazılsın) — ck0030'daki
   > aynı gerekçe: string'ler toplanmaz, birleştirilir; sayı gibi toplamak için sayıya
   > çevirmek gerekir.

2. Kutulardan birine sayı yerine harf yazsan ne olur?
   > Cevap notu: Program çöker (FormatException) — Convert.ToInt32 metne çeviremediği
   > bir şeyle karşılaşınca hata fırlatır. Console'daki aynı risk, forma da taşındı.
