// ck1190 — for döngüsünü forma taşı (ünite 06 kapanışı)
// NASIL: Ders11_ForDonguForma formuna kontrolleri ekle (bkz. kurulum.md), bloğu
//        btnYazdir_Click gövdesine yapıştır.
// Ne öğreneceğiz: ck0500'deki for döngüsü ve ck0485'teki string biriktirme burada bir
//                 arada — sonuç Console'a değil, bir Label'a satır satır ekleniyor.

// --- KAVRAM: btnYazdir_Click gövdesinin içine ---
string kelime = txtKelime.Text;
lblSonuc.Text = "";
for (int i = 1; i < 11; i++)
{
    lblSonuc.Text = lblSonuc.Text + i + ". kelime: " + kelime + "\n";
}

// --- SEN YAP ---
// 10 yerine kullanıcının seçtiği bir sayı kadar tekrar etsin — bir TextBox (txtAdet)
// ekle, `i < 11` yerine `i <= Convert.ToInt32(txtAdet.Text)` yaz.
