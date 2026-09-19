// ck1192 — Manav alışverişi (ek pekiştirme)
// NASIL: Ders13_ManavAlisverisi formuna kontrolleri ekle (bkz. kurulum.md), her bloğu
//        ilgili butona yapıştır.
// Ne öğreneceğiz: ListBox.Items.Add ile bir listeye satır satır ekleme — ck0400'deki
//                 ComboBox seçimini ck0290'daki if/else if zinciriyle birleştiriyoruz.

// --- KAVRAM: sınıf alanı ---
int elmaFiyat = 5, armutFiyat = 4, kirazFiyat = 15;
int toplam = 0;

// --- KAVRAM: btnSepeteAt_Click gövdesinin içine ---
int kilo = Convert.ToInt32(cmbKilo.SelectedItem.ToString());
lstSepet.Items.Add(cmbUrun.SelectedItem.ToString() + " " + kilo + " kg");

if (cmbUrun.SelectedItem.ToString() == "elma")
    toplam = toplam + elmaFiyat * kilo;
else if (cmbUrun.SelectedItem.ToString() == "armut")
    toplam = toplam + armutFiyat * kilo;
else if (cmbUrun.SelectedItem.ToString() == "kiraz")
    toplam = toplam + kirazFiyat * kilo;

// --- KAVRAM: btnBitir_Click gövdesinin içine ---
lblTutar.Text = "Ödenecek tutar: " + toplam + " TL";

// --- SEN YAP ---
// Sepete "muz" seçeneğini de ekle (cmbUrun.Items'a Designer'dan ekle), kendi birim
// fiyatını (ör. 8) belirleyip if/else if zincirine yeni bir dal ekle.
