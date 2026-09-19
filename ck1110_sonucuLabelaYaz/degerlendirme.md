# Değerlendirme — ck1110 Sonucu Label'a yaz

1. `toplam.ToString()` neden gerekli, `lblSonuc.Text = toplam;` yazamaz mıydık?
   > Cevap notu: `.Text` string bekler, `toplam` int'tir — tipler uyuşmuyor, önce
   > `.ToString()` ile yazıya çevrilmesi gerekir. `Convert.ToInt32` sayıya çeviriyordu,
   > `.ToString()` tam tersini yapıyor.

2. Bu ders ck1100'den ne öğretiyor ki farklı?
   > Cevap notu: Hesaplama mantığı birebir aynı; fark sadece sonucun NEREYE yazıldığı —
   > geçici bir uyarı penceresi mi, kalıcı bir etiket mi.
