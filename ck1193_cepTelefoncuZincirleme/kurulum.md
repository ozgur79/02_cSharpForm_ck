# ck1193 — Birbirine bağlı iki ComboBox (ek pekiştirme)

## Senaryo

Önce marka seç. Seçtiğin markaya göre ikinci listede SADECE o markanın modelleri
çıksın.

## Hazırlık

1. `Unite06` projeni aç.
2. **Project > Add Windows Form**, adı `Ders14_ZincirlemeComboBox`.
3. Kontroller:

| kontrol | Name | Text | not |
|---|---|---|---|
| ComboBox | `cmbMarka` |  | `Items`: "Nokia","Motorola"; `SelectedIndexChanged` → `cmbMarka_SelectedIndexChanged` |
| ComboBox | `cmbModel` |  |  |
| Label | `lblFiyat` | (boşalt) |  |

## Hangi event

`cmbMarka`ya çift tıkla, `kod.cs`'teki ilk bloğu yapıştır. Sonra forma dön, `cmbModel`e
çift tıkla, ikinci bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers14`, Text "Ders 14 — Zincirleme ComboBox".
`new Ders14_ZincirlemeComboBox().Show();`

## Çalıştı mı?

- "Nokia" seç → ikinci listede N70/N95 çıkmalı. "Motorola" seç → liste RAZR55'e değişmeli
  (Nokia modelleri kalmamalı).
- Bir model seç → fiyatı görünmeli.
