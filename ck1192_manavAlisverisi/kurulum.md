# ck1192 — Manav alışverişi (ek pekiştirme)

## Senaryo

Bir meyve seç, kilogramını seç, sepete at. Alışverişi bitirince toplam tutarı gör.

## Hazırlık

1. `Unite06` projeni aç.
2. **Project > Add Windows Form**, adı `Ders13_ManavAlisverisi`.
3. Kontroller:

| kontrol | Name | Text | not |
|---|---|---|---|
| ComboBox | `cmbUrun` |  | `Items`: "elma","armut","kiraz" |
| ComboBox | `cmbKilo` |  | `Items`: "1","2","3","4","5" |
| Button | `btnSepeteAt` | Sepete At | `Click` → `btnSepeteAt_Click` |
| ListBox | `lstSepet` |  |  |
| Button | `btnBitir` | Alışverişi Bitir | `Click` → `btnBitir_Click` |
| Label | `lblTutar` | (boşalt) |  |

## Hangi event

Her butona sırayla çift tıkla, `kod.cs`'teki ilgili bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers13`, Text "Ders 13 — Manav Alışverişi".
`new Ders13_ManavAlisverisi().Show();`

## Çalıştı mı?

- "elma", "2" seç, Sepete At'a bas → listede "elma 2 kg" görünmeli.
- Birkaç ürün ekle, Alışverişi Bitir'e bas → toplam tutar görünmeli.
