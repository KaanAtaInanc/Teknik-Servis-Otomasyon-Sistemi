# 🛠️ Teknik Servis Takip ve Stok Yönetim Sistemi

![Language](https://img.shields.io/badge/language-C%23-green) ![Framework](https://img.shields.io/badge/framework-.NET-purple) ![Database](https://img.shields.io/badge/database-SQL%20Server-red)

Bu proje, teknik servis hizmeti veren işletmelerin iş süreçlerini dijitalleştirmek, arızalı cihaz takibini güvenli hale getirmek ve parça stok yönetimini hatasız bir şekilde gerçekleştirmek amacıyla geliştirilmiş kapsamlı bir **Masaüstü Otomasyon Sistemidir**.

!! Proje detayları öncesinde.
İlgili proje Trakya Üniversitesi Bilgisayar Programcılığı 2.sınıf "Sistem Analizi ve Tasarımı" dersinde dönem ve mezuniyet projesi olarak geliştirilmiştir.
Geliştirici:
Kaan Ata İnanç
TÜ BPR Öğrencisi
!!Lütfen Projeyi aynen kopyalamayınız
!!! DATABASE bağlantı kısımlarında lütfen kendi SQL Sunucu bağlantı adresini koyunuz yoksa proje database hatası verecektir. Kullanılan sql ve sql sunucusu local bir sunucudur

## 🚀 Proje Hakkında

Geleneksel yöntemlerle (kağıt, Excel) yapılan takiplerde yaşanan veri kayıplarını ve stok tutarsızlıklarını önlemek ana hedeftir. Proje, özellikle **SQL Transaction** mimarisi kullanılarak geliştirilen "Otomatik Stok Düşüm" modülü sayesinde, envanter yönetimindeki maliyet kaçaklarını (fire) minimize eder.

### ✨ Temel Özellikler

* **🔐 Rol Bazlı Yetkilendirme:** Admin, Teknisyen ve Danışma personeli için özelleştirilmiş paneller.
* **📦 Akıllı Stok Yönetimi:** Onarımda kullanılan parçanın stoktan anlık ve güvenli (Transaction ile) düşülmesi.
* **⚠️ Kritik Stok Uyarısı:** Belirlenen seviyenin altına düşen ürünler için otomatik sistem uyarısı.
* **📱 Cihaz Takibi:** Cihazın kabulünden teslimine kadar (Beklemede, İşlemde, Tamamlandı) durum takibi.
* **🎨 Modern Arayüz:** Standart Windows formları yerine **MetroFramework** ve **Modern UI** tasarımı.
* **📊 Raporlama:** Günlük işlem özetleri ve personel performans takibi.

## 🛠️ Kullanılan Teknolojiler

Bu proje, endüstri standartları ve en güncel geliştirme araçları kullanılarak hazırlanmıştır:

* **IDE:** Visual Studio 2026 (Insider/Preview)
* **Dil:** C# (.NET Framework)
* **Veritabanı:** Microsoft SQL Server 2022
* **ORM / Veri Erişim:** ADO.NET
* **UI Kütüphaneleri:** MetroFramework, FontAwesome.Sharp

## 📸 Ekran Görüntüleri

| Giriş Paneli | Yönetim Paneli |
| :---: | :---: |
| ![Giriş]<img width="1458" height="928" alt="Ekran görüntüsü 2025-12-04 171654" src="https://github.com/user-attachments/assets/776f4ffc-df6f-49d6-bbb8-5c4df30da11c" />
) | ![Dashboard](https://via.placeholder.com/400x250?text=Yonetim+Paneli+Resmi) |

| Stok Yönetimi | Arıza Takip |
| :---: | :---: |
| ![Stok](<img width="1476" height="1005" alt="Ekran görüntüsü 2025-12-11 140100" src="https://github.com/user-attachments/assets/c62d532c-7320-42e1-9dd5-30d1a1d40776" /> 
)

*(Not: Ekran görüntüleri direk olarak UI fotoğraflarıdır)*

## ⚙️ Kurulum ve Çalıştırma

Projeyi kendi bilgisayarınızda çalıştırmak için aşağıdaki adımları izleyin:

1.  **Projeyi Klonlayın:**
    ```bash
    git clone [https://github.com/KULLANICI_ADIN/Teknik-Servis-Otomasyonu.git](https://github.com/KULLANICI_ADIN/Teknik-Servis-Otomasyonu.git)
    ```

2.  **Veritabanını Oluşturun:**
    * SQL Server Management Studio'yu (SSMS) açın.
    * Proje dosyasındaki `Database_Script.sql` dosyasını çalıştırarak tabloları ve ilişkileri oluşturun.

3.  **Bağlantı Ayarı:**
    * `App.config` dosyasını açın.
    * `connectionString` kısmındaki `Data Source` alanını kendi SQL Sunucu adınızla değiştirin.
    ```xml
    <add name="TeknikServisBaglanti" connectionString="Data Source=SENIN_PC_ADIN;Initial Catalog=Teknik_Servis_DB;Integrated Security=True" />
    ```

4.  **Çalıştırın:**
    * Visual Studio üzerinden `Start` (F5) tuşuna basın.
    * **Varsayılan Admin Girişi:** `Kullanıcı: Admin_Admin` / `Şifre: admin123`

## 🧠 Koddan Bir Örnek (Transaction Yapısı)

Stok düşme işleminde veri bütünlüğünü sağlamak için kullanılan yapı:

```csharp
using (SqlTransaction transaction = connection.BeginTransaction())
{
    try
    {
        // 1. Stoktan Düş
        SqlCommand cmdStok = new SqlCommand("UPDATE Parcalar SET Adet = Adet - 1 WHERE ID=@id", connection, transaction);
        cmdStok.ExecuteNonQuery();

        // 2. İşlemi Onayla
        SqlCommand cmdIslem = new SqlCommand("INSERT INTO Islemler...", connection, transaction);
        cmdIslem.ExecuteNonQuery();

        transaction.Commit(); // Her şey yolundaysa kaydet
    }
    catch
    {
        transaction.Rollback(); // Hata varsa her şeyi geri al (Veri kaybını önle)
    }
}

