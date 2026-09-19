// ck1220 — Ürettiğin butonu konumlandır, yazısını ver
// NASIL: Ders02_Konumlandir formunun kendisine çift tıkla, bloğu Load gövdesine
//        yapıştır.
// Ne öğreneceğiz: Location (X,Y konumu) ve Text — nesnenin ÖZELLİKLERİ, "sıfatları".
//                 Yeni nesne = new ile üret, sonra ona sıfatlarını (özelliklerini) ver.

// --- KAVRAM ---
Button btnSolUst = new Button();
btnSolUst.Text = "Sol Üst";
btnSolUst.Location = new Point(10, 10);
this.Controls.Add(btnSolUst);

Button btnSagUst = new Button();
btnSagUst.Text = "Sağ Üst";
btnSagUst.Location = new Point(200, 10);
this.Controls.Add(btnSagUst);

Button btnAlt = new Button();
btnAlt.Text = "Alt Orta";
btnAlt.Location = new Point(100, 100);
this.Controls.Add(btnAlt);

// --- SEN YAP ---
// Dördüncü bir buton üret, Location'ını (100, 200) yap, Text'ini "Daha Alt" yap.
// this.Controls.Add(...) çağırmayı UNUTURSAN ne olur, dene ve gözlemle.
