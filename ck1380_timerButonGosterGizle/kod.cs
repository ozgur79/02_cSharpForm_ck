// ck1380 — Timer + buton: göster/gizle döngüsü
// NASIL: Alan bloğu sınıfın içine, ikinci blok timer1_Tick gövdesine, üçüncü blok
//        btnHedef_Click gövdesine.
// Ne öğreneceğiz: `Visible` özelliğini bir Timer'la birleştirmek — buton yok EDİLMİYOR,
//                 sadece görünürlüğü açılıp kapanıyor (ck1050'deki Visible pekiştirmesi).

// --- KAVRAM: sınıfın içine, hiçbir metodun dışına (alan) ---
private int puan = 0;

// --- KAVRAM: timer1_Tick gövdesinin içine ---
btnHedef.Visible = !btnHedef.Visible;

// --- KAVRAM: btnHedef_Click gövdesinin içine ---
puan++;
lblPuan.Text = "Puan: " + puan;

// --- SEN YAP ---
// `timer1`in `Interval`ini `400` yap — oyun zorlaştı mı, kolaylaştı mı? Sonra `lblPuan`a
// puan 10'a ulaşınca `MessageBox.Show("Kazandın!");` gösterecek bir kontrol ekle
// (ipucu: `btnHedef_Click` içinde `if (puan == 10)`).
