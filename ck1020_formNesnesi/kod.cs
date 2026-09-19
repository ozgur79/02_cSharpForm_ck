// ck1020 — Formun kendisi de bir nesne
// NASIL: Ders03_FormNesnesi formuna kontrolleri ekle (bkz. kurulum.md), her bloğu
//        ilgili butonun gövdesine yapıştır.
// Ne öğreneceğiz: ck1010'da formun rengini değiştirmiştik. Form'un Left (sol kenarın
//                 ekrandaki konumu), Top (üst kenarın konumu), Opacity (saydamlık,
//                 0.0-1.0 arası) ve Text (başlık çubuğu yazısı) gibi başka özellikleri
//                 de var — hepsi aynı `this.` ile erişiliyor.

// --- KAVRAM ---

// >>> btnSola_Click gövdesinin içine:
this.Left -= 10;

// >>> btnYukari_Click gövdesinin içine:
this.Top -= 10;

// >>> btnSeffaflastir_Click gövdesinin içine:
if (this.Opacity > 0.1)
    this.Opacity -= 0.1;
// Opacity 0.0-1.0 arasında olmalı; if kontrolü olmadan 0'ın altına inip hataya yol açabilir.

// >>> btnOpaklastir_Click gövdesinin içine:
if (this.Opacity < 1.0)
    this.Opacity += 0.1;

// >>> btnBaslikDegistir_Click gövdesinin içine:
this.Text = txtBaslik.Text;
// Form1'in "Text" özelliği pencerenin başlık çubuğudur (bir butonun Text'i gibi değil).

// --- SEN YAP ---
// Beşinci bir buton ekle: Name btnOrtala, Text "Ortala". Basınca formu ekranın
// ortasına götürsün — ipucu: this.CenterToScreen(); adında hazır bir METOT var,
// deneyebilirsin.

// --- MERAK KÖŞESİ ---
// InitializeComponent(); ne yapıyor?
// Designer'da sürüklediğin her kontrolü, verdiğin her Name/Text değerini kodun
// haline getirip burada tek seferde çalıştırıyor — formun İLK açıldığı an. Tam
// içeriğini ünite 07'de (Form1.Designer.cs'i açınca) göreceğiz.
