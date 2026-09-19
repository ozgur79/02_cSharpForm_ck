// ck1100 — İki sayıyı topla (ünite 06 girişi)
// NASIL: Ders01_IkiSayiTopla formuna kontrolleri ekle (bkz. kurulum.md), bloğu
//        btnTopla_Click gövdesine yapıştır.
// Ne öğreneceğiz: Console'da öğrendiğin HER ŞEY (Convert.ToInt32, +) burada da aynen
//                 çalışıyor — tek fark, veri artık Console.ReadLine()'dan değil bir
//                 TextBox'ın Text'inden geliyor.

// --- KAVRAM: sınıf alanı (herhangi bir metodun DIŞINA) ---
int sayi1, sayi2, sonuc;

// --- KAVRAM: btnTopla_Click gövdesinin içine ---
sayi1 = Convert.ToInt32(txtSayi1.Text);
sayi2 = Convert.ToInt32(txtSayi2.Text);
sonuc = sayi1 + sayi2;
MessageBox.Show(sonuc.ToString());

// --- SEN YAP ---
// Toplama yerine çıkarma yapan ikinci bir buton ekle: Name btnCikar, Text "Çıkar".
