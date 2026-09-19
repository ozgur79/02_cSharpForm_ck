// ck1210 — Sen yaz: kod ile buton üret
// NASIL: Ders01_KendiButonunuUret formunun kendisine çift tıkla (Load olayı açılır),
//        bloğu o gövdeye yapıştır.
// Ne öğreneceğiz: ck1200'de VS'in yazdığını gördüğün satırları BİZZAT yazıyoruz —
//                 `new Button()` ile bir buton nesnesi üretip `Controls.Add` ile forma
//                 ekliyoruz. `+=` ile bir olaya (Click) hangi metodun çalışacağını
//                 KOD İÇİNDE bağlıyoruz — çift tıklamanın arkasında bu satır var.

// --- KAVRAM: Ders01_KendiButonunuUret_Load gövdesinin içine ---
Button btnKendim = new Button();
btnKendim.Text = "Bana Tıkla";
btnKendim.Click += btnKendim_Click;
this.Controls.Add(btnKendim);

// --- KAVRAM: gövdenin DIŞINA, sınıfın içine ---
private void btnKendim_Click(object sender, EventArgs e)
{
    MessageBox.Show("Beni kod yazarak ürettin!");
}

// --- SEN YAP ---
// İkinci bir buton daha üret (aynı Load gövdesinde): btnKendim2, Text "Bir Tane Daha".
// Farklı bir mesaj gösteren kendi Click metodunu da yaz. Dikkat: ikinci buton
// birincinin TAM ÜSTÜNE gelir (ikisi de varsayılan konumda doğar) — görünsün diye
// `btnKendim2.Top = 50;` satırını da ekle (tam konumlandırmayı ck1220'de göreceğiz).
