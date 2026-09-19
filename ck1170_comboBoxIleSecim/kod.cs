// ck1170 — ComboBox ile işlem seçimi
// NASIL: Ders09_ComboBoxIleSecim formuna kontrolleri ekle (bkz. kurulum.md), bloğu
//        cmbIslem_SelectedIndexChanged gövdesine yapıştır.
// Ne öğreneceğiz: ComboBox bir liste sunar; `SelectedIndex` seçilen satırın sırasını
//                 (0'dan başlar) verir. ck0290'daki switch/if zincirini burada da
//                 kuruyoruz ama artık dört ayrı buton yerine tek bir kontrol var.

// --- KAVRAM: sınıf alanı ---
double s1, s2;

// --- KAVRAM: cmbIslem_SelectedIndexChanged gövdesinin içine ---
s1 = Convert.ToDouble(txtSayi1.Text);
s2 = Convert.ToDouble(txtSayi2.Text);

if (cmbIslem.SelectedIndex == 0)
    lblSonuc.Text = (s1 + s2).ToString();
else if (cmbIslem.SelectedIndex == 1)
    lblSonuc.Text = (s1 - s2).ToString();
else if (cmbIslem.SelectedIndex == 2)
    lblSonuc.Text = (s1 * s2).ToString();
else
    lblSonuc.Text = (s1 / s2).ToString();

// --- SEN YAP ---
// Sonucun yanına hangi işlemin seçildiğini de göstersin — bir Label (lblIslemAdi) ekle,
// her dalda cmbIslem.SelectedItem.ToString()'i o etikete yaz.
