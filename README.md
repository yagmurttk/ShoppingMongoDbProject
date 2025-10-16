# 🛍️ ShoppingNightMongo

Modern bir e-ticaret uygulaması; **ASP.NET Core MVC** ve **MongoDB** altyapısı ile geliştirilmiş dinamik bir platformdur.  
Kullanıcılar ürünleri inceleyebilir, kampanyaları slider bileşenleri üzerinden takip edebilir ve e-posta aboneliği ile indirim kuponlarına ulaşabilir.  
Yönetim paneli sayesinde tüm içerikler kolayca yönetilebilir.

---

## ✨ Öne Çıkan Özellikler

- 📦 **MongoDB (NoSQL)** altyapısı ile esnek veri yönetimi  
- 🛍️ Ürün, kategori ve kampanya (slider) yönetimi  
- 💌 E-posta abonelik sistemi ve otomatik indirim kuponu üretimi  
- ⚙️ Katmanlı mimari (Controller, Service, DTO, View)  
- 🔄 **Async / Await** ile performanslı asenkron veri işlemleri  
- 🧩 Yeniden kullanılabilir **Partial View** ve **ViewComponent** yapıları  
- 🔐 Admin paneli üzerinden içerik yönetimi  

---

## 🏗 Mimari Yapı

| Katman | Açıklama |
|---|---|
| **Controllers** | HTTP isteklerini işler ve servislerle iletişim kurar |
| **Services** | İş mantığı ve veritabanı işlemleri burada kapsüllenir |
| **DTOs** | Model ↔ View veri aktarımını sağlar |
| **Views** | Razor yapısı ile kullanıcı arayüzü oluşturulur |
| **ViewComponents / Partials** | Tekrar kullanılabilir dinamik UI parçaları (slider, ürün kartları) |

---

## 🗃️ MongoDB Koleksiyonları

Projede kullanılan ana koleksiyonlar:

- **Products**  
- **Categories**  
- **ProductImages**  
- **Sliders**

> Ürünler `CategoryId` üzerinden kategorilere bağlanır.  
> Slider bileşenleri yönetim panelinden kolayca güncellenebilir.

---

## ✉️ E-posta Aboneliği & İndirim Kuponu

- Kullanıcı e-posta adresini bıraktığında sistem otomatik olarak **%20 indirim kuponu** oluşturur.  
- Kodlar **8 karakter uzunluğunda rastgele alfanümerik** biçimde üretilir.  
- Kullanıcıya e-posta ile bilgilendirme gönderilir.  
- Gönderimler **Gmail SMTP** servisi ve uygulama şifresiyle güvenli şekilde yapılır.

---

## 🖼️ Ekran Görüntüleri

![UI SLİDER](https://github.com/user-attachments/assets/07adf638-da2a-4004-a81c-2976703377aa)

![UI KATEGORİLER](https://github.com/user-attachments/assets/fe868b16-2785-4ecb-b39b-80a893796847)

![UI ÜRÜN GENEL BAKIŞ](https://github.com/user-attachments/assets/21dcaaca-e4fc-45bc-a82f-cbe0aec66a39)

---![UI ÜRÜN GENEL BAKIŞ FİLTER](https://github.com/user-attachments/assets/e2a53a12-8b5a-4a2e-bd3c-3b354cb7d085)

![Admin Kategoriler](https://github.com/user-attachments/assets/b79f466a-ab39-47ba-a840-7829d7df8bad)

![Admin Kategori Düzenleme](https://github.com/user-attachments/assets/2adfa1ba-139d-44a4-928f-6afb023c9e0e)

![Slider Listesi](https://github.com/user-attachments/assets/f0c49303-1bb8-4809-808a-fa11e56710a0)

![Ürünler](https://github.com/user-attachments/assets/ef5b4f29-de40-4f0b-9419-d87c29eb8088)

![Ürün Düzenleme](https://github.com/user-attachments/assets/6b3e2a1d-2340-46a2-8dde-e3c9ee38359b)

![MAİL](https://github.com/user-attachments/assets/afa584ac-5418-4c9a-9adf-5a4c1845772c)


## 🛠 Teknolojiler

| Teknoloji | Kullanım Amacı |
|---|---|
| ASP.NET Core MVC | Web uygulama çatısı |
| MongoDB | Belge tabanlı NoSQL veritabanı |
| Gmail SMTP (App Password) | Güvenli e-posta gönderimi |
| Bootstrap 5 | Modern, responsive kullanıcı arayüzü |
| C# (Modern) | Backend geliştirme |
| JavaScript (Fetch / AJAX) | Dinamik veri işlemleri |
| LINQ | Koleksiyon ve veri sorgulama |
| Async / Await | Asenkron veri işlemleri |
| DTO Pattern | Katmanlar arası veri aktarımı |

---
