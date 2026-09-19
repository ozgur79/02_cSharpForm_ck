// ck1130 — Üç sayının ortalaması (biriktirici + sıfırla)
// NASIL: Ders05_Ortalama formuna kontrolleri ekle (bkz. kurulum.md), bloğu
//        btnEkle_Click gövdesine yapıştır.
// Ne öğreneceğiz: ck0850'deki biriktirici (toplam + sayaç) burada BUTONA HER BASIŞTA
//                 bir adım ilerliyor — Console'da bunu bir döngü yapıyordu, burada
//                 döngünün her turu ayrı bir tıklama.

// --- KAVRAM: sınıf alanı ---
double ortalama, sayi, toplam, i;

// --- KAVRAM: btnEkle_Click gövdesinin içine ---
sayi = Convert.ToInt32(txtSayi.Text);
if (sayi == 0)
{
    MessageBox.Show("İşlem Bitmiştir...");
    lblSonuc.Text = "";
    toplam = 0;
    i = 0;
    ortalama = 0;
}
else
{
    i++;
    toplam = toplam + sayi;
    ortalama = toplam / i;
    lblSonuc.Text = i + ". sayıyı girdiniz, ortalama: " + ortalama.ToString();
}

// --- SEN YAP ---
// txtSayi.Clear(); satırını her iki dalın da sonuna ekle — kutunun kendisi de her
// basıştan sonra boşalsın (ck1060'taki Clear()'ı hatırla).
