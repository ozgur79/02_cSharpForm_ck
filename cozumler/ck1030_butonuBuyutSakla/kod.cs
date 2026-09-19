// >>> btnBuyu_Click gövdesine ekle (renk):
btnBuyu.BackColor = Color.Yellow; // özellik (= ile atanıyor)

// >>> btnGoster_Click gövdesinin içine:
btnSakla.Hide();  // YANLIŞ - kendini tekrar gizler
btnSakla.Show();  // DOĞRU - gizlenen buton geri gelir

// 3) 20 yerine 100 yapıp 5 kez tıklarsan buton forma sığmaz, kenarlardan taşabilir
// (WinForms bunu otomatik engellemez).
