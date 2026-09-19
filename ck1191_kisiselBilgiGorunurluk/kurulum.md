# ck1191 — Koşula göre bir bölümü göster/gizle (ek pekiştirme)

## Senaryo

Yaş ve cinsiyet gir. 18 yaşından büyük bir erkekse, ekranda "Askerlik Durumu" bölümü
(bir GroupBox) görünsün; değilse gizli kalsın.

## Hazırlık

1. `Unite06` projeni aç.
2. **Project > Add Windows Form**, adı `Ders12_KosullaGoster`.
3. Kontroller:

| kontrol | Name | Text | not |
|---|---|---|---|
| TextBox | `txtYas` |  |  |
| ComboBox | `cmbCinsiyet` |  | `Items`: "Erkek","Kadın" |
| Button | `btnKontrolEt` | Kontrol Et | `Click` → `btnKontrolEt_Click` |
| GroupBox | `grpAskerlik` | Askerlik Durumu | `Visible` özelliğini baştan `false` yap |
| RadioButton | `rdbMuaf` | Muaf | `grpAskerlik`'in İÇİNE sürükle |
| RadioButton | `rdbYapti` | Yaptı | `grpAskerlik`'in İÇİNE sürükle |

## Hangi event

`btnKontrolEt`e çift tıkla, `kod.cs`'teki bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers12`, Text "Ders 12 — Koşulla Göster". `new Ders12_KosullaGoster().Show();`

## Çalıştı mı?

- Yaş 20, Cinsiyet "Erkek" seç → Askerlik Durumu bölümü görünmeli.
- Yaş 15 ya da Cinsiyet "Kadın" → bölüm gizli kalmalı.
