# Değerlendirme — ck1130 Ortalama

1. `toplam`, `i`, `ortalama` neden sınıf alanı, `btnEkle_Click`in içinde değil?
   > Cevap notu: İçeride olsalardı her tıklamada sıfırdan başlardı, "kaçıncı sayı"
   > bilgisi hiç birikmezdi — ck0850/ck1040 ile aynı gerekçe.

2. 0 girilince neden hem `MessageBox` hem `lblSonuc.Text = ""` var, ikisi de mi gerekli?
   > Cevap notu: MessageBox kullanıcıya haber verir, `lblSonuc.Text=""` ekranı temizler —
   > biri bilgilendirme biri sıfırlama, farklı görevler.
