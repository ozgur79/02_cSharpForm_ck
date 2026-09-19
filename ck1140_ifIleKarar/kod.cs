// ck1140 — if ile karar: kare mi dikdörtgen mi
// NASIL: Ders06_IfIleKarar formuna kontrolleri ekle (bkz. kurulum.md), bloğu
//        btnAnaliz_Click gövdesine yapıştır.
// Ne öğreneceğiz: ck0140/ck0170'teki if/else forma taşındı — pekiştirme.

// --- KAVRAM: sınıf alanı ---
int s1, s2;

// --- KAVRAM: btnAnaliz_Click gövdesinin içine ---
s1 = Convert.ToInt32(txtEn.Text);
s2 = Convert.ToInt32(txtBoy.Text);
if (s1 == s2)
    lblSonuc.Text = "Kare";
else
    lblSonuc.Text = "Dik";

// --- SEN YAP ---
// Kare/dikdörtgen ayrımına ek olarak alanı da hesaplayıp ikinci bir etikette (lblAlan)
// göster: alan = s1 * s2.
