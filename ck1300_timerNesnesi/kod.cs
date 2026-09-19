// ck1300 — Timer nesnesi: Interval, Start(), Stop(), Tick
// NASIL: timer1'e çift tıkla, ilk bloğu Tick gövdesine; btnBaslat ve btnDurdur'a çift
//        tıklayıp açılan gövdelere kalan iki bloğu yapıştır.
// Ne öğreneceğiz: Timer, forma görünmez şekilde eklenen ama Interval'de yazdığın süre
//                 (milisaniye) kadar zaman geçtikçe kendi kendine Tick olayını tetikleyen
//                 bir kontrol. Start() ile çalışmaya, Stop() ile durmaya başlıyor.

// --- KAVRAM: sınıfın içine, hiçbir metodun dışına (alan — ck1250'yi hatırla) ---
private int saniye = 0;

// --- KAVRAM: timer1_Tick gövdesinin içine ---
saniye++;
lblSayac.Text = saniye.ToString();

// --- KAVRAM: btnBaslat_Click gövdesinin içine ---
timer1.Start();

// --- KAVRAM: btnDurdur_Click gövdesinin içine ---
timer1.Stop();

// --- SEN YAP ---
// Yeni bir buton ekle: `btnSifirla`, Text "Sıfırla". Click içine hem `timer1.Stop();`
// hem `saniye = 0;` hem de `lblSayac.Text = "0";` yaz — sayaç tamamen baştan başlasın.
