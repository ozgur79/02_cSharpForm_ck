# Değerlendirme — ck1240 Tek olay, sender ile ayırt etme

1. 5 buton var ama `btn_Click` metodu tek. Bu nasıl mümkün?
   > Cevap notu: Hepsi AYNI metoda `+=` ile bağlandı (`btnYeni.Click += btn_Click;`).
   > Bir metot, birden fazla butonun olayına bağlanabilir — kod tekrarı olmaz.

2. `btn_Click` içinde `(Button)sender` yazmasak, `basilanButon.Text = ...` satırı neden
   derlenmez?
   > Cevap notu: `sender` parametresi `object` tipinde gelir — C#, `object`in Text
   > özelliği olup olmadığını bilemez. Cast ile "bu aslında bir Button" diyerek
   > Text/BackColor gibi Button'a özel özelliklere erişim açılır.

3. `btn_Click` metodu neden Load gövdesinin DIŞINDA, sınıfın içinde duruyor?
   > Cevap notu: Load içine yazılsaydı sadece o an çalışırdı, olay geldiğinde tekrar
   > çağrılamazdı. Sınıfın içinde bağımsız bir metot olarak durduğu için her Click
   > olayında yeniden çalıştırılabiliyor.
