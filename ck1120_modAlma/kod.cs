// ck1120 — Mod alma
// NASIL: Ders04_ModAlma formuna kontrolleri ekle (bkz. kurulum.md), her bloğu ilgili
//        butona yapıştır.
// Ne öğreneceğiz: ck0270'teki % (mod) operatörü forma taşındı — pekiştirme.

// --- KAVRAM: btnMod2_Click gövdesinin içine ---
int sayi = Convert.ToInt32(txtSayi.Text);
lblSonuc.Text = (sayi % 2).ToString();

// --- KAVRAM: btnMod3_Click gövdesinin içine ---
int sayi2 = Convert.ToInt32(txtSayi.Text);
lblSonuc.Text = (sayi2 % 3).ToString();

// --- SEN YAP ---
// Üçüncü bir buton ekle: Name btnMod5, Text "Mod 5". Basınca 5'e bölümünden kalanı göster.
