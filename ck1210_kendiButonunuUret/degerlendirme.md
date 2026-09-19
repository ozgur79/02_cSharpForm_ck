# Değerlendirme — ck1210 Kendi butonunu üret

1. `btnKendim.Click += btnKendim_Click;` satırı ne yapıyor?
   > Cevap notu: Toolbox'ta bir kontrole çift tıklayınca VS bunu otomatik yapıyordu;
   > burada AYNI bağlantıyı elle kuruyoruz — "Click olayı olunca şu metodu çalıştır" demek.

2. `btnKendim_Click` metodu neden `Ders01_KendiButonunuUret_Load` gövdesinin DIŞINDA
   yazıldı?
   > Cevap notu: Bir olay gövdesi (Load, Click) başka bir olay gövdesinin İÇİNE
   > yazılamaz — her biri sınıfın kendi bağımsız bir metodu olmalı, ck1040'taki
   > alan/metot ayrımıyla aynı mantık.
