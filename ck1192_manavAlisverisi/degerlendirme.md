# Değerlendirme — ck1192 Manav alışverişi

1. `toplam` neden sınıf alanı, `btnSepeteAt_Click`in içinde tanımlanmadı?
   > Cevap notu: İçeride olsaydı her tıklamada sıfırlanırdı, sepete eklenen önceki
   > ürünlerin tutarı unutulurdu — ck0850'deki biriktirici ile aynı sebep.

2. `cmbKilo.SelectedItem.ToString()` neden `Convert.ToInt32` ile sarılmış?
   > Cevap notu: ComboBox'ın seçili öğesi bir metin ("2" gibi) döner; kilo ile fiyatı
   > çarpabilmek için önce sayıya çevrilmesi gerekiyor.
