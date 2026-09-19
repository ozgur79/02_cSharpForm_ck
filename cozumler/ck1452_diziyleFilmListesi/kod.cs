private void btnGoster_Click(object sender, EventArgs e)
{
    foreach (string film in filmler)
    {
        if (film != null)
        {
            MessageBox.Show(film);
        }
    }
}
