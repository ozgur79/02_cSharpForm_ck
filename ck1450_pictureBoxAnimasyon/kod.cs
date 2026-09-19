// ck1450 — PictureBox + ImageList + Timer: animasyon — ünite 09 kapanış
// NASIL: Alan bloğu sınıfın içine, kalan iki blok ilgili gövdelere.
// Ne öğreneceğiz: Yeni bir şey yok — bu ders bir KAPANIŞ: ck1440'ın resim değiştirme
//                 mantığını (index + ImageList), ünite 08'in Timer'ıyla ve ck1330'un
//                 tek-butonla-durdur/devam-et desenini bir araya getiriyor.

// --- KAVRAM: sınıfın içine, hiçbir metodun dışına (alan) ---
private int index = 0;

// --- KAVRAM: timer1_Tick gövdesinin içine ---
index++;
if (index >= imageList1.Images.Count)
{
    index = 0;
}
picGoster.Image = imageList1.Images[index];

// --- KAVRAM: btnBaslatDurdur_Click gövdesinin içine ---
if (btnBaslatDurdur.Text == "Başlat")
{
    timer1.Start();
    btnBaslatDurdur.Text = "Durdur";
}
else
{
    timer1.Stop();
    btnBaslatDurdur.Text = "Başlat";
}

// --- SEN YAP ---
// `Interval`i `100` yap, tekrar dene — animasyon nasıl değişti? Sonra beğendiğin bir
// hıza geri getir. İstersen `Interval`i Properties'ten değil, `btnBaslatDurdur_Click`
// içinden `timer1.Interval = 100;` satırıyla da (ck1390'daki gibi) değiştirebilirsin.
