# ck1020 — Formun kendisi de bir nesne

## Senaryo

Dört buton: formu sola kaydır, yukarı kaydır, saydamlaştır, opaklaştır. Beşinci bir kontrol
ile formun başlığını değiştir.

## Hazırlık

1. `Unite05` projeni aç.
2. **Project > Add Windows Form**, adı `Ders03_FormNesnesi`.
3. Kontroller:

| kontrol | Name | Text |
|---|---|---|
| Button | `btnSola` | Sola |
| Button | `btnYukari` | Yukarı |
| Button | `btnSeffaflastir` | Saydamlaştır |
| Button | `btnOpaklastir` | Opaklaştır |
| TextBox | `txtBaslik` |  |
| Button | `btnBaslikDegistir` | Başlığı Değiştir |

## Hangi event

Her butona sırayla çift tıkla, `kod.cs`'teki ilgili bloğu gövdesine yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers03`, Text "Ders 03 — Form Nesnesi". `new Ders03_FormNesnesi().Show();`

## Çalıştı mı?

- Sola/Yukarı butonlarına bas → form her basışta biraz kayar.
- Saydamlaştır'a birkaç kez bas → form giderek saydamlaşır (ama tamamen kaybolmaz).
- Opaklaştır'a bas → form eski hâline döner.
- Kutuya bir şey yaz, Başlığı Değiştir'e bas → pencerenin başlık çubuğu değişir.
