// ck1395 — Zamanlı quiz sorusu (ek pekiştirme)
// NASIL: timer1_Tick ve btnCevapla_Click gövdelerine ilgili blokları yapıştır.
// Ne öğreneceğiz: Yeni bir şey yok — ck1180'in RadioButton'ı ile bu ünitenin Timer'ı
//                 aynı derste bir arada, birbirinden bağımsız çalışıyor. Timer süreyi,
//                 buton doğruluğu kontrol ediyor.

// --- KAVRAM: timer1_Tick gövdesinin içine ---
timer1.Stop();
MessageBox.Show("Süre doldu");
this.Close();

// --- KAVRAM: btnCevapla_Click gövdesinin içine ---
timer1.Stop();
if (rdbB.Checked)
{
    MessageBox.Show("Tebrikler, cevap doğru");
}
else
{
    MessageBox.Show("Üzgünüz, cevap yanlış");
}
this.Close();

// --- SEN YAP ---
// `txtSoru`nun sorusunu ve dört seçeneği KENDİN değiştir (başka bir konudan bir soru
// yaz), doğru seçeneğe göre `btnCevapla_Click`teki `rdbB.Checked` satırını güncelle.
