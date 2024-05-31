 
# Dotnet Veritabanı İşlemleri Projesi

Merhaba! Bu Projede Dotnet MVC Entity Framework ve SQL Server kullanarak. Listeleme,Ekleme,Güncelleme,Silme İşlemlerini gerçekleştiren bir admin panel tasarımı yaptım.

---

## Projedeki Teknolojiler
[![My Skills](https://skillicons.dev/icons?i=bootstrap,html,css,js,cs,dotnet,mysql)](https://skillicons.dev)

---

## Projeyi Başlatma

1. Bu depoyu klonlayın:


2. Proje dizinine gidin:


3. Gerekli bağımlılıkları yükleyin:
   
Microsoft SQL Server Express kurulumunu yapın. 
https://www.microsoft.com/tr-tr/sql-server/sql-server-downloads

EntityFramework Veritabanı İşlemleri Aracı
dotnet tool install --global dotnet-ef

Eğer daha önce yüklendiyse güncelleyin:
dotnet tool update --global dotnet-ef

Terminal ekranından paketleri ekleyin:
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools

SQL SERVER:
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

VSCODE EKLENTİLERİ:

SQL Server (mssql) - Microsoft

5. Geliştirme sunucusunu başlatın:

 DenemeContext.cs dosyasını düzenleyin (ServerName) ("Server=ServerName;Initial Catalog=DenemikiDb;Integrated Security=True;Trusted_Connection=True;Encrypt=False;");

var olan migrations dosyasını silin ve ardından terminale ekleyin:

dotnet ef migrations add yeni
dotnet ef database update



7. Tarayıcınızda `localhost:3000` adresine gidin ve projeyi görüntüleyin.

---

## Proje Geliştiricisi

Bu projeyi geliştiren: Taha Emre Sevgilice

---

## Katkıda Bulunma

Eğer projeye katkıda bulunmak istiyorsanız, lütfen bir fork oluşturun ve pull request gönderin. Katkılarınızı memnuniyetle karşılayacağız!

---

© 2024 Taha Emre Sevgilice


