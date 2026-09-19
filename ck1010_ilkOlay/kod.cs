// ck1010 — İlk olay: formun rengini değiştir
// NASIL: Ders02_IlkOlay formuna btnKirmizi ekle (bkz. kurulum.md), aşağıdaki bloğu
//        çift tıklayınca açılan gövdenin içine yapıştır.
// Ne öğreneceğiz: `this`, çalışan formun KENDİSİNİ işaret eder. `this.BackColor` formun
//                 arka plan rengidir — bir kontrolün değil, formun kendisinin özelliği.

// --- KAVRAM ---

// >>> Ders02_IlkOlay formundaki btnKirmizi_Click gövdesinin içine:
this.BackColor = Color.Red;
// this = "bu form". BackColor bir renk özelliği. Color.Red hazır bir renk değeri.

// --- SEN YAP ---
// İkinci bir buton ekle: Name btnMavi, Text "Mavi Yap". Basınca formu Color.Blue yapsın.

// --- MERAK KÖŞESİ ---
// public partial class Ders02_IlkOlay : Form ne demek?
// "Bu form bir Form'dur, Form'un yapabildiği her şeyi yapabilir" demek — BackColor,
// Text, Left, Top gibi özellikler de bu yüzden çalışıyor, Form'dan geliyorlar.
// Bu satırın tam açılımını ünite 07'de göreceğiz.
