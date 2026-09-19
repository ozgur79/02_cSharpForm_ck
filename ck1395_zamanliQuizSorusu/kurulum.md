# ck1395 — Zamanlı quiz sorusu (ek pekiştirme)

## Senaryo

RadioButton (ck1180) + Timer (bu ünite) bir arada: bir soru sorulacak, cevap
seçeneklerinden biri RadioButton, süre dolmadan cevaplaman gerekecek.

## Hazırlık

1. `Unite08` projeni aç.
2. **Project > Add Windows Form**, adı `Ders11_ZamanliQuiz`.
3. Bir TextBox (`txtSoru`, `Multiline` = `true`, `ReadOnly` = `true`, Text: "Hangisi bir
   yazılım dilidir?"), dört RadioButton (`rdbA` "Word", `rdbB` "C#", `rdbC` "Excel",
   `rdbD` "Paint"), bir Buton (`btnCevapla`, Text "Cevapla") ekle.
4. Bir **Timer** sürükle, `Interval` = `10000` (10 saniye), `Enabled` = `true` yap.
5. `btnCevapla`ya ve `timer1`e çift tıkla.

## Hangi event

İlk blok `timer1_Tick` gövdesine, ikinci blok `btnCevapla_Click` gövdesine.

## Menü formuna ekle

`Form1`e buton: `btnDers11`, Text "Ders 11 — Zamanlı Quiz".
`new Ders11_ZamanliQuiz().Show();`

## Çalıştı mı?

- Doğru seçeneği (`rdbB`) işaretleyip "Cevapla"ya basarsan "Tebrikler, cevap doğru"
  çıkmalı ve form kapanmalı.
- Yanlış seçeneği işaretleyip "Cevapla"ya basarsan "Üzgünüz, cevap yanlış" çıkmalı ve
  form kapanmalı.
- 10 saniye içinde HİÇ cevaplamazsan "Süre doldu" çıkmalı ve form kendiliğinden
  kapanmalı.
