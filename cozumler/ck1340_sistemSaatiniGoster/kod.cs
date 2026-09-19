private void timer1_Tick(object sender, EventArgs e)
{
    lblSaat.Text = DateTime.Now.ToShortTimeString();
    lblTarih.Text = DateTime.Now.ToLongDateString();
}
