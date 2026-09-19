// Deneme (geçici, gösterim amaçlı — ders alan haliyle biter):
private void btnSay_Click(object sender, EventArgs e)
{
    int sayac = 0;
    sayac++;
    lblSonuc.Text = "Tıklama sayısı: " + sayac;
}
// Yukarıdaki haliyle sayac her tıklamada 0'dan başlar, hep "1" görünür.
// Doğru (kalıcı) hali: sayac alan olarak sınıfın içinde, Click içinde sadece sayac++;
