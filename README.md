# 🎮 Tic Tac Toe Oyunu - C# Windows Forms

Bu proje, **C#** ve **Windows Forms** kullanılarak geliştirilmiş basit ve etkileşimli bir **Tic Tac Toe (XOX)** oyunudur. Oyun mantığı, grafik çizim ve olay tabanlı programlamayı uygulamalı olarak gösterir.

---

## 📸 Önizleme

![Oyun Görseli](screenshot) 

---

## 🧩 Özellikler

- İki oyunculu oyun modu (Oyuncu 1 vs Oyuncu 2)
- Kazananın otomatik olarak belirlenmesi (satır, sütun, çapraz)
- Beraberlik durumu kontrolü
- Oyunu yeniden başlatma (Restart) özelliği
- Elle çizilmiş oyun tahtası (grid çizgileri)
- Kazanan hamleler için vurgulu renk
- Oyuncu sırası gösterimi (Player1 / Player2)
- Hatalı hamlelerde kullanıcı uyarısı

---

## 🛠️ Kullanılan Teknolojiler

- C# (.NET Framework)
- Windows Forms (WinForms)
- GDI+ (`Graphics.DrawLine` ile çizim)
- Visual Studio IDE

---

## 🚀 Nasıl Çalıştırılır?

1. Bu depoyu klonlayın veya ZIP olarak indirin.
2. Visual Studio ile `.sln` dosyasını açın.
3. `Resources` klasörü altında X, O ve soru işareti (`?`) simgelerinin tanımlı olduğundan emin olun.
4. Derleyin ve çalıştırın (`F5` veya `Ctrl + F5`).


---

## 🔍 Teknik Notlar

- Oyun tahtası çizgileri `Graphics` sınıfı ile manuel olarak çizilmiştir.
- Her butonun `Tag` özelliği, o hücrede hangi oyuncunun hamle yaptığını tutar (`"X"`, `"O"` veya `"?"`).
- Tüm butonlar tıklanmışsa ve kazanan yoksa sonuç **beraberlik (Draw)** olarak ilan edilir.

---

## 🤝 Katkıda Bulunun

Projeye katkıda bulunmak isterseniz fork'layabilir, hata bildirimi (issue) açabilir veya pull request gönderebilirsiniz. Geri bildirimlere açığım!

---

## 👤 Geliştirici

**[FERHAT OSMAN]**  
📧 [ferhatware@gmail.com]  
🔗 [https://www.linkedin.com/in/ferhat-osman-ba7131323/] • [https://github.com/FERHATware]
