// ck1370 — Kaçan buton oyunu
// NASIL: Her blok, aynı numaralı butonun MouseMove gövdesine.
// Ne öğreneceğiz: ck1360'taki tek buton MouseMove'unu 6 butona birden uygulamak — her
//                 buton kendi MouseMove'una sahip, birbirinden bağımsız çalışıyor.

// --- KAVRAM: btn1_MouseMove gövdesinin içine ---
MessageBox.Show("Yandınız!");

// --- KAVRAM: btn2_MouseMove gövdesinin içine ---
MessageBox.Show("Yandınız!");

// --- KAVRAM: btn3_MouseMove gövdesinin içine ---
MessageBox.Show("Yandınız!");

// --- KAVRAM: btn4_MouseMove gövdesinin içine ---
MessageBox.Show("Yandınız!");

// --- KAVRAM: btn5_MouseMove gövdesinin içine ---
MessageBox.Show("Yandınız!");

// --- KAVRAM: btn6_MouseMove gövdesinin içine ---
MessageBox.Show("Tebrikler:)");

// --- SEN YAP ---
// ck1240'ı hatırla: 5 farklı butonun AYNI Click'e bağlanabildiğini görmüştün. btn1_MouseMove
// dışındaki 4 metodun GÖVDESİNİ boşalt, içine sadece `btn1_MouseMove(sender, e);` yaz —
// yani btn2-btn5'in MouseMove'u, btn1'inkini ÇAĞIRSIN. Beş ayrı "Yandınız!" satırı yerine
// tek bir yerde duruyor artık.

