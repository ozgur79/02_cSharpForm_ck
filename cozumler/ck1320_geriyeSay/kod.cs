private void btnBaslat_Click(object sender, EventArgs e)
{
    timer1.Stop();
    s = Convert.ToInt32(txtSayi.Text);
    lblSonuc.Text = "";
    timer1.Start();
}
