// ck1280 — using kapanıyor: satırı sil, ne bozuluyor gör
// NASIL: Ders06_KendiSinifin.cs dosyasının en üstündeki `using System.Windows.Forms;`
//        satırını sil, derle, sonucu gözlemle, sonra geri koy (bkz. kurulum.md).
// Ne öğreneceğiz: `using` satırlarının hepsini ünite 07'de açacağız demiştik. `Form`,
//                 `Button`, `Application` gibi isimler aslında "System.Windows.Forms"
//                 diye uzun bir adresin İÇİNDE yaşıyor. `using System.Windows.Forms;`
//                 dediğinde, o adresi her seferinde yazmak zorunda kalmıyorsun.

// --- KAVRAM: bu ders için "silinecek" satır (Ders06_KendiSinifin.cs'in en üstünde) ---
using System.Windows.Forms;

// --- SEN YAP ---
// Satırı sildikten sonra derlemeyi dene. Hata mesajında geçen "Form" kelimesinin önüne
// tam adresini yazarsan (using olmadan da) hata gider mi? Dene:
// public partial class Ders06_KendiSinifin : System.Windows.Forms.Form
// Çalıştıysa GERİ AL — `using` satırını ekleyip bu uzun hâli sil, ders using'li biter.

// --- MERAK KÖŞESİ ---
// using'in açtığı adres bir KLASÖR gibi düşünülebilir: System.Windows.Forms, Microsoft'un
// yazdığı Form/Button/Label gibi sınıfların durduğu klasör. `using` o klasörü "aç" demek —
// açık olunca içindekilere kısa isimle (Form, Button) ulaşabiliyorsun. Kendi sınıfın olan
// Ogrenci'nin başına using gerekmiyordu çünkü o zaten AYNI namespace'in (Unite07) içinde.
