// ck1440 — PictureBox + ImageList: resim değiştir
// NASIL: Alan bloğu sınıfın içine, ikinci blok btnSonraki_Click gövdesine.
// Ne öğreneceğiz: `ImageList`, resimleri bir DİZİ gibi (`Images[0]`, `Images[1]`...)
//                 sakladığın görünmez bir depo. `PictureBox.Image`, o an EKRANDA
//                 gösterilen resmi tutan özellik — Image'a hangi resmi atarsan o görünür.

// --- KAVRAM: sınıfın içine, hiçbir metodun dışına (alan) ---
private int index = 0;

// --- KAVRAM: btnSonraki_Click gövdesinin içine ---
index++;
if (index >= imageList1.Images.Count)
{
    index = 0;
}
picGoster.Image = imageList1.Images[index];

// --- SEN YAP ---
// "Önceki Resim" butonu (`btnOnceki`) ekle — `index`i AZALTSIN, `0`nın altına inerse
// SON resme (`imageList1.Images.Count - 1`) atlasın.
