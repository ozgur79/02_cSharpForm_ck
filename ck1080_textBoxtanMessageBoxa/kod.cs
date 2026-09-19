// ck1080 — Veri taşı: TextBox → MessageBox (ünite 05 kapanışı)
// NASIL: Ders09_TextBoxtanMessageBoxa formuna kontrolleri ekle (bkz. kurulum.md), bloğu
//        btnAktar_Click gövdesine yapıştır.
// Ne öğreneceğiz: MessageBox.Show(...) yazının kendi penceresinde AYRI bir kutuda
//                 gösterilmesini sağlayan hazır bir metot — ck1070'teki Label'a yazmanın
//                 alternatifi, ünite 05'in kapanışı.

// --- KAVRAM ---

// >>> btnAktar_Click gövdesinin içine:
MessageBox.Show(txtGirilen.Text);

// --- SEN YAP ---
// MessageBox.Show(txtGirilen.Text, "Bilgi"); şeklinde ikinci bir parametre daha ekle —
// pencerenin başlığı ne oldu, fark et.
