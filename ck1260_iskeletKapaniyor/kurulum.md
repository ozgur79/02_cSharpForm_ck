# ck1260 — İskelet kapanıyor: namespace, class Program, static Main, partial, InitializeComponent

## Senaryo

Bu ders de ck1200 gibi bir şey İNŞA ETMİYOR — Solution Explorer'daki `Program.cs` ve
`Form1.cs` dosyalarını okuyacaksın. Ünite başından beri (hatta Console'dan beri) gördüğün
ama açıklanmamış BEŞ kutu burada kapanıyor.

## Hazırlık

1. `Unite05` projeni aç (ilk WinForms projen — bu dosya her projede aynı, hangi ünitede
   açsan fark etmez).
2. Solution Explorer'da `Program.cs`'e çift tıkla, sonra `Form1.cs`'i aç.

## Hangi event

Yok — bu ders sadece okuma. Hiçbir yere kod yapıştırmıyorsun.

## Menü formuna ekle

Yok — yeni form eklenmedi.

## Çalıştı mı?

- `Program.cs` içinde `static void Main()` satırını bul.
- İçindeki `Application.Run(new Form1());` satırını bul — `new` burada da var, formun
  kendisi de bir nesneymiş.
- `Form1.cs`'te `public partial class Form1 : Form` satırını bul; ck1200'de
  `Designer.cs`'te gördüğün `partial class Form1` ile AYNI sınıfın iki parçası olduğunu
  fark et.
