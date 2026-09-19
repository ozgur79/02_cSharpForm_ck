// Ders01_KendiButonunuUret_Load gövdesine eklenir:
Button btnKendim2 = new Button();
btnKendim2.Text = "Bir Tane Daha";
btnKendim2.Top = 50;
btnKendim2.Click += btnKendim2_Click;
this.Controls.Add(btnKendim2);

// sınıfın içine, dışarı:
private void btnKendim2_Click(object sender, EventArgs e)
{
    MessageBox.Show("İkinci buton da kodla üretildi!");
}
