// ck1110 — Sonucu Label'a yaz
// NASIL: Ders02_SonucuLabelaYaz formuna kontrolleri ekle (bkz. kurulum.md), bloğu
//        btnTopla_Click gövdesine yapıştır.
// Ne öğreneceğiz: ck1100'de MessageBox ile ayrı bir pencerede gösterdiğimiz sonucu,
//                 ck1070'teki gibi bir Label'a yazıyoruz — .ToString() sayıyı yazıya
//                 çevirir (Convert.ToInt32'nin tersi).

// --- KAVRAM: sınıf alanı ---
int sayi1, sayi2, toplam;

// --- KAVRAM: btnTopla_Click gövdesinin içine ---
sayi1 = Convert.ToInt32(txtSayi1.Text);
sayi2 = Convert.ToInt32(txtSayi2.Text);
toplam = sayi1 + sayi2;
lblSonuc.Text = toplam.ToString();

// --- SEN YAP ---
// lblSonuc.Text'i "Toplam: 7" gibi göstersin — sayıyı .ToString() ile çevirip başına
// açıklayıcı bir yazı ekle (+ ile birleştirme).
