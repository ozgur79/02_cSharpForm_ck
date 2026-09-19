# Değerlendirme — ck1440 PictureBox + ImageList

1. `imageList1.Images[index]` yazımı, ck0660'taki dizi erişimine (`dizi[i]`) neden benziyor?
   > Cevap notu: İkisi de köşeli parantez içinde bir SIRA NUMARASI (indeks) ile belirli
   > bir elemana ulaşıyor — `ImageList` de resimleri tıpkı bir dizi gibi sırayla saklıyor.

2. `if (index >= imageList1.Images.Count) index = 0;` satırı olmasaydı ne olurdu?
   > Cevap notu: Son resimden sonra `index`, `Images.Count`u aşan geçersiz bir sayı
   > olurdu — `imageList1.Images[geçersiz sayı]` çağrısı program çökerdi.

3. `picGoster.Image = imageList1.Images[index];` satırı hangi kontrolün hangi özelliğine
   atama yapıyor?
   > Cevap notu: `PictureBox`in (`picGoster`) `Image` özelliğine — Text/BackColor gibi,
   > kod içinden değiştirilebilen bir özellik, sadece bu kez içine bir RESİM konuyor.
