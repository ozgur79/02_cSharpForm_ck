# Değerlendirme — ck1452 Diziyle film listesi

1. `if (index < 3)` kontrolü olmasaydı 4. filmi eklemeye çalışınca ne olurdu?
   > Cevap notu: `filmler[3]` yazılmaya çalışılırdı ama dizinin geçerli indeksleri 0,1,2 —
   > dizinin SINIRLARI dışına çıkıldığı için program hata verip çökerdi.

2. `foreach (string film in filmler)` neden `for (int i = 0; i < filmler.Length; i++)`
   yerine tercih edildi?
   > Cevap notu: Sadece elemanların KENDİSİYLE ilgileniyoruz, sıra numarasına (i)
   > ihtiyacımız yok — `foreach` bu durumda daha kısa ve okunaklı (ck0705'i hatırla).

3. Dizi tam dolu değilken (`index < 3`) `foreach` neden boş (`null`) bir satır gösterir?
   > Cevap notu: `new string[3]` dizinin 3 gözünü de baştan `null` (boş) ile doldurur —
   > sen sadece dolu olan gözlere değer atadın, dokunmadığın gözler hâlâ `null`.
