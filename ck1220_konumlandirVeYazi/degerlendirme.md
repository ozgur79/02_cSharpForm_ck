# Değerlendirme — ck1220 Konumlandır ve yazı ver

1. `new Point(10, 10)` neden `Location`a atanıyor, `Location = 10, 10;` yazamaz mıydık?
   > Cevap notu: Location tek bir sayı değil, X VE Y çiftini birlikte tutan bir "Point"
   > nesnesi bekler — bu yüzden önce bir Point nesnesi (`new Point(...)`) üretilir.

2. `this.Controls.Add(...)` çağırmadan bir buton üretsen ne olur?
   > Cevap notu: Buton bellekte oluşur (new çalışır) ama forma hiç eklenmediği için
   > ekranda görünmez — ck1200'deki aynı gerçek burada da geçerli.
