// ck1390 — Timer ile hız kontrolü (Interval'i koddan değiştir) — ünite 08 kapanışı
// NASIL: Alan bloğu sınıfın içine, kalan üç blok ilgili gövdelere.
// Ne öğreneceğiz: `Interval`, Designer'da SADECE başlangıç değeri veriyordu — kod
//                 İÇİNDEN, program ÇALIŞIRKEN de değiştirilebilir. `timer1.Interval =
//                 zaman;` çalıştığı anda Timer'ın hızı anında değişiyor.

// --- KAVRAM: sınıfın içine, hiçbir metodun dışına (alanlar) ---
private int a = 0;
private int zaman = 500;

// --- KAVRAM: timer1_Tick gövdesinin içine ---
a++;
if (a % 2 == 0)
{
    btnGosterge.Visible = false;
}
else
{
    btnGosterge.Visible = true;
}

// --- KAVRAM: btnYavaslat_Click gövdesinin içine ---
zaman = zaman + 50;
timer1.Interval = zaman;

// --- KAVRAM: btnHizlandir_Click gövdesinin içine ---
zaman = zaman - 50;
timer1.Interval = zaman;

// --- SEN YAP ---
// "Hızlandır"a çok basarsan `zaman` sıfıra, hatta EKSİYE düşebilir — `Interval` negatif
// olamayacağı için program ÇÖKER. `btnHizlandir_Click`te `zaman - 50` işleminden önce
// `if (zaman > 50)` kontrolü ekle, sadece 50'den büyükse azalt.
