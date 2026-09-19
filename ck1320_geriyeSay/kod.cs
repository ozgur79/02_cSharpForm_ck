// ck1320 — Geriye sayım: Label'a yaz, sıfırda dur
// NASIL: btnBaslat_Click ve timer1_Tick gövdelerine ilgili blokları yapıştır, `s` alanı
//        sınıfın içine, hiçbir metodun dışına gider.
// Ne öğreneceğiz: Bir Timer'ı `if` ile birleştirmek — sayaç sıfıra inince Timer'ın
//                 KENDİSİ `Stop()` çağırıp kendini durdurabiliyor.

// --- KAVRAM: sınıfın içine, hiçbir metodun dışına (alan) ---
private int s;

// --- KAVRAM: timer1_Tick gövdesinin içine ---
s = s - 1;
lblSayac.Text = s.ToString();
if (s == 0)
{
    timer1.Stop();
    lblSonuc.Text = "BOOM";
}

// --- KAVRAM: btnBaslat_Click gövdesinin içine ---
s = Convert.ToInt32(txtSayi.Text);
lblSonuc.Text = "";
timer1.Start();

// --- SEN YAP ---
// "Geriye Say"a art arda 2 kez basarsan sayaç garip davranabilir (iki Timer aynı anda
// koşmaya çalışır gibi). `btnBaslat_Click`in en başına `timer1.Stop();` ekle — yeni bir
// sayım başlamadan önce eskisi kesin dursun.
