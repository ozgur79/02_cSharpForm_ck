// ck1410 — ListBox'tan silme: RemoveAt, SelectedIndex
// NASIL: İlgili bloklar btnEkle_Click ve btnSil_Click gövdelerine.
// Ne öğreneceğiz: `SelectedIndex` — ListBox'ta o an TIKLANMIŞ satırın sıra numarasını
//                 (0'dan başlayarak) tutan bir özellik. `Items.RemoveAt(sayı)` o sıradaki
//                 satırı listeden kaldırıyor. Hiçbir satır seçili değilse SelectedIndex
//                 `-1` olur — dizide olmayan bir indeks, bu yüzden kontrol gerekiyor.

// --- KAVRAM: btnEkle_Click gövdesinin içine ---
lstIsimler.Items.Add(txtIsim.Text);
txtIsim.Text = "";

// --- KAVRAM: btnSil_Click gövdesinin içine ---
if (lstIsimler.SelectedIndex != -1)
{
    lstIsimler.Items.RemoveAt(lstIsimler.SelectedIndex);
}

// --- SEN YAP ---
// `else` ekle: hiçbir satır seçili değilken "Seçileni Sil"e basılırsa
// `MessageBox.Show("Önce listeden bir isim seç.");` göstersin.
