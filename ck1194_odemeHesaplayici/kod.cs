// ck1194 — Ödeme hesaplayıcı: switch ile taksit (ünite 06'nın ek pekiştirme kapanışı)
// NASIL: Ders15_OdemeHesaplayici formuna kontrolleri ekle (bkz. kurulum.md), her bloğu
//        ilgili ComboBox'a yapıştır.
// Ne öğreneceğiz: switch, ünite 06'nın öğrettiği her şeyi (ComboBox seçimi, Convert,
//                 yüzde hesabı — ck0300'deki KDV formülü) TEK bir derste birleştiriyor.

// --- KAVRAM: sınıf alanı ---
double tutar;

// --- KAVRAM: cmbUrun_SelectedIndexChanged gövdesinin içine ---
switch (cmbUrun.SelectedIndex)
{
    case 0: txtBirimFiyat.Text = "50"; break;
    case 1: txtBirimFiyat.Text = "40"; break;
    case 2: txtBirimFiyat.Text = "30"; break;
}

// --- KAVRAM: cmbTaksit_SelectedIndexChanged gövdesinin içine ---
tutar = Convert.ToDouble(txtBirimFiyat.Text) * Convert.ToInt32(txtAdet.Text);
switch (cmbTaksit.SelectedIndex)
{
    case 0:
        lblSonTutar.Text = tutar.ToString() + " TL (peşin)";
        break;
    case 1:
        tutar = tutar * 1.03;
        lblSonTutar.Text = tutar.ToString() + " TL (3 taksit)";
        break;
    case 2:
        tutar = tutar * 1.06;
        lblSonTutar.Text = tutar.ToString() + " TL (6 taksit)";
        break;
}

// --- SEN YAP ---
// cmbTaksit'e "9 Taksit" seçeneğini ekle (Designer'dan), switch'e üçüncü bir case
// (case 3) ekleyip %9 komisyon uygula.
