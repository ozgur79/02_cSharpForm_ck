// ck1420 — Random rnd = new Random(); — kura çekme
// NASIL: Alan bloğu sınıfın içine, kalan iki blok ilgili gövdelere.
// Ne öğreneceğiz: Console'da ck0530'da gördüğün `Random` şimdi burada — ama artık `new`,
//                 `sınıf`, `nesne` ne demek biliyorsun (ünite 07). `new Random()` bir
//                 Random NESNESİ üretiyor, `.Next(min, üst sınır)` de o nesneden rastgele
//                 bir tam sayı istiyor (üst sınır DAHİL DEĞİL — ck0530'u hatırla).

// --- KAVRAM: sınıfın içine, hiçbir metodun dışına (alan) ---
private Random rnd = new Random();

// --- KAVRAM: btnEkle_Click gövdesinin içine ---
lstBekleyenler.Items.Add(txtIsim.Text);
txtIsim.Text = "";

// --- KAVRAM: btnKuraCek_Click gövdesinin içine ---
if (lstBekleyenler.Items.Count == 0)
{
    MessageBox.Show("Bekleyen kimse kalmadı.");
}
else
{
    int index = rnd.Next(0, lstBekleyenler.Items.Count);
    lstSecilenler.Items.Add(lstBekleyenler.Items[index]);
    lstBekleyenler.Items.RemoveAt(index);
}

// --- SEN YAP ---
// Kura çekilen ismi bir `string` değişkende (`cekilenIsim`) sakla, sonra
// `MessageBox.Show(cekilenIsim + " seçildi!");` ile ayrıca göster.
