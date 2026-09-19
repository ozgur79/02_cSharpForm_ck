# Değerlendirme — ck1070 TextBox'tan Label'a

1. `lblSonuc.Text = txtGirilen.Text;` satırında hangi taraf hangi tarafa kopyalanıyor?
   > Cevap notu: Sağdaki (txtGirilen'in yazısı) soldakine (lblSonuc'a) kopyalanıyor —
   > atama her zaman sağdan sola işler, ck0020'deki gibi.

2. Kutuyu boşaltıp tekrar Aktar'a bassan etiket ne olur?
   > Cevap notu: Etiket de boşalır — her tıklamada kutunun O ANKİ değeri kopyalanıyor,
   > eski değeri hatırlamıyor.
