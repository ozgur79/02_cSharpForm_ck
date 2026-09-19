// Ogrenci.cs içinde:
class Ogrenci
{
    public string ad;
    public int numara;
    public int not;

    public string Tanit()
    {
        return numara + " numaralı " + ad + " - Not: " + not;
    }
}

// btnTanit_Click içinde (ekleme):
Ogrenci ogr3 = new Ogrenci();
ogr3.ad = "Zeynep";
ogr3.numara = 103;
ogr3.not = 85;
lstSonuc.Items.Add(ogr3.Tanit());
