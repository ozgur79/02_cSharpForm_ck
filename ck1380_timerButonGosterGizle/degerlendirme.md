# Değerlendirme — ck1380 Timer + buton: göster/gizle

1. `btnHedef.Visible = !btnHedef.Visible;` satırı ne yapıyor?
   > Cevap notu: `Visible`ın ŞU ANKİ değerinin TERSİNİ kendisine atıyor — `true` ise
   > `false`, `false` ise `true` yapıyor. Her Tick'te bu satır çalıştığı için buton
   > sürekli görünür/gizli arasında geçiş yapıyor.

2. Buton gizliyken tıklarsan puan artar mı? Neden?
   > Cevap notu: Hayır — `Visible = false` olan bir kontrol EKRANDA yok, tıklanamaz.
   > `btnHedef_Click` sadece buton görünürken, gerçekten tıklanabildiğinde çalışır.

3. `Interval`i 400 yapınca oyun neden zorlaştı?
   > Cevap notu: Buton daha SIK görünüp kayboluyor — tıklayabileceğin süre pencere
   > kısalıyor, hedefe yetişmek zorlaşıyor.
