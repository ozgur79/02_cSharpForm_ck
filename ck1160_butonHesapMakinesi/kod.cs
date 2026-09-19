// ck1160 — Buton hesap makinesi
// NASIL: Ders08_ButonHesapMakinesi formuna kontrolleri ekle (bkz. kurulum.md), her
//        bloğu ilgili butona yapıştır.
// Ne öğreneceğiz: ck0220'deki dört işlem forma taşındı — dört ayrı buton, dört ayrı
//                 event, pekiştirme.

// --- KAVRAM: sınıf alanı ---
double s1, s2;

// --- KAVRAM: btnTopla_Click gövdesinin içine ---
s1 = Convert.ToDouble(txtSayi1.Text);
s2 = Convert.ToDouble(txtSayi2.Text);
lblSonuc.Text = (s1 + s2).ToString();

// --- KAVRAM: btnCikar_Click gövdesinin içine ---
s1 = Convert.ToDouble(txtSayi1.Text);
s2 = Convert.ToDouble(txtSayi2.Text);
lblSonuc.Text = (s1 - s2).ToString();

// --- KAVRAM: btnCarp_Click gövdesinin içine ---
s1 = Convert.ToDouble(txtSayi1.Text);
s2 = Convert.ToDouble(txtSayi2.Text);
lblSonuc.Text = (s1 * s2).ToString();

// --- SEN YAP ---
// btnBol_Click gövdesine bölme işlemini kendin yaz — yukarıdaki üç blokla aynı kalıbı
// izle, sadece işareti değiştir.
