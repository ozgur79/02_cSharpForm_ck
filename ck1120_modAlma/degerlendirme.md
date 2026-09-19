# Değerlendirme — ck1120 Mod alma

1. `(sayi % 2).ToString()` yazımındaki parantez neden gerekli?
   > Cevap notu: Önce mod işlemi yapılıp SONRA ToString çağrılmalı — parantez olmadan
   > yazım derlenmez/yanlış yorumlanır, işlem sırasını netleştiriyor.

2. 7 sayısı için Mod 2 ve Mod 3 sonuçları neden ikisi de "1" çıktı, tesadüf mü?
   > Cevap notu: Tesadüf — 7=2*3+1 ve 7=3*2+1, ikisi de kalanı 1 bırakıyor. Başka bir
   > sayı (ör. 9) denerse farklı sonuçlar çıkar.
