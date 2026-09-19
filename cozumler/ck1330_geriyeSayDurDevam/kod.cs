private void timer1_Tick(object sender, EventArgs e)
{
    s = s - 1;
    lblSayac.Text = s.ToString();
    if (s == 0)
    {
        timer1.Stop();
        btnBaslatDurdur.Text = "Bitti";
        calisiyor = false;
    }
}
