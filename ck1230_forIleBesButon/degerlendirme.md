# Değerlendirme — ck1230 For ile 5 buton üret

1. Döngü 5 kez `new Button()` çalıştırıyor — sonuçta kaç TANE ayrı buton nesnesi var?
   > Cevap notu: 5 — her `new Button()` çağrısı BAMBAŞKA, bağımsız bir nesne üretir;
   > hepsi aynı "tarif"ten (Button sınıfından) gelse de birbirinden farklı nesnelerdir.

2. `btnYeni` değişkeni döngü içinde tek bir isim, ama 5 farklı butonu temsil edebiliyor.
   Nasıl?
   > Cevap notu: Her turda `btnYeni` YENİDEN oluşturuluyor (yeni bir `new Button()`) ve
   > hemen `Controls.Add` ile forma ekleniyor — isim aynı ama her seferinde ATANAN
   > nesne farklı.
