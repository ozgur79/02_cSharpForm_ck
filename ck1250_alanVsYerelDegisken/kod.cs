// ck1250 — Kapsam dersi: alan mı, yerel değişken mi?
// NASIL: Ders05_AlanVsYerel formunda btnSay butonuna çift tıkla, ilk satırı (sayac)
//        metodun DIŞINA sınıfın içine, geri kalanını Click gövdesine yapıştır.
// Ne öğreneceğiz: ck1040'ta bir `bool` değişkeni metotların DIŞINDA tanımlayıp "durumu
//                 hatırlıyor" demiştik — burada NEDEN hatırladığını göreceğiz. Sınıfın
//                 içinde, metotların dışında duran değişkene "alan" (field) denir; metodun
//                 İÇİNDE tanımlanana "yerel değişken" denir. Alan kalıcıdır, yerel değişken
//                 her çağrıda sıfırdan doğar ve metot bitince yok olur.

// --- KAVRAM: sınıfın içine, hiçbir metodun dışına (alan) ---
private int sayac = 0;

// --- KAVRAM: btnSay_Click gövdesinin içine ---
sayac++;
lblSonuc.Text = "Tıklama sayısı: " + sayac;

// --- SEN YAP ---
// 1. Yukarıdaki `private int sayac = 0;` satırını sil, YERİNE btnSay_Click'in İÇİNE
//    (en başına) `int sayac = 0;` yaz.
// 2. Çalıştır, butona 3 kez bas. Sayı hep "1" mi kalıyor? Neden olduğunu düşün.
// 3. Denemeyi bitirince satırı GERİ eski yerine (alan olarak) koy — ders bu haliyle biter.
