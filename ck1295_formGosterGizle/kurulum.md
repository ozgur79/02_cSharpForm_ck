# ck1295 — Form göster/gizle: iki form arasında geçiş (ek pekiştirme)

## Senaryo

ck1290'da formların bağımsız yaşadığını gördün. Bu derste bir form KENDİSİNİ gizleyip
yerine başka bir formu açacak — `Show()`'un kardeşi `Hide()` ile tanışıyoruz.

## Hazırlık

1. `Unite07` projeni aç.
2. **Project > Add Windows Form**, adı `Ders08_FormA`.
3. **Project > Add Windows Form**, adı `Ders08_FormB`, üzerine bir Label koy (Text
   "Buradasın: FormB").
4. `Ders08_FormA`'ya iki buton ekle: `btnFormBAc` (Text "FormB'yi Aç"), `btnBeniGizle`
   (Text "Beni Gizle").

## Hangi event

`btnFormBAc_Click` ve `btnBeniGizle_Click` gövdelerine `kod.cs`'teki blokları yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers08`, Text "Ders 08 — Göster/Gizle". `new Ders08_FormA().Show();`

## Çalıştı mı?

- "FormB'yi Aç"a basınca FormB açılmalı, FormA hâlâ görünür kalmalı.
- "Beni Gizle"ye basınca FormA gözden kaybolmalı ama Görev Çubuğu'ndan/Alt+Tab'dan hâlâ
  çalışıyor olduğunu görebilmelisin (kapanmadı, sadece gizlendi).
