# ck1190 — for döngüsünü forma taşı (ünite 06 kapanışı)

## Senaryo

Bir kelime gir, butona basınca 10 kez alt alta (numaralı) yazılsın.

## Hazırlık

1. `Unite06` projeni aç.
2. **Project > Add Windows Form**, adı `Ders11_ForDonguForma`.
3. Kontroller:

| kontrol | Name | Text | not |
|---|---|---|---|
| TextBox | `txtKelime` |  |  |
| Button | `btnYazdir` | 10 Kez Yazdır |  |
| Label | `lblSonuc` | (boşalt) | `AutoSize` özelliğini `true` yap — 10 satır göstereceğiz |

## Hangi event

`btnYazdir`a çift tıkla, `kod.cs`'teki bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers11`, Text "Ders 11 — For Döngüsü Forma". `new Ders11_ForDonguForma().Show();`

## Çalıştı mı?

- "merhaba" yaz, bas → etikette 1'den 10'a kadar numaralı 10 satır "merhaba" görünmeli.
- Ünite 06 tamamlandı — menü + 14 form aynı projede.
