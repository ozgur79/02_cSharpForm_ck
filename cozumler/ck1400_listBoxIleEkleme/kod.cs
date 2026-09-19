private void btnEkle_Click(object sender, EventArgs e)
{
    if (txtIsim.Text != "")
    {
        lstIsimler.Items.Add(txtIsim.Text);
        txtIsim.Text = "";
        lblSayac.Text = "Toplam: " + lstIsimler.Items.Count;
    }
}
