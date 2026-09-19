private void btnHizlandir_Click(object sender, EventArgs e)
{
    if (zaman > 50)
    {
        zaman = zaman - 50;
        timer1.Interval = zaman;
    }
}
