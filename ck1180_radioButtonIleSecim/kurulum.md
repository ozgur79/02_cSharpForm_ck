# ck1180 — RadioButton ile işlem seçimi

## Senaryo

ck1170'teki ComboBox yerine dört RadioButton (yuvarlak seçenek) ile işlem seçilsin —
aynı anda sadece biri seçili olabilir.

## Hazırlık

1. `Unite06` projeni aç.
2. **Project > Add Windows Form**, adı `Ders10_RadioButtonIleSecim`.
3. Kontroller:

| kontrol | Name | Text |
|---|---|---|
| RadioButton | `rdbToplama` | Toplama |
| RadioButton | `rdbCikarma` | Çıkarma |
| RadioButton | `rdbCarpma` | Çarpma |
| RadioButton | `rdbBolme` | Bölme |
| TextBox | `txtSayi1` |  |
| TextBox | `txtSayi2` |  |
| Label | `lblSonuc` | (boşalt) |

## Hangi event

`rdbToplama`ya çift tıkla (bu `CheckedChanged` olayını açar), `kod.cs`'teki bloğu
yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers10`, Text "Ders 10 — RadioButton ile Seçim".
`new Ders10_RadioButtonIleSecim().Show();`

## Çalıştı mı?

- Sayılara 10 ve 4 yaz, "Toplama"yı işaretle → "14" görünmeli.
