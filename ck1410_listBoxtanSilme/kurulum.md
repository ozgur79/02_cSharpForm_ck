# ck1410 — ListBox'tan silme: RemoveAt, SelectedIndex

## Senaryo

Listedeki bir satıra TIKLAYIP seçeceksin, "Sil" butonu SEÇİLİ olan satırı listeden
kaldıracak.

## Hazırlık

1. `Unite09` projeni aç.
2. **Project > Add Windows Form**, adı `Ders02_ListBoxtanSilme`.
3. Bir TextBox (`txtIsim`), bir Buton (`btnEkle`, Text "Ekle"), bir ListBox
   (`lstIsimler`), bir Buton (`btnSil`, Text "Seçileni Sil") ekle.
4. `btnEkle`ye ve `btnSil`e çift tıkla.

## Hangi event

İlk blok `btnEkle_Click` gövdesine, ikinci blok `btnSil_Click` gövdesine.

## Menü formuna ekle

`Form1`e buton: `btnDers02`, Text "Ders 02 — ListBox'tan Silme".
`new Ders02_ListBoxtanSilme().Show();`

## Çalıştı mı?

- Listeye birkaç isim ekle, birine TIKLA (mavi ile seçili görünmeli), "Seçileni Sil"e
  bas — SADECE o satır listeden kaybolmalı.
- Hiçbir satır seçili değilken "Seçileni Sil"e basarsan program ÇÖKMEMELİ.
