// ck1295 — Form göster/gizle: iki form arasında geçiş (ek pekiştirme)
// NASIL: Ders08_FormA formunda btnFormBAc ve btnBeniGizle butonlarına çift tıkla,
//        her birinin Click gövdesine ilgili bloğu yapıştır.
// Ne öğreneceğiz: `Show()` bir nesneyi ekrana koyuyordu. `Hide()` ise nesneyi ORTADAN
//                 KALDIRMIYOR, sadece görünmez yapıyor — nesne hafızada yaşamaya devam
//                 ediyor, `Show()` ile tekrar çağrılabilir. `Close()` farklı bir şey
//                 yapardı: nesneyi gerçekten yok ederdi.

// --- KAVRAM: btnFormBAc_Click gövdesinin içine ---
Ders08_FormB frmB = new Ders08_FormB();
frmB.Show();

// --- KAVRAM: btnBeniGizle_Click gövdesinin içine ---
this.Hide();

// --- SEN YAP ---
// Ders08_FormB'ye de bir buton ekle (`btnFormAyiGeriGetir`, Text "FormA'yı Geri Getir").
// Click içine `Application.OpenForms["Ders08_FormA"].Show();` yaz — bu satır, hafızada
// hâlâ yaşayan (gizlenmiş) FormA'yı bulup tekrar görünür yapar.
