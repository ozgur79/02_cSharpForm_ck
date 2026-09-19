// ck1150 — Gizli parola: PasswordChar, doğru/yanlış kontrolü
// NASIL: Ders07_GizliParola formuna kontrolleri ekle (bkz. kurulum.md — txtParola'nın
//        PasswordChar'ını `*` yapmayı unutma), bloğu btnGiris_Click gövdesine yapıştır.
// Ne öğreneceğiz: PasswordChar, bir TextBox'ın YAZILANI DEĞİL, sen neyi göstermek
//                 istediğini belirler — kutunun GERÇEK içeriği (.Text) hâlâ olduğu gibi
//                 okunabiliyor, sadece görünüşü maskeleniyor.

// --- KAVRAM: sınıf alanı ---
bool kosul;

// --- KAVRAM: btnGiris_Click gövdesinin içine ---
kosul = txtKullaniciAdi.Text == "ogrenci" && txtParola.Text == "kalfa123";
if (kosul)
    MessageBox.Show("Başarılı Giriş");
else
    MessageBox.Show("Yanlış Kullanıcı Adı veya Parola");

// --- SEN YAP ---
// Yanlış girişte kutuları da temizle (Clear()) ki kullanıcı adı kutusuna tekrar
// odaklansın (Focus()) — ck1060'takileri hatırla.
