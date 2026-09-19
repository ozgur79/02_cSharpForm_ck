// ck1400 — ListBox: Items.Add, Items.Count — ünite 09 açılış
// NASIL: btnEkle_Click gövdesine bloğu yapıştır.
// Ne öğreneceğiz: `ListBox`, birden fazla satırı üst üste tutabilen yeni bir kontrol.
//                 `Items.Add(...)` bir satır ekliyor, `Items.Count` o an kaç satır
//                 olduğunu veriyor (dizideki `.Length`e benzer, ck0660'ı hatırla).

// --- KAVRAM: btnEkle_Click gövdesinin içine ---
lstIsimler.Items.Add(txtIsim.Text);
txtIsim.Text = "";
lblSayac.Text = "Toplam: " + lstIsimler.Items.Count;

// --- SEN YAP ---
// TextBox boşken "Ekle"ye basılırsa listeye boş bir satır eklenir. `btnEkle_Click`in en
// başına `if (txtIsim.Text != "")` kontrolü ekle — sadece dolu TextBox'ı listeye eklesin.
