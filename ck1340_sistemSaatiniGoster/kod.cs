// ck1340 — Sistem saatini göster
// NASIL: timer1_Tick gövdesine bloğu yapıştır.
// Ne öğreneceğiz: `DateTime.Now` — bilgisayarın o anki tarih/saatini veren hazır bir
//                 kaynak (Random'a benziyor: sen üretmiyorsun, hazır bir yerden alıyorsun).
//                 `.ToLongTimeString()` bunu "14:23:07" gibi okunabilir bir metne çeviriyor.

// --- KAVRAM: timer1_Tick gövdesinin içine ---
lblSaat.Text = DateTime.Now.ToLongTimeString();

// --- SEN YAP ---
// `ToLongTimeString()` yerine `ToShortTimeString()` dene, farkı gözlemle. Sonra
// `ToLongDateString()` ile TARİHİ ayrı bir Label'da (`lblTarih`) göster.
