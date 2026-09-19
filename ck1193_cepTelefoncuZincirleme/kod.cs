// ck1193 — Birbirine bağlı iki ComboBox (ek pekiştirme)
// NASIL: Ders14_ZincirlemeComboBox formuna kontrolleri ekle (bkz. kurulum.md), ilk
//        bloğu cmbMarka_SelectedIndexChanged, ikinci bloğu cmbModel_SelectedIndexChanged
//        gövdelerine yapıştır.
// Ne öğreneceğiz: Bir ComboBox'ın Items'ını KOD İÇİNDE de doldurabiliyoruz —
//                 Items.Clear() önce eskiyi siler, Items.Add() yenilerini ekler. Bir
//                 ComboBox'ın seçimi, bir BAŞKA ComboBox'ın içeriğini değiştirebiliyor.

// --- KAVRAM: cmbMarka_SelectedIndexChanged gövdesinin içine ---
cmbModel.Items.Clear();
if (cmbMarka.SelectedItem.ToString() == "Nokia")
{
    cmbModel.Items.Add("N70");
    cmbModel.Items.Add("N95");
}
else if (cmbMarka.SelectedItem.ToString() == "Motorola")
{
    cmbModel.Items.Add("RAZR55");
}

// --- KAVRAM: cmbModel_SelectedIndexChanged gövdesinin içine ---
if (cmbModel.SelectedItem.ToString() == "N70")
    lblFiyat.Text = "350 TL";
else if (cmbModel.SelectedItem.ToString() == "N95")
    lblFiyat.Text = "1000 TL";
else if (cmbModel.SelectedItem.ToString() == "RAZR55")
    lblFiyat.Text = "280 TL";

// --- SEN YAP ---
// cmbMarka'ya "Siemens" seçeneğini ekle (Designer'dan), if/else if zincirine yeni bir
// dal ekleyip modelini (ör. "C77") ve fiyatını (150 TL) tanımla.
