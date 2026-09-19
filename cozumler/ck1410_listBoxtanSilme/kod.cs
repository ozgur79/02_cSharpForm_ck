private void btnSil_Click(object sender, EventArgs e)
{
    if (lstIsimler.SelectedIndex != -1)
    {
        lstIsimler.Items.RemoveAt(lstIsimler.SelectedIndex);
    }
    else
    {
        MessageBox.Show("Önce listeden bir isim seç.");
    }
}
