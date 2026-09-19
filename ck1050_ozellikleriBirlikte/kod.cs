// ck1050 — Enabled, Visible, BackColor, Size bir arada
// NASIL: Ders06_OzellikleriGor formuna kontrolleri ekle (bkz. kurulum.md), her bloğu
//        ilgili butona yapıştır.
// Ne öğreneceğiz: ck1020/ck1030'da gördüğün özellik mantığı (Width/Height/BackColor)
//                 dört farklı özellikte tekrar ediyor — pekiştirme.

// --- KAVRAM: sınıf alanı (herhangi bir metodun DIŞINA) ---
int tiklamaSayisi = 0;

// --- KAVRAM: btnBoyut_Click gövdesinin içine ---
btnBoyut.Width = 150;
btnBoyut.Height = 60;

// --- KAVRAM: btnRenk_Click gövdesinin içine ---
btnRenk.BackColor = Color.Black;
btnRenk.ForeColor = Color.White;

// --- KAVRAM: btnGizlen_Click gövdesinin içine ---
tiklamaSayisi++;
if (tiklamaSayisi == 5)
{
    btnGizlen.Visible = false;
}

// --- KAVRAM: btnDevreDisi_Click gövdesinin içine ---
btnDevreDisi.Enabled = false;

// --- SEN YAP ---
// btnGizlen'in kaybolma sayısını 5 yerine kullanıcının seçtiği bir sayı yap: forma bir
// TextBox (txtSayi) ekle, tiklamaSayisi == 5 yerine tiklamaSayisi ==
// Convert.ToInt32(txtSayi.Text) yaz.
