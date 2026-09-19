# ornek/ — format numunesi, üretilmiş ders değil

Buradaki klasörler **öğrenciye gitmez**, `mufredat.md`'ye satır olarak girmez, ders sayısına
sayılmaz. Amaç: bir ders tipinin onaylanmış çıktısını ileride kopyalanacak örnek olarak
elde tutmak.

## ck1030_butonuBuyutSakla — WinForms ders numunesi

Özgür 2026-09-05'te inceledi ve onayladı ("beğendim"). WinForms üretimi başladığında
üç dosyanın biçimi buradan alınır: `kurulum.md` + `kod.cs` + `degerlendirme.md`.

Kaynağı Özgür'ün eski dersi: `501OnArkaSaklaGoster`. O dersin ikinci yarısı (öne/arkaya
alma + `bool tıkla` ile durum tutma) bilerek buraya alınmadı — ck1040'a ait.

Numunede özellikle korunacak üç şey:
1. `+= ` kullanımı (`btnBuyu.Width += 20;`) — sabit değer atamak yerine artırmak, "nesne
   kendi durumunu hatırlıyor" fikrini kendiliğinden doğurur.
2. `SEN YAP`ın gizli tuzağı — gizlenen buton `btnSakla` olduğu için öğrenci
   `btnGoster.Show();` yazarsa çalışmaz; `degerlendirme.md`'nin 3. sorusu bunu yakalar.
3. Merak Köşesi'nin WinForms hâli — kutu `object sender, EventArgs e` ve ünite 07'ye
   (ck1240) bağlanıyor.
