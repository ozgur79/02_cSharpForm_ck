# Değerlendirme — ck1430 Katlarını filtrele

1. `lstKatlar.Items.Clear();` en başta neden var?
   > Cevap notu: Olmasaydı, ikinci kez farklı bir sayı denendiğinde YENİ katlar ESKİ
   > listenin ÜSTÜNE eklenir, liste karışırdı — Clear() her seferinde temiz bir başlangıç
   > sağlıyor.

2. `if (i % sayi == 0)` hangi sayıları "kat" olarak seçiyor?
   > Cevap notu: `sayi`ya kalansız (tam) bölünenleri — `%` kalanı veriyordu (ck0270),
   > kalan 0 ise `i`, `sayi`nın bir katı demektir.

3. SEN YAP'taki toplam satırı neden döngünün İÇİNE değil, DIŞINA (sonrasına) yazıldı?
   > Cevap notu: Döngü İÇİNE yazılsaydı her `i` için tekrar tekrar eklenirdi (100 kere) —
   > toplam sayı ancak döngü TAMAMEN bitince belli olur, bu yüzden dışarıda, bir kez.
