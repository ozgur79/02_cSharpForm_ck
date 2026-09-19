// ck1230 — for ile 5 buton üret: aynı sınıftan çok nesne
// NASIL: Ders03_ForIleButon formunun kendisine çift tıkla, bloğu Load gövdesine
//        yapıştır.
// Ne öğreneceğiz: `new Button()` her çağrıldığında BAMBAŞKA bir buton nesnesi doğar —
//                 hepsi AYNI Button "tarifinden" geliyor ama her biri kendi Location'ını,
//                 kendi Text'ini taşıyor. ck0670'teki for+dizi mantığının aynısı.

// --- KAVRAM ---
for (int i = 1; i <= 5; i++)
{
    Button btnYeni = new Button();
    btnYeni.Text = "Buton " + i;
    btnYeni.Location = new Point(10, i * 35);
    this.Controls.Add(btnYeni);
}

// --- SEN YAP ---
// 5 yerine 8 buton üretsin, ikinci bir sütun oluşacak şekilde X konumunu da i'ye göre
// değiştir (ipucu: i çift ise X=10, tek ise X=150 yapmayı dene — if kullanabilirsin).
