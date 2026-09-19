// ck1290 — Çok formlu uygulama: yaptığın şeyin adı buymuş
// NASIL: Bu ders yeni kod bloğu vermiyor, ünite başından beri yazdığın deseni gösteriyor.
// Ne öğreneceğiz: `new Ders0X_Isim().Show();` deseni "çok formlu uygulama" diye adlandırılır
//                 — TEK bir proje içinde BİRDEN FAZLA form nesnesi, aynı anda ekranda
//                 durabilir. Form1 sadece bir MENÜ, her buton kendi formundan bir nesne
//                 üretip `Show()` ile ekrana koyuyor.

// --- KAVRAM: Unite07\Form1.cs içinde zaten gördüğün desen ---
private void btnDers01_Click(object sender, EventArgs e)
{
    new Ders01_KendiButonunuUret().Show();
}
private void btnDers02_Click(object sender, EventArgs e)
{
    new Ders02_Konumlandir().Show();
}
// Her satır: BAŞKA bir sınıftan (Ders01_KendiButonunuUret, Ders02_Konumlandir...) bir
// nesne üretiyor ve Show() ile o nesneyi ekrana koyuyor. Form1 kapanmıyor — nesneler
// birbirinden bağımsız, aynı anda yaşayabiliyorlar (tıpkı ck1230'daki 5 buton gibi).

// --- SEN YAP ---
// 1. Unite07 projene yeni bir form ekle: `Ders07_KapanisFormum`, üzerine tek bir Label
//    koy, Text'ini istediğin bir kapanış cümlesi yap (örn. "Ünite 07 bitti!").
// 2. Form1'e yeni bir buton ekle (`btnDers07`, Text "Ders 07 — Kapanış") ve Click
//    içine `new Ders07_KapanisFormum().Show();` yaz.
// 3. Çalıştır: Form1 açıkken butona bas, iki form da aynı anda ekranda durabiliyor mu?
