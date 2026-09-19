# Değerlendirme — ck1050 Özellikler bir arada

1. `tiklamaSayisi` neden sınıf alanı (metodun dışında), `btnGizlen_Click` içinde değil?
   > Cevap notu: İçeride tanımlansaydı her tıklamada 0'a sıfırlanır, hiçbir zaman 5'e
   > ulaşamazdı — ck1040'taki bool ile aynı sebep.

2. `Enabled = false` ile `Visible = false` arasındaki fark ne?
   > Cevap notu: Enabled=false buton hâlâ görünür ama tıklanamaz (griye döner);
   > Visible=false buton tamamen kaybolur, yerinde boşluk kalır.
