private void btnHedef_Click(object sender, EventArgs e)
{
    puan++;
    lblPuan.Text = "Puan: " + puan;
    if (puan == 10)
    {
        MessageBox.Show("Kazandın!");
    }
}
