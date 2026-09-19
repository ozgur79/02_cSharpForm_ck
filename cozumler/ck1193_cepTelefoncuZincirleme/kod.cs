// cmbMarka_SelectedIndexChanged içine eklenir:
else if (cmbMarka.SelectedItem.ToString() == "Siemens")
{
    cmbModel.Items.Add("C77");
}

// cmbModel_SelectedIndexChanged içine eklenir:
else if (cmbModel.SelectedItem.ToString() == "C77")
    lblFiyat.Text = "150 TL";
