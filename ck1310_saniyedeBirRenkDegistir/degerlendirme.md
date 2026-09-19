# Değerlendirme — ck1310 Saniyede bir renk değiştir

1. Bu derste hiçbir butona basmadan Timer neden çalışmaya başlıyor?
   > Cevap notu: `Enabled = true` Properties'ten ayarlandı — Timer, form açılır açılmaz
   > kendiliğinden Tick tetiklemeye başlıyor, ck1300'deki gibi bir `Start()` çağrısına
   > gerek kalmıyor.

2. `beyaz` değişkeni neden `bool` tipinde?
   > Cevap notu: Sadece İKİ durum var (beyaz/siyah) — `bool` `true`/`false` ile tam
   > olarak bunu temsil ediyor, ck1040'taki durum tutma mantığının aynısı.

3. `Interval`i küçültünce (200) yanıp sönme neden hızlandı?
   > Cevap notu: `Interval`, Tick'ler arasındaki bekleme süresi (milisaniye) — küçük
   > sayı, daha SIK tetiklenme demek.
