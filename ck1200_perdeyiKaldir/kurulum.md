# ck1200 — Perdeyi kaldır: bu satırları VS senin yerine yazıyormuş

## Senaryo

Bu ders bir şey İNŞA ETMİYOR — daha önce Toolbox'tan sürüklediğin bir kontrolün
ARKASINDA gerçekte ne olduğunu görüyorsun. Yeni form/kontrol eklemeyeceksin.

## Hazırlık

1. `Unite05` projeni aç (ilk ünitendeki proje).
2. Solution Explorer'da `Ders01_FormuTani.cs`'in yanındaki oku (`>`) tıkla, altında
   çıkan `Ders01_FormuTani.Designer.cs`'e çift tıkla.
3. İçini oku — `InitializeComponent()` metodunun içinde `this.btnSelamla = new
   System.Windows.Forms.Button();` gibi satırlar göreceksin.

## Hangi event

Yok — bu ders sadece okuma. Hiçbir yere kod yapıştırmıyorsun.

## Menü formuna ekle

Yok — yeni form eklenmedi.

## Çalıştı mı?

- `Designer.cs` dosyasında `btnSelamla = new System.Windows.Forms.Button();` satırını
  gerçekten bulup gösterebiliyor musun?
- `this.Controls.Add(this.btnSelamla);` satırını da bul — bu satır butonu forma
  EKLEYEN satır.
