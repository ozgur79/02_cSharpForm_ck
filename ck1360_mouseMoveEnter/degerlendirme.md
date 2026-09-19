# Değerlendirme — ck1360 MouseMove / MouseLeave

1. `MouseMove` ile `Click` arasındaki fark ne?
   > Cevap notu: `Click` sadece TIKLAYINCA tetiklenir; `MouseMove` fare kontrolün
   > üzerindeyken, tıklama olmadan da sürekli tetiklenir.

2. `MouseLeave` ne zaman tetikleniyor?
   > Cevap notu: Fare, o kontrolün üzerinden AYRILDIĞI an, bir kez.

3. Bu derste `object sender, EventArgs e` yerine `MouseMove`da neden `MouseEventArgs e`
   görüyorsun?
   > Cevap notu: Fare olayları ek bilgi taşıyor (fareyle ilgili, örn. X/Y konumu) — bu
   > yüzden `EventArgs` yerine daha ZENGİN bir tür olan `MouseEventArgs` kullanılıyor;
   > parantezin GENEL yapısı (`object sender, ... e`) yine aynı kalıyor.
