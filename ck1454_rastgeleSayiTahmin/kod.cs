// ck1454 — Rastgele sayı tahmin oyunu (ek pekiştirme)
// NASIL: Alan blokları sınıfın içine, kalan iki blok ilgili gövdelere.
// Ne öğreneceğiz: Yeni bir şey yok — ck1420'nin Random'ı, ck1150'nin hak sayma mantığı
//                 ve ck1395'in `this.Close();` kullanımı bir arada.

// --- KAVRAM: sınıfın içine, hiçbir metodun dışına (alanlar) ---
private Random rnd = new Random();
private int a;
private int hak = 0;

// --- KAVRAM: Ders08_RastgeleSayiTahmin_Load gövdesinin içine ---
a = rnd.Next(1, 9);

// --- KAVRAM: btnDeneBakalim_Click gövdesinin içine ---
if (txtTahmin.Text == a.ToString())
{
    MessageBox.Show("Aferin, bildin!");
    this.Close();
}
else
{
    hak++;
    if (hak == 3)
    {
        MessageBox.Show("Hakkın bitti, doğru cevap: " + a);
        this.Close();
    }
    else
    {
        MessageBox.Show("Olmadı, tekrar dene.");
    }
}

// --- SEN YAP ---
// Kalan hak sayısını gösteren bir Label ekle (`lblKalanHak`). Her yanlış tahminde
// `lblKalanHak.Text = "Kalan hak: " + (3 - hak);` ile güncelle.
