# ck1194 — Ödeme hesaplayıcı: switch ile taksit (ünite 06'nın ek pekiştirme kapanışı)

## Senaryo

Bir ürün seç (birim fiyatı otomatik gelsin), adet gir, peşin mi taksitli mi seç —
taksitliyse taksit sayısına göre komisyonlu tutarı hesapla.

## Hazırlık

1. `Unite06` projeni aç.
2. **Project > Add Windows Form**, adı `Ders15_OdemeHesaplayici`.
3. Kontroller:

| kontrol | Name | Text | not |
|---|---|---|---|
| ComboBox | `cmbUrun` |  | `Items`: "CPU","HDD","RAM"; `SelectedIndexChanged` → `cmbUrun_SelectedIndexChanged` |
| TextBox | `txtBirimFiyat` |  | `ReadOnly` = `true` |
| TextBox | `txtAdet` |  |  |
| ComboBox | `cmbTaksit` |  | `Items`: "Peşin","3 Taksit","6 Taksit"; `SelectedIndexChanged` → `cmbTaksit_SelectedIndexChanged` |
| Label | `lblSonTutar` | (boşalt) |  |

## Hangi event

Her ComboBox'a sırayla çift tıkla, `kod.cs`'teki ilgili bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers15`, Text "Ders 15 — Ödeme Hesaplayıcı".
`new Ders15_OdemeHesaplayici().Show();`

## Çalıştı mı?

- "CPU" seç → birim fiyat 50 gelmeli. Adet 2 gir, "3 Taksit" seç → komisyonlu tutar
  görünmeli (100 TL'nin %3 fazlası).
