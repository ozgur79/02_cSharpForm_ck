# ck1220 — Ürettiğin butonu konumlandır, yazısını ver

## Senaryo

ck1210'daki kod-butonu artık istediğin yere koyabiliyorsun — Toolbox'ta fareyle
sürüklediğinde yaptığın şeyi, kod ile tam olarak yapıyorsun.

## Hazırlık

1. `Unite07` projeni aç.
2. **Project > Add Windows Form**, adı `Ders02_Konumlandir`. Yine Toolbox'a dokunma.
3. Forma çift tıkla (`Load` olayı açılır).

## Hangi event

`Ders02_Konumlandir_Load` gövdesine `kod.cs`'teki bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers02`, Text "Ders 02 — Konumlandır". `new Ders02_Konumlandir().Show();`

## Çalıştı mı?

- Formu çalıştır → üç buton, formun farklı köşelerinde, üzerlerinde yazılı metinlerle
  görünmeli.
