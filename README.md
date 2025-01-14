# FinancialCRM 

📊 **FinancialCRM** – Kapsamlı bir finansal yönetim çözümü sunan Windows Forms tabanlı bir uygulama. Proje, fatura, banka işlemleri ve kullanıcı giriş sistemi gibi temel özellikleri içeren kullanıcı dostu bir tasarıma sahiptir.

---

## 🚀 **Özellikler**

### 1. **LoginFrm (Giriş Formu)** 🔒
Kullanıcıların sisteme güvenli bir şekilde giriş yapmasını sağlar.

- **Kullanıcı Doğrulama:**
  Kullanıcı adı ve şifre veritabanından doğrulanır. Yanlış girişlerde kullanıcıya uyarı mesajı gösterilir.
- **Başarılı Giriş:**
  Doğru bilgiler girildiğinde kullanıcı, **FrmBilling** formuna yönlendirilir.

---

### 2. **FrmBilling (Fatura Yönetimi)** 💳
Kullanıcıların fatura işlemlerini yönetmelerine olanak tanır.

- **Fatura Listesi:**
  Mevcut faturaları listeleme imkanı sağlar.
- **Yeni Fatura Oluşturma:**
  Kullanıcı, fatura başlığı, tutarı ve dönemi girerek yeni bir fatura oluşturabilir.
- **Fatura Silme:**
  ID bazlı silme işlemi yapılabilir.
- **Fatura Güncelleme:**
  Mevcut faturaların bilgileri kolayca güncellenebilir.

---

### 3. **Form1 (Banka İşlemleri)** 🏦
Banka bakiyeleri ve son işlemleri yönetmek için tasarlanmıştır.

- **Banka Bakiyeleri:**
  Banka adlarına göre toplam bakiyeler görüntülenir.
- **Son Banka İşlemleri:**
  Son beş işlem detayları listelenir (açıklama, miktar, işlem tarihi).

---

### 4. **FrmDashboard (Genel Bakış)** 📈
Uygulamanın tüm finansal verilerinin grafiklerle sunulduğu bir kontrol panelidir.

- **Toplam Bakiye:**
  Tüm bankalardaki toplam bakiye gösterilir.
- **Son İşlem Tutarı:**
  En son bankacılık işleminin tutarı gösterilir.
- **Grafikler:**
  - Banka bakiyeleri grafiği
  - Fatura tutarlarını gösteren pasta grafiği
- **Fatura Döngüsü:**
  Elektrik, doğalgaz, su gibi faturaların tutarlarını döngüsel olarak gösterir.

---

## 📂 **Projeyi Çalıştırma**

1. **Gereksinimler:**
   - .NET Framework
   - Visual Studio
   - MSSQL Server (veritabanı için)

2. **Kurulum:**
   - Projeyi klonlayın:
     ```bash
     git clone https://github.com/username/FinancialCRM.git
     ```
   - MSSQL üzerinde "FinancialCrmDbEntities" adında bir veritabanı oluşturun ve gerekli tabloları oluşturun.

3. **Çalıştırma:**
   - Visual Studio”a projeyi açın.
   - "Start" butonuna tıklayın.

---

## 🌟 **Öne Çıkan Teknolojiler**

- **C# (.NET Framework)**: Windows Forms uygulama geliştirme için.
- **Entity Framework**: Veritabanı işlemleri için ORM.
- **MSSQL**: Veritabanı yönetimi.
- **Windows Forms**: Kullanıcı dostu arayüz tasarımı.

---

## 📸 **Ekran Görüntüleri**

### LoginFrm
🔑 Kullanıcı giriş ekranı:  
![image](https://github.com/user-attachments/assets/e95cc955-8d86-4340-9bfc-e0f94cb51982)


### FrmBilling
💳 Fatura yönetimi ekranı:  
![image](https://github.com/user-attachments/assets/7208a4fd-b09d-4237-be42-aa5fbc2890fd)


### Form1
🏦 Banka işlemleri ekranı:  
![image](https://github.com/user-attachments/assets/5aabcf19-6de3-498f-8661-eabee92bd303)


### FrmDashboard
📊 Genel bakış ekranı:  
![image](https://github.com/user-attachments/assets/16128564-241e-4ffb-81b1-af84705f900f)


---

## 👥 **Katkıda Bulunma**
Katkıda bulunmak isterseniz lütfen bir "pull request" oluşturun veya bir "issue" açarak hataları bildirin.

---

## 📧 **İletişim**
Herhangi bir sorunuz varsa, bana aşağıdaki kanallardan ulaşabilirsiniz:

- **Email:** [emircanbagdu52@gmail.com](mailto:emircanbagdu52@gmail.com)
- **Web:** [emircanbagdu.com.tr](http://emircanbagdu.com.tr)
- **LinkedIn:** [LinkedIn Profilim](https://linkedin.com/in/emircanbagdu)
