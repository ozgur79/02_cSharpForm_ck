# Değerlendirme — ck1330 Geriye sayımı durdur/devam ettir

1. `ilkDegerYuklenmedi` alanı olmasaydı ne bozulurdu?
   > Cevap notu: Her "Durdur"/"Devam Et" tıklamasında `s`, TextBox'tan YENİDEN okunurdu —
   > sayaç her tıklamada baştaki sayıya sıfırlanırdı, hiç ilerlemezdi.

2. `calisiyor` alanı `true`/`false` arasında nasıl gidip geliyor, bunu neresi değiştiriyor?
   > Cevap notu: SADECE `btnBaslatDurdur_Click` içindeki `if/else` — her tıklamada tam
   > tersine çevriliyor (`true`yken `false` yapılıyor, tersi de öyle).

3. Aynı butonun Text'i neden koda göre değişebiliyor?
   > Cevap notu: `Text`, `BackColor` gibi bir özellik — kod içinden `btnBaslatDurdur.Text
   > = "..."` ile istediğin an değiştirilebilir, Designer'da yazdığın ilk değer sadece
   > başlangıç.
