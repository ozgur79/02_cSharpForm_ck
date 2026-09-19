# Değerlendirme — ck1410 ListBox'tan silme

1. `SelectedIndex` ne tutuyor?
   > Cevap notu: ListBox'ta o an tıklanıp SEÇİLİ olan satırın sıra numarasını (ilk satır
   > 0, ikinci 1, ...).

2. Hiçbir satır seçili değilken `SelectedIndex` neden `-1` oluyor, neden `0` değil?
   > Cevap notu: `0`, GEÇERLİ bir indeks (ilk satır) olurdu — `-1`, dizide/listede asla
   > karşılığı olmayan bir değer, bu yüzden "hiçbir şey seçili değil" demek için özellikle
   > seçilmiş.

3. `if (lstIsimler.SelectedIndex != -1)` kontrolü olmasaydı ne olurdu?
   > Cevap notu: Hiçbir şey seçili değilken `RemoveAt(-1)` çağrılır, bu geçersiz bir
   > indeks olduğu için program hata verip çökerdi.
