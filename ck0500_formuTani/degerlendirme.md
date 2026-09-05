# Değerlendirme — ck0500 Formu tanı

Öğrenci projeyi çalıştırıp gösterdikten sonra sorulur.

1. Console projelerinde kodun program açılır açılmaz çalışıyordu. Burada
   `lblMesaj.Text = "..."` satırı ne zaman çalıştı? Neden o an?
   > Cevap notu: Butona basınca. Kod bir **olayın** içinde duruyor, program o olay olana
   > kadar bekliyor. "Tıklayınca çalıştı" demesi yeterli; "olay" terimini kullanması şart
   > değil, ama beklediğini fark etmesi şart.

2. Etiketin adını `lblMesaj` yaptık, `label1` olarak bırakmadık. Formda 10 tane etiket olsa
   bu neden önemli olurdu?
   > Cevap notu: Koda `label1`, `label7` yazınca hangisi olduğu anlaşılmaz; ad ne işe
   > yaradığını söylemeli. Öğrenci "karışır" derse yeterli.

3. `SEN YAP` 3'te menü butonunun `Text`ini değiştirdin, buton üzerindeki yazı değişti ama
   kodda hiçbir şeye dokunmadın. Neden kod bozulmadı?
   > Cevap notu: `Text` görünen yazı, `Name` ise kontrolün kimliği. Kod `Name` üzerinden
   > çalışır. Bu ikisini ayırt etmesi asıl kazanım — `Name`i değiştirseydi kod bozulurdu.
   > İstersen denet: Name'i değiştirip çalıştırsın, hatayı görsün.
