// ck1180 — RadioButton ile işlem seçimi
// NASIL: Ders10_RadioButtonIleSecim formuna kontrolleri ekle (bkz. kurulum.md), bloğu
//        rdbToplama_CheckedChanged gövdesine yapıştır.
// Ne öğreneceğiz: RadioButton'un `Checked` özelliği true/false — işaretlenince
//                 CheckedChanged olayı ateşlenir. ComboBox'takinden farklı bir kontrol
//                 türü, aynı fikir.

// --- KAVRAM: sınıf alanı ---
double s1, s2;

// --- KAVRAM: rdbToplama_CheckedChanged gövdesinin içine ---
s1 = Convert.ToDouble(txtSayi1.Text);
s2 = Convert.ToDouble(txtSayi2.Text);
lblSonuc.Text = (s1 + s2).ToString();

// --- SEN YAP ---
// rdbCikarma, rdbCarpma ve rdbBolme için de aynı kalıpta CheckedChanged gövdeleri
// yaz — her birine çift tıkla, üstteki bloğu kopyala, sadece işareti değiştir.
