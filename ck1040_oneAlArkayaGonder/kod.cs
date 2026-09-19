// ck1040 — Öne al / arkaya gönder
// NASIL: Ders05_OneArkaya formuna kontrolleri ekle (bkz. kurulum.md), bloğu
//        btnDegistir_Click gövdesine yapıştır.
// Ne öğreneceğiz: SendToBack/BringToFront iki kontrolün üst üste sırasını değiştiren
//                 hazır metotlar. "Hangi durumdayız" bilgisini (üstte mi altta mı)
//                 sınıf seviyesinde bir bool ile hatırlıyoruz — kapsam konusuna
//                 (ck1250'de tam açılacak) ilk bakış.

// --- KAVRAM: sınıf alanı (Ders05_OneArkaya sınıfının İÇİNE, herhangi bir metodun DIŞINA) ---
bool ustteBtnUst = true;

// --- KAVRAM: btnDegistir_Click gövdesinin içine ---
if (ustteBtnUst)
{
    btnUst.SendToBack();
    ustteBtnUst = false;
}
else
{
    btnUst.BringToFront();
    ustteBtnUst = true;
}

// --- SEN YAP ---
// Üçüncü bir buton ekle: Name btnHepsiOne, Text "Üstteki Hep Önde Kalsın". Basınca
// ustteBtnUst değerine bakmadan btnUst'u kesin olarak öne getirsin (BringToFront) ve
// ustteBtnUst'u true yapsın — "durumu elle sıfırlama" fikrini dener.
