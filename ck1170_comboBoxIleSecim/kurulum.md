# ck1170 — ComboBox ile işlem seçimi

## Senaryo

ck1160'taki dört buton yerine TEK bir açılır liste (ComboBox) ile işlem seçilsin.

## Hazırlık

1. `Unite06` projeni aç.
2. **Project > Add Windows Form**, adı `Ders09_ComboBoxIleSecim`.
3. Kontroller:

| kontrol | Name | Text | not |
|---|---|---|---|
| ComboBox | `cmbIslem` |  | `Items` listesine "Toplama","Çıkarma","Çarpma","Bölme" ekle |
| TextBox | `txtSayi1` |  |  |
| TextBox | `txtSayi2` |  |  |
| Label | `lblSonuc` | (boşalt) |  |

> `Items` eklemek için Properties'te `Items` yanındaki `...` düğmesine bas, her satıra
> bir seçenek yaz.

## Hangi event

`cmbIslem`e çift tıkla (bu `SelectedIndexChanged` olayını açar), `kod.cs`'teki bloğu
yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers09`, Text "Ders 09 — ComboBox ile Seçim".
`new Ders09_ComboBoxIleSecim().Show();`

## Çalıştı mı?

- Sayılara 10 ve 4 yaz, listeden "Toplama" seç → "14" görünmeli. "Bölme" seç → "2,5".
