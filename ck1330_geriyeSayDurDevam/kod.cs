// ck1330 — Geriye sayımı durdur / devam ettir
// NASIL: Alan bloğu sınıfın içine, diğer iki blok ilgili gövdelere.
// Ne öğreneceğiz: TEK bir butonu iki görevli yapmak — `bool calisiyor` durumuna bakıp
//                 "şu an çalışıyor mu?" sorusuna göre ya başlatıyor ya durduruyor. Buton
//                 metni de aynı `bool`a göre değişiyor.

// --- KAVRAM: sınıfın içine, hiçbir metodun dışına (alanlar) ---
private int s;
private bool calisiyor = false;
private bool ilkDegerYuklenmedi = true;

// --- KAVRAM: timer1_Tick gövdesinin içine ---
s = s - 1;
lblSayac.Text = s.ToString();
if (s == 0)
{
    timer1.Stop();
}

// --- KAVRAM: btnBaslatDurdur_Click gövdesinin içine ---
if (ilkDegerYuklenmedi)
{
    s = Convert.ToInt32(txtSayi.Text);
    ilkDegerYuklenmedi = false;
}

if (!calisiyor)
{
    timer1.Start();
    btnBaslatDurdur.Text = "Durdur";
    calisiyor = true;
}
else
{
    timer1.Stop();
    btnBaslatDurdur.Text = "Devam Et";
    calisiyor = false;
}

// --- SEN YAP ---
// Sayaç sıfıra inip Timer kendi kendine durduğunda, buton hâlâ "Durdur" yazıyor —
// yanıltıcı. `timer1_Tick`teki `if (s == 0)` bloğunun içine `btnBaslatDurdur.Text =
// "Bitti";` ve `calisiyor = false;` ekle.
