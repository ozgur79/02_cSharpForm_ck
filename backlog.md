# Backlog

Canlı durum. Biten madde silinir, `backlog-log.md`'ye taşınır.

- **arsiv/14 işleniyor (45 madde → 33 planlı + 9 plan-dışı ek pekiştirme, 3 atlandı).**
  Özgür onayladı: ck1000 çalıştı, "hiç durma" dedi. Kararlar: [28]/[29] (ck1390 duplicate)
  arasından ck seçecek; plan-dışı 12 maddeden 3'ü ([36] görsel yok, [41] [40] ile
  neredeyse birebir aynı, [43] tanımsız kontrole bağlı ölü handler) atlandı, kalan 9'u
  ([34],[35],[37],[38],[39],[40],[42],[44],[45]) ilgili ünitenin sonuna ek pekiştirme
  olarak yediriliyor (numaralar: ck1191-1194 ünite06, ck1295 ünite07, ck1395 ünite08,
  ck1452/1454/1458 ünite09). [45] hasta randevu çok karmaşıktı (2D dizi + TC kontrolü +
  sıra sistemi), lise seviyesine indirgenip sadeleştirilecek.
  **Ünite 05 (ck1000-ck1080, 9 ders) TAMAMLANDI, commit edildi.** ck1000 onaylandı
  (Test-Gunlugu.md'ye işlendi). ck1030 `ornek/`deki onaylı numuneden uyarlandı — form adı
  çakışmayı önlemek için `Ders03`→`Ders04` yapıldı (numune sadece format referansı,
  ünite içi sıralı adlandırma üretim anında belirleniyor). Kara kutu rotasyonu 2. turunu
  tamamladı (ck1010/1020/1030/1070), 3. tur ünite 06'da devam edecek. ck'nin işi kodun
  derlendiğini/mantığını doğrulamak; formda gerçekten çalıştığını Özgür'ün elle
  denemesi belirliyor — bu yüzden Opacity gibi sınır-değer riski olan yerlere önceden
  koruma (`if` kontrolü) eklendi.
- **Sıradaki: Ünite 06 (ck1100-ck1199 + ek pekiştirmeler ck1191-1194).**
