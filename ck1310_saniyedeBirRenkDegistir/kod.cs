// ck1310 — Saniyede bir renk değiştir
// NASIL: timer1_Tick gövdesine ikinci bloğu yapıştır, ilk blok (beyaz alanı) sınıfın
//        içine, metodun dışına gider.
// Ne öğreneceğiz: Timer'ın `Enabled` özelliği `true` yapılırsa, form AÇILIR AÇILMAZ,
//                 hiçbir buton beklemeden Tick tetiklenmeye başlar. ck1300'de Start()'ı
//                 bir buton çağırıyordu — burada Enabled bu işi baştan hallediyor.

// --- KAVRAM: sınıfın içine, hiçbir metodun dışına (alan) ---
private bool beyaz = true;

// --- KAVRAM: timer1_Tick gövdesinin içine ---
if (beyaz)
{
    this.BackColor = Color.Black;
    beyaz = false;
}
else
{
    this.BackColor = Color.White;
    beyaz = true;
}

// --- SEN YAP ---
// `Interval`i Properties'ten `200` yap, tekrar çalıştır — yanıp sönme hızı nasıl değişti?
// Sonra `500`e geri koy.
