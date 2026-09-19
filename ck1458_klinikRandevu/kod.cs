// ck1458 — Klinik randevu kaydı (ek pekiştirme, ünite 09 kapanış)
// NASIL: Blok btnKaydet_Click gövdesinin içine.
// Ne öğreneceğiz: Yeni bir şey yok — bu ders bir SENTEZ: ComboBox.SelectedItem
//                 (ck1170), boş TextBox kontrolü (ck1400) ve İKİ ListBox'ı EŞ ZAMANLI
//                 doldurmak (her ikisine de AYNI ANDA Add çağırarak, sıraları hep eşit
//                 kalır).

// --- KAVRAM: btnKaydet_Click gövdesinin içine ---
if (txtAdSoyad.Text == "")
{
    MessageBox.Show("Lütfen ad soyad girin.");
}
else if (cmbPoliklinik.SelectedItem == null)
{
    MessageBox.Show("Lütfen poliklinik seçin.");
}
else
{
    lstAdSoyad.Items.Add(txtAdSoyad.Text);
    lstPoliklinik.Items.Add(cmbPoliklinik.SelectedItem.ToString());
    txtAdSoyad.Text = "";
    cmbPoliklinik.SelectedIndex = -1;
}

// --- SEN YAP ---
// `lstAdSoyad.SelectedIndexChanged` olayına çift tıkla (Properties > Events). O gövdeye
// `lstPoliklinik.SelectedIndex = lstAdSoyad.SelectedIndex;` yaz — bir hastayı SOL listeden
// seçince SAĞ listede de otomatik aynı satır seçilsin (iki liste "senkron" görünsün).
