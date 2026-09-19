// ck1112 — Fonksiyonla toplama (ek pekiştirme)
// NASIL: Ders03_FonksiyonlaToplama formuna kontrolleri ekle (bkz. kurulum.md). "1. BÖLÜM"
//        btnTopla_Click gövdesinin İÇİNE, "2. BÖLÜM" (Topla metodu) o gövdenin DIŞINA,
//        sınıfın içine yapıştırılır.
// Ne öğreneceğiz: Console'daki ck0760'ta yazdığın "kendi fonksiyonun" fikri WinForms'ta
//                 da aynen çalışıyor — buton olayının içi sadece veriyi toplayıp
//                 fonksiyona gönderiyor, gerçek hesaplama ayrı bir yerde duruyor.

// --- KAVRAM: 1. BÖLÜM (btnTopla_Click gövdesinin içine) ---
int sayi1 = Convert.ToInt32(txtSayi1.Text);
int sayi2 = Convert.ToInt32(txtSayi2.Text);
int sonuc = Topla(sayi1, sayi2);
MessageBox.Show(sonuc.ToString());

// --- KAVRAM: 2. BÖLÜM (btnTopla_Click'in dışına, sınıfın içine) ---
private int Topla(int sayi1, int sayi2)
{
    int sonuc = 0;
    sonuc = sayi1 + sayi2;
    return sonuc;
}

// --- SEN YAP ---
// Aynı mantıkla bir Carp(int a, int b) metodu yaz, ikinci bir buton (btnCarp) ekleyip
// çağır.
