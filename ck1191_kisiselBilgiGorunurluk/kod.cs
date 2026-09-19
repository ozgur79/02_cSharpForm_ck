// ck1191 — Koşula göre bir bölümü göster/gizle (ek pekiştirme)
// NASIL: Ders12_KosullaGoster formuna kontrolleri ekle (bkz. kurulum.md — grpAskerlik'in
//        Visible'ını baştan false yapmayı unutma), bloğu btnKontrolEt_Click gövdesine
//        yapıştır.
// Ne öğreneceğiz: Visible sadece butonları değil, bir GroupBox'ı (içindeki her şeyle
//                 birlikte) da gösterip gizleyebilir — koşul TUTMAZSA form daha SADE
//                 görünür, bu forma özgü yeni bir kullanım alanı.

// --- KAVRAM ---
int yas = Convert.ToInt32(txtYas.Text);
if (yas > 18 && cmbCinsiyet.SelectedItem.ToString() == "Erkek")
    grpAskerlik.Visible = true;
else
    grpAskerlik.Visible = false;

// --- SEN YAP ---
// Yaş 18 veya altındaysa ayrı bir uyarı ("Reşit değilsiniz") MessageBox ile göster.
