private void btnKuraCek_Click(object sender, EventArgs e)
{
    if (lstBekleyenler.Items.Count == 0)
    {
        MessageBox.Show("Bekleyen kimse kalmadı.");
    }
    else
    {
        int index = rnd.Next(0, lstBekleyenler.Items.Count);
        string cekilenIsim = lstBekleyenler.Items[index].ToString();
        lstSecilenler.Items.Add(cekilenIsim);
        lstBekleyenler.Items.RemoveAt(index);
        MessageBox.Show(cekilenIsim + " seçildi!");
    }
}
