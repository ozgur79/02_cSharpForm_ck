// ck1240 — Hepsine tek olay bağla, sender ile hangisine basıldığını bul
// NASIL: Ders04_TekOlaySender formunun kendisine çift tıkla, ilk bloğu Load gövdesine,
//        ikinci bloğu (metot) o gövdenin DIŞINA yapıştır.
// Ne öğreneceğiz: ck1030'dan beri gördüğün `(object sender, EventArgs e)` parantezinin
//                 asıl işi burada ortaya çıkıyor — `sender`, "bu olayı kim tetikledi"
//                 bilgisini taşıyor. Beş farklı buton AYNI metodu çağırabiliyor çünkü
//                 metot `sender`e bakıp "hangisiyim" sorusunu kendi cevaplıyor.

// --- KAVRAM: Ders04_TekOlaySender_Load gövdesinin içine ---
for (int i = 1; i <= 5; i++)
{
    Button btnYeni = new Button();
    btnYeni.Text = "Buton " + i;
    btnYeni.Location = new Point(10, i * 35);
    btnYeni.Click += btn_Click;
    this.Controls.Add(btnYeni);
}

// --- KAVRAM: gövdenin DIŞINA, sınıfın içine ---
private void btn_Click(object sender, EventArgs e)
{
    Button basilanButon = (Button)sender;
    basilanButon.Text = "Tıklandı!";
}

// --- SEN YAP ---
// btn_Click içinde, Text değiştirmenin yanına basilanButon.BackColor = Color.Green;
// satırını da ekle — basılan buton yeşile dönsün.

// --- MERAK KÖŞESİ ---
// (Button)sender — bu ck0650/ck0790'daki (Tip)değer cast'in aynısı!
// sender, en genel hâliyle "herhangi bir nesne" (object) olarak gelir — biz onun
// GERÇEKTE bir Button olduğunu biliyoruz, cast ile bunu C#'a da söylüyoruz. Cast artık
// hem sayılarda hem nesnelerde işine yarıyor.
// `object sender, EventArgs e` kutusu burada kapanıyor — ünite 07'ye kadar verilen sözün
// bu parçası ödendi.
