// ck1452 — Diziyle film listesi (ek pekiştirme)
// NASIL: Alan blokları sınıfın içine, kalan iki blok ilgili gövdelere.
// Ne öğreneceğiz: Yeni bir şey yok — Console'daki `string[]` ve `foreach` (ck0670,
//                 ck0705) bilgin, ListBox'sız, doğrudan bir diziyle WinForms'ta.

// --- KAVRAM: sınıfın içine, hiçbir metodun dışına (alanlar) ---
private string[] filmler = new string[3];
private int index = 0;

// --- KAVRAM: btnEkle_Click gövdesinin içine ---
if (index < 3)
{
    filmler[index] = txtFilm.Text;
    index++;
    txtFilm.Text = "";
}
else
{
    MessageBox.Show("Dizinin kapasitesi dolu");
}

// --- KAVRAM: btnGoster_Click gövdesinin içine ---
foreach (string film in filmler)
{
    MessageBox.Show(film);
}

// --- SEN YAP ---
// `btnGoster_Click`teki `foreach`, dizi TAM DOLU değilse boş satırları da (`null`)
// gösterir. `foreach`i şu `if`le sar: `if (film != null) MessageBox.Show(film);` —
// sadece gerçekten girilmiş filmleri göstersin.
