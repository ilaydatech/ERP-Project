# ERP Projesi – Angular 17 & .NET 8

Bu proje, modern web teknolojileri kullanılarak geliştirdiğim **kurumsal seviyede bir ERP (Enterprise Resource Planning) sistemidir**.  
Proje, **Angular ve .NET ** teknolojileri temel alınarak; güçlü, ölçeklenebilir ve bakımı kolay bir mimari yapı hedeflenerek geliştirilmiştir.

Proje geliştirme sürecinde **Clean Architecture**, **CQRS**, **Repository Pattern** ve **Result Pattern** gibi modern yazılım mimarileri ve tasarım kalıpları aktif olarak uygulanmıştır.

Projem, kapsamlı ve tam fonksiyonel bir ERP projesidir. Kullanıcı, kendi işletmesi için müşteri, depo, ürün, reçete, sipariş, fatura ve üretim bilgilerini bu panel üzerinden takip edebilmektedir. Kullanıcı, müşteri ve depo bilgilerini girdikten sonra mamül ve yarı mamül şeklinde ürünler ekleyebilir. Ardından, mamül ürünün ihtiyaç duyduğu malzemeleri yarı mamül olarak tanımlayıp uygun reçete oluşturabilir.

Eklediği siparişe ait ihtiyaç planlaması oluşturabilir, ürettireceği ürüne ait gerekli malzemeleri (yarı mamülleri) görüntüleyebilir ve üretim bölümünden bu malzemeleri ürettirebilir. 

Aynı zamanda alış ve satış faturası oluşturabilir, ürünler bölümünden ise her bir üründen stokta kaç adet kaldığını takip edebilir.

<img width="1897" height="863" alt="Ekran görüntüsü 2025-12-08 113031" src="https://github.com/user-attachments/assets/9949d1b7-2c75-48b8-8f5d-80e6a344d8db" />

<img width="1915" height="867" alt="Ekran görüntüsü 2025-12-08 113108" src="https://github.com/user-attachments/assets/388a6503-e511-4260-9136-29e2e1e93709" />

<img width="1917" height="860" alt="Ekran görüntüsü 2025-12-08 113153" src="https://github.com/user-attachments/assets/077f78ea-c409-4683-ab38-f088feb95876" />

<img width="1916" height="861" alt="Ekran görüntüsü 2025-12-08 113218" src="https://github.com/user-attachments/assets/c11c8292-4a45-482e-8bd2-db81fd0b3dce" />

<img width="1917" height="860" alt="Ekran görüntüsü 2025-12-08 113254" src="https://github.com/user-attachments/assets/a80b349c-6d78-4ba6-a3a0-2d0b6730a9ae" />

<img width="1462" height="721" alt="Ekran görüntüsü 2025-12-08 113452" src="https://github.com/user-attachments/assets/7d95bd18-7ea7-4c46-8905-32db44497d55" />

---

## 🚀 Kullanılan Teknolojiler ve Kütüphaneler

### Backend
- .NET 
- Entity Framework Core
- MediatR
- AutoMapper
- SmartEnum
- Scrutor
- Clean Architecture
- CQRS (Command Query Responsibility Segregation)
- Repository Pattern
- Result Pattern

### Frontend
- Angular 
- Admin LTE Tema
- TypeScript
- RxJS

---

## 🧱 Mimari Yaklaşım

Bu projede **Clean Architecture ** yaklaşımı esas alınmıştır.  
Bu sayede:

- Katmanlar arası bağımlılıklar minimize edilmiştir
- Uygulama daha **test edilebilir** hale getirilmiştir
- Kod yapısı daha **bakımı kolay ve sürdürülebilir** bir form kazanmıştır

Ayrıca backend tarafında:
- **CQRS + MediatR** kullanılarak okuma ve yazma işlemleri ayrılmış,
- İş kuralları daha **kontrollü ve yönetilebilir** hale getirilmiştir.

---

## ✅ Projede Yer Alan Temel Özellikler

- Kullanıcı girişi ve yetkilendirme sistemi
- Ürün yönetimi
- Stok yönetimi
- Sipariş ve faturalama işlemleri
- Dashboard ve raporlama ekranları
- Rol bazlı yetkilendirme
- API tabanlı veri iletişimi
- Katmanlı ve modüler mimari yapı

---

## 🧠 Bu Projede Neler Öğrenildi?

- ERP nedir, ne işe yarar?
- Clean Architecture ile ERP projesi nasıl geliştirilir?
- Angular ile ERP projesi nasıl geliştirilir?
- CQRS ve MediatR nasıl uygulanır?
- Entity Framework Core ile veri erişimi
- AutoMapper ile nesne dönüşümleri
- SmartEnum ile daha güvenli enum kullanımı
- Scrutor ile bağımlılık enjeksiyonları

---

## ⚙️ Kurulum

### Backend
```bash
dotnet restore
dotnet build
dotnet run
