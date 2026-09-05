# Müfredat — WinForms hattı (ck0500-ck0999)

Ders listesi ve kara kutu takip tablosu. Her onaylanan derste bu dosya güncellenir.
Üretim planı ve gerekçeler: `winforms-plan.md`.

## Ders listesi

| ders | konu | ünite | zincir (dil) | zincir (arayüz) | kaynak | durum |
|------|------|-------|---------------|-------------------|--------|-------|
| ck0500_formuTani | Form, Toolbox/Properties, Name verme kuralı, ilk olay (Click), menü formu kurulumu | 05 | — (yeni dil kavramı yok) | Console → WinForms geçişi | eski proje 500WFAbutonTextboxGroupbox + ünite projesi modeli | onay bekliyor |

## Kara kutu takip tablosu

Bu hattın kendi kutuları (`object sender, EventArgs e`, `partial`, `InitializeComponent()`,
`this`) burada tutulur.

| yapı | ilk göründüğü ders | açılacağı yer | Merak Köşesi günlüğü | not |
|------|----------------------|-------------------|----------------------|-----|
| `public partial class <FormAdı> : Form` | ck0500 | ünite 07 | — | rotasyon sırası 1 |
| `InitializeComponent();` | ck0500 | ünite 07 | — | rotasyon sırası 2 |
| `object sender, EventArgs e` | ck0500 | ünite 07 (ck0740) | — | rotasyon sırası 3 |
| `new Ders01_FormuTani().Show();` | ck0500 | ünite 07 (ck0710/ck0790) | — | rotasyon sırası 4 — menü formunun satırı, her derste tekrar eder |

**Merak Köşesi günlüğü:** ck0500 → **atlandı (ders yüklü)**. Ünitenin ilk dersi proje açma,
form ekleme, Toolbox/Properties tanıma, Name kuralı, ilk olay ve menü formu kurulumunu bir
arada taşıyor; yük freni kuralı gereği köşe konmadı. Rotasyon kaymadı, sıra ck0510'da
`public partial class ... : Form` ile başlar.

## Devralınan borç — 01'in kara kutuları

`01_cSharpGiris_ck` Console derslerinde öğrenciye "ünite 07'de açacağız" sözü verilen
kutular. Ünite 07 dersleri yazılırken 01'in `mufredat.md`'sindeki kara kutu tablosuna
bakılır (hangi kutuya ne söylenmiş), açılış gerçekleştiğinde o tablo gerçek ck numarasıyla
güncellenir.

| yapı | söz verilen yer | ödendiği ders |
|---|---|---|
| `using ...` (5 satır) | ünite 07 | ck0780 (planlandı) |
| `namespace` | ünite 07 | ck0760 (planlandı) |
| `class Program` | ünite 07 | ck0760 (planlandı) |
| `static void Main(string[] args)` | ünite 07 | ck0760 (planlandı) |
| `Console.ReadKey();` | ileride ayrı bir derste | henüz planlanmadı |
