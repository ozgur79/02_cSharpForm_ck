# ck1320 — Geriye sayım: Label'a yaz, sıfırda dur

## Senaryo

Kullanıcı bir sayı girsin, "Geriye Say"a bassın — sayı her saniye 1 azalarak ekranda
görünsün, sıfıra inince Timer kendi kendini durdursun.

## Hazırlık

1. `Unite08` projeni aç.
2. **Project > Add Windows Form**, adı `Ders03_GeriyeSay`.
3. Bir Label (`lblEtiket`, Text "Sayı Girin:"), bir TextBox (`txtSayi`), bir Buton
   (`btnBaslat`, Text "Geriye Say"), bir Label (`lblSayac`) ve bir Label (`lblSonuc`,
   Text "") ekle.
4. Bir **Timer** sürükle, `Interval` = `1000` yap (Enabled varsayılan `false` kalsın).
5. `btnBaslat`a ve `timer1`e çift tıkla.

## Hangi event

İlk blok sınıfın içine (alan), ikinci blok `timer1_Tick` gövdesine, üçüncü blok
`btnBaslat_Click` gövdesine.

## Menü formuna ekle

`Form1`e buton: `btnDers03`, Text "Ders 03 — Geriye Say".
`new Ders03_GeriyeSay().Show();`

## Çalıştı mı?

- TextBox'a `5` yazıp "Geriye Say"a basınca `lblSayac` her saniye 1 azalmalı: 4, 3, 2, 1, 0.
- Sıfıra inince `lblSonuc` "BOOM" yazmalı ve sayaç bir daha azalmamalı (Timer durmuş
  olmalı).
