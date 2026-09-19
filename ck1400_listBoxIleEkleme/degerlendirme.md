# Değerlendirme — ck1400 ListBox: Items.Add, Items.Count

1. `lstIsimler.Items.Add(txtIsim.Text);` satırı ne yapıyor?
   > Cevap notu: TextBox'taki metni, ListBox'ın İÇİNDEKİ listeye YENİ bir satır olarak
   > ekliyor — TextBox'ın kendisi değişmiyor, sadece içeriği kopyalanıp listeye ekleniyor.

2. `Items.Count` ile dizideki `.Length` arasındaki benzerlik ne?
   > Cevap notu: İkisi de "içinde kaç eleman var" sorusunun cevabı — `Length` dizi için
   > sabitti (ck0660), `Items.Count` ise ListBox'a her `Add` yaptıkça DEĞİŞEBİLİYOR.

3. SEN YAP'taki `if (txtIsim.Text != "")` kontrolü neden gerekiyordu?
   > Cevap notu: Boş TextBox'la "Ekle"ye basmak listeye ANLAMSIZ boş bir satır ekler —
   > kontrol, sadece gerçekten bir şey yazılmışsa eklemeyi sağlıyor.
