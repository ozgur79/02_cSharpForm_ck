// ck0500 — Formu tanı
// NASIL: Unite05 projesine Ders01_FormuTani formunu ekle (bkz. kurulum.md), aşağıdaki
//        blokları ilgili butona çift tıklayınca açılan gövdenin İÇİNE yapıştır.
// Ne öğreneceğiz: Kod artık yukarıdan aşağı kendiliğinden çalışmıyor — sen tıklayınca
//                 çalışıyor. Bir de her kontrolün bir adı (Name) olduğunu.
// Not: Formun üstündeki "public partial class Ders01_FormuTani : Form" ve
//      "InitializeComponent();" satırları VS'in hazır iskeleti. Şimdilik olduğu gibi
//      bırak, ünite 07'de tek tek açacağız.

// --- KAVRAM ---

// >>> Ders01_FormuTani formundaki btnSelamla_Click gövdesinin içine:
lblMesaj.Text = "Merhaba, ben senin ilk formun.";
// lblMesaj = etiketin ADI (Name), Text = üzerinde görünen yazı.
// Console'da Console.WriteLine ile "ekrana" yazıyordun. Burada ekran diye ortak bir yer
// yok: her yazının bir sahibi var, hangi kontrole yazacağını sen söylüyorsun.
// Bu satır program açılınca çalışmaz — sen butona basınca çalışır.

// >>> Form1 (menü formu) içindeki btnDers01_Click gövdesinin içine:
new Ders01_FormuTani().Show();
// Bu satır dersi açan satır. Ne yaptığını ünite 07'de tam konuşacağız; şimdilik
// "o formu ekrana getir" diye oku.

// --- SEN YAP ---
// 1) Ders01_FormuTani formuna ikinci bir buton ekle: Name btnTemizle, Text "Temizle".
//    Basınca lblMesaj'ın yazısı boşalsın.
//    İpucu: boş yazı iki tırnaktır, arasında hiçbir şey yok — ""
// 2) btnSelamla'nın yazdığı cümleyi kendi adınla değiştir.
// 3) Menü formundaki btnDers01'in Text'ini "Birinci Ders" yap ve çalıştır. Buton üzerindeki
//    yazı değişti mi? Peki kodda bir şey değiştirmen gerekti mi? Neden?
