# ck1150 — Gizli parola: PasswordChar, doğru/yanlış kontrolü

## Senaryo

Kullanıcı adı ve parola gir; parola kutusunda yazdığın yerine `*` görünsün. Giriş'e
basınca ikisi de doğruysa "Başarılı", değilse "Yanlış" de.

## Hazırlık

1. `Unite06` projeni aç.
2. **Project > Add Windows Form**, adı `Ders07_GizliParola`.
3. Kontroller:

| kontrol | Name | Text | not |
|---|---|---|---|
| TextBox | `txtKullaniciAdi` |  |  |
| TextBox | `txtParola` |  | `PasswordChar` özelliğini `*` yap |
| Button | `btnGiris` | Giriş |  |

## Hangi event

`btnGiris`e çift tıkla, `kod.cs`'teki bloğu yapıştır.

## Menü formuna ekle

`Form1`e buton: `btnDers07`, Text "Ders 07 — Gizli Parola". `new Ders07_GizliParola().Show();`

## Çalıştı mı?

- Parola kutusuna yazınca `*` görünmeli.
- Kullanıcı adı `ogrenci`, parola `kalfa123` gir → "Başarılı Giriş".
- Başka bir şey gir → "Yanlış Kullanıcı Adı veya Parola".
