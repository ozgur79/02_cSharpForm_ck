# ck1400 — ListBox: Items.Add, Items.Count

## Senaryo

Yeni bir kontrol: `ListBox`. Kullanıcının girdiği isimleri bir listeye ekleyip, listede
kaç tane olduğunu sayacağız.

## Hazırlık

1. `Unite09` adında yeni bir **Windows Forms Application** aç.
2. Bir Label (`lblEtiket`, Text "İsim Girin:"), bir TextBox (`txtIsim`), bir Buton
   (`btnEkle`, Text "Ekle"), bir ListBox (`lstIsimler`) ve bir Label (`lblSayac`, Text
   "Toplam: 0") ekle.
3. `btnEkle`ye çift tıkla.

## Hangi event

Blok `btnEkle_Click` gövdesinin içine.

## Menü formuna ekle

`Form1`e buton: `btnDers01`, Text "Ders 01 — ListBox Ekleme".
`new Ders01_ListBoxIleEkleme().Show();`

## Çalıştı mı?

- TextBox'a bir isim yazıp "Ekle"ye basınca isim `lstIsimler`e eklenmeli, TextBox
  boşalmalı.
- `lblSayac` her eklemede güncellenip listedeki TOPLAM eleman sayısını göstermeli.
