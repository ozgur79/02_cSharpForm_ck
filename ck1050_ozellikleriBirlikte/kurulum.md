# ck1050 — Enabled, Visible, BackColor, Size bir arada

## Senaryo

Dört ayrı buton, dört ayrı özelliği değiştiriyor: boyut, renk, görünürlük (5 tıklamada
kaybolma), tıklanabilirlik.

## Hazırlık

1. `Unite05` projeni aç.
2. **Project > Add Windows Form**, adı `Ders06_OzellikleriGor`.
3. Kontroller:

| kontrol | Name | Text |
|---|---|---|
| Button | `btnBoyut` | Boyutu Değiştir |
| Button | `btnRenk` | Rengi Değiştir |
| Button | `btnGizlen` | 5 Kez Tıkla, Kaybolayım |
| Button | `btnDevreDisi` | Devre Dışı Bırak |

## Hangi event

Her butona sırayla çift tıkla, `kod.cs`'teki ilgili bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers06`, Text "Ders 06 — Özellikler Bir Arada".
`new Ders06_OzellikleriGor().Show();`

## Çalıştı mı?

- Boyutu Değiştir → buton büyür.
- Rengi Değiştir → arka plan siyah, yazı beyaz olur.
- 5 Kez Tıkla → beşinci tıklamada buton kaybolur.
- Devre Dışı Bırak → buton griye döner, bir daha basılamaz.
