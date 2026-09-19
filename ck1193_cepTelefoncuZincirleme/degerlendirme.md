# Değerlendirme — ck1193 Zincirleme ComboBox

1. `cmbModel.Items.Clear();` satırı en başta neden var?
   > Cevap notu: Marka değiştirildiğinde önceki markanın modelleri hâlâ listede
   > kalırdı — Clear() önce listeyi boşaltıp karışıklığı önlüyor.

2. `cmbMarka`nın seçimi neden `cmbModel`in İÇERİĞİNİ değiştirebiliyor, ikisi ayrı
   kontrol değil mi?
   > Cevap notu: Ayrı kontroller ama aynı formun (aynı sınıfın) içindeler — bir
   > kontrolün olayından, forma bakan başka bir kontrole erişip onu değiştirebilirsin.
