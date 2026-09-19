// ck1030 — Butonu büyüt, butonu sakla
// NASIL: Unite05 projesine Ders03_BuyuSakla formunu ekle (bkz. kurulum.md), aşağıdaki
//        blokları ilgili butona çift tıklayınca açılan gövdenin İÇİNE yapıştır.
// Ne öğreneceğiz: Nesnenin ÖZELLİĞİNİ değiştirmek ile METODUNU çağırmak arasındaki fark.
// Not: Formun üstündeki "public partial class Ders03_BuyuSakla : Form" ve
//      "InitializeComponent();" satırları VS'in hazır iskeleti. Şimdilik olduğu gibi
//      bırak, ünite 07'de tek tek açacağız.

// --- KAVRAM ---

// >>> btnBuyu_Click gövdesinin içine:
btnBuyu.Width += 20;    // butonun genişliği her tıklamada 20 piksel artar
btnBuyu.Height += 10;   // yüksekliği 10 piksel artar
// Width ve Height birer ÖZELLİK: butonun bir sıfatı, değeri var, değiştirebiliyorsun.
// Dikkat: hiçbir yerde "butonun eski genişliği" diye bir değişken tutmadın.
// Buton kendi genişliğini kendisi hatırlıyor.

// >>> btnSakla_Click gövdesinin içine:
btnSakla.Hide();        // butonu ekrandan gizler
// Hide bir METOT: butona verdiğin bir emir, sonunda parantezi var, iş yapar.

// Ayrım kuralı: nokta koyduktan sonra
//   ... = bir şey atıyorsan   -> ÖZELLİK   (btnBuyu.Width = 100;)
//   ... sonunda () varsa       -> METOT     (btnSakla.Hide();)

// --- SEN YAP ---
// 1) "Sakla"ya bastıktan sonra butonu geri getirmenin yolu yok. Forma btnGoster adında
//    üçüncü bir buton ekle ve gizlenen butonu geri getir. Hangi butonun adını yazman
//    gerektiğine dikkat et.
// 2) btnBuyu'ya her tıklandığında butonun rengi de değişsin:
//    BackColor'ı Color.Yellow yap. Bu yazdığın satır özellik mi, metot mu?
// 3) Butonu büyüten satırdaki 20'yi 100 yap, 5 kez tıkla. Ne oluyor, forma sığıyor mu?

// --- MERAK KÖŞESİ ---
// btnBuyu_Click(object sender, EventArgs e) — parantezin içini sen yazmadın, VS yazdı.
// Bu satırda ne var?
// "sender" = bu olayı kim başlattı. Şu an tek butonun kodu olduğu için gerek duymuyorsun,
// ama ünite 07'de beş butona TEK kod yazacağız; hangisine basıldığını işte bu kelimeden
// öğreneceğiz. Şimdilik bilmen gereken: orada, hazır bekliyor.
