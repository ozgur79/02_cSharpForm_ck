// ck1350 — Trafik lambası
// NASIL: Alan bloğu sınıfın içine, ikinci blok formun Load gövdesine, üçüncü blok
//        timer1_Tick gövdesine.
// Ne öğreneceğiz: Bir sayacı (`sayac`) belirli EŞİK değerlerinde kontrol ederek zamanlı
//                 geçişler yapmak — 3 saniye kırmızı, 1 saniye sarı, 2 saniye yeşil.

// --- KAVRAM: sınıfın içine, hiçbir metodun dışına (alan) ---
private int sayac = 0;

// --- KAVRAM: Ders06_TrafikLambasi_Load gövdesinin içine ---
btnUst.BackColor = Color.Red;

// --- KAVRAM: timer1_Tick gövdesinin içine ---
sayac++;
if (sayac == 3)
{
    btnUst.BackColor = Color.White;
    btnOrta.BackColor = Color.Yellow;
}
else if (sayac == 4)
{
    btnOrta.BackColor = Color.White;
    btnAlt.BackColor = Color.Green;
}
else if (sayac == 6)
{
    btnAlt.BackColor = Color.White;
    btnUst.BackColor = Color.Red;
    sayac = 0;
}

// --- SEN YAP ---
// Yeşil süresini 2 saniyeden 3 saniyeye çıkar — hangi sayıyı (3, 4 veya 6) değiştirmen
// gerekiyor? Dene, çalıştır, süreleri say.
