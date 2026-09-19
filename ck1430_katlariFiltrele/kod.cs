// ck1430 — ListBox + for + if: katlarını filtrele
// NASIL: btnListele_Click gövdesine bloğu yapıştır.
// Ne öğreneceğiz: Console'daki for+if kombinasyonunu (ck0270 tek/çift, ck0705 dizide
//                 arama) ListBox'a yazdırmakla birleştirmek — 100 sayı arasından SADECE
//                 istediğin şarta uyanları listeye ekliyorsun.

// --- KAVRAM: btnListele_Click gövdesinin içine ---
lstKatlar.Items.Clear();
int sayi = Convert.ToInt32(txtSayi.Text);
for (int i = 1; i <= 100; i++)
{
    if (i % sayi == 0)
    {
        lstKatlar.Items.Add(i);
    }
}

// --- SEN YAP ---
// Listenin en altına, kaç tane kat bulunduğunu da ekle (ipucu: `lstKatlar.Items.Count`
// döngü BİTTİKTEN sonra kaç eleman olduğunu verir) — `lstKatlar.Items.Add("Toplam: " +
// lstKatlar.Items.Count + " tane");` satırını döngüden SONRA ekle.
