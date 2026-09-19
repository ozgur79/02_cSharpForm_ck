# Değerlendirme — ck1420 Random ile kura çekme

1. `Random rnd = new Random();` neden BİR KEZ, alan olarak yazıldı — `btnKuraCek_Click`in
   içinde her seferinde `new Random()` yazılabilir miydi?
   > Cevap notu: Yazılabilirdi ama art arda hızlı çağrılarda AYNI rastgele diziyi
   > üretme riski var — bir nesne üretip TEKRAR TEKRAR ondan `.Next()` istemek daha
   > güvenilir, bu yüzden alan olarak bir kez üretiliyor.

2. `rnd.Next(0, lstBekleyenler.Items.Count)` neden `Items.Count - 1` değil de doğrudan
   `Items.Count`?
   > Cevap notu: `.Next(min, üst sınır)`ın üst sınırı HARİÇ tutuyor (ck0530) — liste 5
   > elemanlıysa geçerli indeksler 0-4'tür, `Next(0,5)` tam olarak 0,1,2,3,4 üretir.

3. `lstBekleyenler.Items.Count == 0` kontrolü olmasaydı ne olurdu?
   > Cevap notu: Liste boşken `Next(0, 0)` çağrılır, bu geçerli bir aralık değildir ve
   > program hata verip çökerdi — ck1410'daki `-1` kontrolüne benzer bir güvenlik kontrolü.
