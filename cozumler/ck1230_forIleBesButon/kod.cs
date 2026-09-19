for (int i = 1; i <= 8; i++)
{
    Button btnYeni = new Button();
    btnYeni.Text = "Buton " + i;
    if (i % 2 == 0)
        btnYeni.Location = new Point(10, i * 35);
    else
        btnYeni.Location = new Point(150, i * 35);
    this.Controls.Add(btnYeni);
}
