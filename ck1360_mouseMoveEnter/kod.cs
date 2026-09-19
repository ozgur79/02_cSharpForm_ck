// ck1360 — MouseMove / MouseLeave: fare üstüne gelince
// NASIL: Butonun Events sekmesinden MouseMove ve MouseLeave'e çift tıkla, açılan
//        gövdelere ilgili blokları yapıştır.
// Ne öğreneceğiz: Click olayı SADECE tıklayınca çalışıyordu. MouseMove, fare kontrolün
//                 ÜZERİNDEYKEN sürekli; MouseLeave, fare üzerinden AYRILDIĞI AN bir kez
//                 tetikleniyor. Tıklamaya hiç gerek yok.

// --- KAVRAM: btnUzerindenGec_MouseMove gövdesinin içine ---
lblDurum.Text = "Butonun üzerine geldiniz";

// --- KAVRAM: btnUzerindenGec_MouseLeave gövdesinin içine ---
lblDurum.Text = "Çekildiniz...";

// --- SEN YAP ---
// İkinci bir buton ekle (`btnDiger`), ona da MouseMove bağla, üzerine gelince
// `lblDurum.Text = "Diğer butonun üzerine geldiniz";` yaz — iki farklı butonun
// MouseMove'u aynı Label'ı farklı mesajlarla güncelleyebiliyor mu, gör.
