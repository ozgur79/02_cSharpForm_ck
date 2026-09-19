// ck1260 — İskelet kapanıyor: namespace, class Program, static Main, partial, InitializeComponent
// NASIL: Bu ders koda dokunmuyor, SADECE okuyor. Program.cs'i, sonra Form1.cs'i aç
//        (bkz. kurulum.md).
// Ne öğreneceğiz: ck0000'dan beri Console'da, ck1000'den beri WinForms'ta gördüğün ama
//                 "ünite 07'de açacağız" dediğimiz kutuların HEPSİ bugün kapanıyor:
//                 namespace, class Program, static Main (Console'dan devralınan borç) +
//                 partial, InitializeComponent (bu hattın kendi kutuları).

// --- KAVRAM: Program.cs içinde göreceğin (KOPYALAMANA GEREK YOK) ---
namespace Unite05
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
// namespace Unite05 — projendeki TÜM sınıfları (Program, Form1, Ders01_FormuTani...) bir
// çatı altında toplayan isim kutusu. Başka bir projede de "Form1" adlı bir sınıf olabilir,
// namespace farklı olduğu için ikisi birbirine karışmaz — dosya/klasör gibi düşün.
//
// class Program — Console derslerindeki "class Program" ile AYNI kutu. Her çalışan
// C# programının bir tane "buradan başla" sınıfı olması gerekir, VS'in verdiği isim hep
// Program'dır.
//
// static void Main() — programın gerçekten BAŞLADIĞI ilk satır. "static" burada şu anlama
// gelir: bu metodu çalıştırmak için Program'dan `new Program()` ile bir nesne üretmene
// gerek YOK — Console'daki `Main` de hep static'ti, hatırla. `Application.Run(new
// Form1());` satırı ise tanıdık: Form1'i `new` ile üretip ekrana koyan satır bu.

// --- KAVRAM: Form1.cs'in en üstünde göreceğin (KOPYALAMANA GEREK YOK) ---
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
}
// partial — ck1200'de Designer.cs'i açtığında da "partial class Form1" yazdığını
// görmüştün. `partial`, AYNI sınıfın (Form1) kodunu İKİ dosyaya bölmene izin veriyor:
// Designer.cs (VS'in ürettiği, sürükle-bırak satırları) ve Form1.cs (senin yazdığın
// olaylar). Derleme sırasında ikisi TEK bir sınıfmış gibi birleşiyor.
// : Form — Form1, Microsoft'un `Form` sınıfının ÖZELLİKLERİNİ (BackColor, Text, Left,
// Top, Show, Hide...) devralıyor demek. ck1020'de gördüğün `this.Left`/`this.Opacity`
// satırlarının çalışmasının sebebi bu.
// InitializeComponent(); — Form1() içinde, form ekrana gelmeden HEMEN önce çağrılıyor;
// Designer.cs'teki `this.Controls.Add(...)` satırlarının hepsini o an çalıştırıyor.
//
// Peki `Console.ReadKey();` nerede? Console'da o satır olmasa pencere anında kapanıyordu.
// WinForms'ta o işi `Application.Run(new Form1());` görüyor — form açık kaldığı SÜRECE
// program da açık kalıyor, kapanması için ayrı bir "bekle" satırına gerek yok.

// --- SEN YAP ---
// Program.cs'te `Application.Run(new Form1());` satırındaki `Form1` ismi, senin
// projendeki menü formunun GERÇEK adıyla aynı mı? (Bazı projelerde Form1 yerine başka
// bir isim olabilir.) Kontrol et, farklıysa neden farklı olduğunu düşün.

// --- MERAK KÖŞESİ ---
// static class Program — sınıfın kendisi de "static" işaretli, yani bu sınıftan HİÇBİR
// zaman `new Program()` ile nesne üretilmeyecek demek. ck1270'te KENDİ sınıfını
// yazacaksın (class Ogrenci) — orada `static` OLMAYAN bir sınıftan nesne üreteceksin,
// farkı orada elle göreceksin.
