# Değerlendirme — ck1191 Koşulla göster

1. `grpAskerlik.Visible = false;` satırı `else` dalında neden var, koşul bir kez
   `true` olduysa hep açık kalmaz mı?
   > Cevap notu: Kullanıcı bilgileri değiştirip tekrar Kontrol Et'e basarsa (ör. yaşı
   > küçültürse) bölüm tekrar gizlenmeli — `else` bunu garanti ediyor.

2. `grpAskerlik`in İÇİNE konan `rdbMuaf`/`rdbYapti` da GroupBox gizlenince ne olur?
   > Cevap notu: Onlar da görünmez olur — bir GroupBox'ı gizlemek, içindeki TÜM
   > kontrolleri de birlikte gizler.
