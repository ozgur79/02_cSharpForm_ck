// ck1060 — Odaklanma: Focus() ve Clear()
// NASIL: Ders07_Odaklanma formuna kontrolleri ekle (bkz. kurulum.md), her bloğu
//        ilgili butona yapıştır.
// Ne öğreneceğiz: Focus() imleci bir kontrole taşıyan, Clear() içeriğini boşaltan
//                 iki hazır metot — ikisi de () ile biter, ikisi de METOT.

// --- KAVRAM: btnYazdir_Click gövdesinin içine ---
txtAd.Text = "Yazılım Uzmanı";

// --- KAVRAM: btnOdaklan_Click gövdesinin içine ---
txtAd.Focus();

// --- KAVRAM: btnTemizle_Click gövdesinin içine ---
txtAd.Clear();
// txtAd.Text = ""; ile aynı sonucu verir — Clear() hazır bir kısayoldur.

// --- SEN YAP ---
// Dördüncü bir buton ekle: Name btnParcaSec, Text "İlk 5 Harfi Seç". Basınca txtAd'a
// odaklanıp ilk 5 harfini seçili hale getirsin (ipucu: txtAd.Focus(); satırından sonra
// txtAd.Select(0, 5); dene — Select(başlangıç, uzunluk) alır).
