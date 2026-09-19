# Değerlendirme — ck1150 Gizli parola

1. PasswordChar `*` yapılınca, kod içinde `txtParola.Text` yazınca hâlâ gerçek yazı mı
   gelir, yoksa yıldızlar mı?
   > Cevap notu: Gerçek yazı gelir — PasswordChar sadece EKRANDAKİ görünüşü değiştirir,
   > `.Text` içindeki gerçek değeri etkilemez.

2. `kosul` neden `&&` ile kuruluyor, `||` olsaydı ne fark ederdi?
   > Cevap notu: `&&` ile İKİSİ DE doğru olmalı (kullanıcı adı VE parola); `||` olsaydı
   > sadece biri doğru olsa bile giriş kabul edilirdi — çok daha güvensiz olurdu.
