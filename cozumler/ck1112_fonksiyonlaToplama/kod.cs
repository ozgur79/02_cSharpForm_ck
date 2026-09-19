// >>> btnCarp_Click gövdesinin içine:
int sayi1 = Convert.ToInt32(txtSayi1.Text);
int sayi2 = Convert.ToInt32(txtSayi2.Text);
MessageBox.Show(Carp(sayi1, sayi2).ToString());

// >>> sınıfın içine, dışarı:
private int Carp(int a, int b)
{
    return a * b;
}
