// ck1070 — Veri taşı: TextBox → Label
// NASIL: Ders08_TextBoxtanLabela formuna kontrolleri ekle (bkz. kurulum.md), bloğu
//        btnAktar_Click gövdesine yapıştır.
// Ne öğreneceğiz: İki kontrolün Text'i birbirine atanabilir — soldaki neyse sağdaki
//                 o olur, tıpkı ck0020'deki değişkenden değişkene atama gibi.

// --- KAVRAM ---

// >>> btnAktar_Click gövdesinin içine:
lblSonuc.Text = txtGirilen.Text;

// --- SEN YAP ---
// Aktarırken yazının başına "Girdiğin: " ekle, öyle göster (ipucu: + ile birleştirme,
// ck0080'deki string toplama gibi).

// --- MERAK KÖŞESİ ---
// new Ders08_TextBoxtanLabela().Show(); satırını her derste tekrar yazıyoruz. Bu satır
// gerçekte ne yapıyor?
// Ekranda YENİ bir pencere ("nesne") oluşturuyor ve onu göster diyor — her derste az
// önce çizdiğin formun BİR KOPYASINI ekrana getiriyor. "new" ve nesne kavramını ünite
// 07'de (ck1210) tam açacağız.
