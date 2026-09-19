# Değerlendirme — ck1200 Perdeyi kaldır

1. `this.btnSelamla = new System.Windows.Forms.Button();` satırını sen hiç yazmadın,
   ama Designer.cs'te var. Nasıl oraya geldi?
   > Cevap notu: Toolbox'tan butonu forma sürüklediğinde VS bu satırı senin adına
   > otomatik yazdı — "sürükle-bırak" görsel bir kısayol, arkasında gerçek kod var.

2. `Controls.Add(...)` satırı silinseydi ne olurdu?
   > Cevap notu: Buton hâlâ `new` ile oluşturulurdu (bellekte var olurdu) ama FORMA
   > eklenmediği için ekranda hiç görünmezdi.
