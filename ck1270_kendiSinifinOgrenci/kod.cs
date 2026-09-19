// ck1270 — Kendi sınıfın: class Ogrenci
// NASIL: Ogrenci.cs dosyasının İÇİNE ilk bloğu, Ders06_KendiSinifin formunun btnTanit
//        butonuna çift tıklayıp açılan Click gövdesine ikinci bloğu yapıştır.
// Ne öğreneceğiz: Button, Form, Label — hepsi BAŞKASININ (Microsoft'un) yazdığı sınıflardı.
//                 Şimdi kendi sınıfını YAZIYORSUN: Ogrenci. `new Ogrenci()` dediğinde,
//                 tıpkı `new Button()` gibi, BAMBAŞKA bir nesne doğacak.

// --- KAVRAM: Ogrenci.cs dosyasının içine (class Ogrenci) ---
class Ogrenci
{
    public string ad;
    public int numara;

    public string Tanit()
    {
        return numara + " numaralı " + ad;
    }
}

// --- KAVRAM: btnTanit_Click gövdesinin içine ---
Ogrenci ogr1 = new Ogrenci();
ogr1.ad = "Ayşe";
ogr1.numara = 101;

Ogrenci ogr2 = new Ogrenci();
ogr2.ad = "Mehmet";
ogr2.numara = 102;

lstSonuc.Items.Add(ogr1.Tanit());
lstSonuc.Items.Add(ogr2.Tanit());

// --- SEN YAP ---
// Ogrenci sınıfına üçüncü bir alan ekle: `public int not;`. Tanit() metodunun döndürdüğü
// metne notu da ekle (örn. " - Not: 85" — not, Tanit()'in kendi sınıfındaki bir alan
// olduğu için parametre GEREKMEZ, doğrudan kullanabilirsin). Sonra btnTanit_Click içinde
// üçüncü bir öğrenci (ogr3) üretip not'unu ata ve listeye ekle.
