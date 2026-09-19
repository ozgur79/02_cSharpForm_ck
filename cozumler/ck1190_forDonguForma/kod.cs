string kelime = txtKelime.Text;
int adet = Convert.ToInt32(txtAdet.Text);
lblSonuc.Text = "";
for (int i = 1; i <= adet; i++)
{
    lblSonuc.Text = lblSonuc.Text + i + ". kelime: " + kelime + "\n";
}
