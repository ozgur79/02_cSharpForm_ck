// ck1200 — Perdeyi kaldır (ünite 07'nin ilk dersi)
// NASIL: Bu ders koda dokunmuyor, SADECE okuyor. Ders01_FormuTani.Designer.cs'i aç
//        (bkz. kurulum.md).
// Ne öğreneceğiz: Toolbox'tan sürüklediğin HER kontrol, aslında VS'in senin yerine
//                 yazdığı bir satırdan ibaret. "Sürükle-bırak" bir kısayolmuş.

// --- KAVRAM: Ders01_FormuTani.Designer.cs içinde göreceğin (KOPYALAMANA GEREK YOK) ---
private System.Windows.Forms.Button btnSelamla;
private System.Windows.Forms.Label lblMesaj;

private void InitializeComponent()
{
    this.btnSelamla = new System.Windows.Forms.Button();
    this.lblMesaj = new System.Windows.Forms.Label();
    // ... boyut/konum satırları ...
    this.Controls.Add(this.btnSelamla);
    this.Controls.Add(this.lblMesaj);
}
// `new System.Windows.Forms.Button();` — 15 derstir gördüğün "new" burada da var!
// Sen fareyle sürüklediğinde, VS arka planda TAM OLARAK bunu yazıyordu.
// Controls.Add(...) ise "bu nesneyi forma YERLEŞTİR" demek.

// --- SEN YAP ---
// Ders01_FormuTani.Designer.cs'te lblMesaj için de aynı iki satırı (new + Controls.Add)
// bul, kod.cs'e (ya da bir kağıda) elle kopyala.

// --- MERAK KÖŞESİ ---
// class Program, static void Main, namespace hâlâ açıklanmadı — sıradaki derslerde
// (ck1260) bunlara döneceğiz. Bugünün konusu sadece: kontroller de birer nesne, "new"
// ile üretiliyorlar.
