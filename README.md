# ERP Projesi – Angular & .NET

Angular ve .NET ile bir ERP projesi geliştirdim.
 📌Bu projede Clean Architecture, CQRS & MediatR, Repository Pattern, Result Pattern, Entity Framework Core, AutoMapper, SmartEnum gibi modern mimariler kullandım.

Süreç Akışı:
◽Müşteri, depo ve ürün (mamül / yarı mamül) kaydı oluşturulur
◽Ürüne ait reçete tanımlanır.
◽Sipariş girilir ve durum başlangıçta "Bekliyor" şeklindedir, henüz ürünü üretilip satılmadı.
◽Sipariş için ihtiyaç planlaması oluşturulur ve eksik yarı mamüller görüntülenir.
◽Admin eksik yarı mamülleri satın alır ve ihtiyaç planlaması tekrar çalıştırıldığında tüm malzemelerin tamamlandığı görülür.
◽Admin üretimi başlatır ve üretim tamamlandığında ürün stoğu otomatik olarak artar.
◽Son aşamada admin ürünü müşteriye satar ve sipariş durumu "Tamamlandı" olarak güncellenir.

<img width="1919" height="863" alt="image" src="https://github.com/user-attachments/assets/1b8227cb-0c16-4169-bff6-c4fdcce99eee" />
Admin ancak mail: ilayda, Şifre:1 ile giriş yapabilir


<img width="1897" height="858" alt="image" src="https://github.com/user-attachments/assets/87f21df3-499d-460c-9c45-59d74272a2c1" />
Müşteri Bilgisi kaydedilir, ardından güncellenebilir veya silinebilir.


<img width="1919" height="863" alt="image" src="https://github.com/user-attachments/assets/e4b65ab7-a385-4c60-962a-d53529a88c2c" />
Depolar kaydedilir.


<img width="1919" height="866" alt="image" src="https://github.com/user-attachments/assets/4410df44-7001-4994-81b8-6f51b710f6df" />
Ürettirilecek ürünler, mamül; ürüne ait hammaddeler ise yarı mamül adında kaydedilir.


<img width="1919" height="868" alt="image" src="https://github.com/user-attachments/assets/cb3a4151-d479-4d6d-89f4-038e20031219" />


<img width="1919" height="867" alt="image" src="https://github.com/user-attachments/assets/90299e61-0f40-4242-a9ef-1c5bd5cb984f" />
Ürün ve o ürüne ait yarı mamüller için uygun reçete oluşturulur.


<img width="1914" height="870" alt="image" src="https://github.com/user-attachments/assets/7684c104-dbb9-4a25-bca6-0db9d17e30b3" />


<img width="1897" height="864" alt="image" src="https://github.com/user-attachments/assets/bbfa9a8d-26e7-4c15-9e78-a830f304317d" />
Sipariş formu doldurulur.


<img width="1919" height="866" alt="image" src="https://github.com/user-attachments/assets/57502d22-b630-4380-809f-27ea366b2c40" />
Sipariş Durumu: Bekliyor, henüz ürün üretilip, satılmadı.


<img width="1917" height="862" alt="image" src="https://github.com/user-attachments/assets/47101acc-1817-46e5-b196-52c39bd63062" />
İhtiyaç planlaması oluştur'a tıklandığında ürünü üretmek için gerekli yarı mamüller görüntülenir.


<img width="1899" height="859" alt="image" src="https://github.com/user-attachments/assets/324c58e4-2091-4e34-8789-fe0d04afdf5b" />
Ürün için gerekli yarı mamüller satın alınır.


<img width="1919" height="869" alt="image" src="https://github.com/user-attachments/assets/30d898f1-fa02-43c9-bd75-2be79160f0f4" />


<img width="1914" height="867" alt="image" src="https://github.com/user-attachments/assets/d36c533a-f255-473f-8f7e-d892c8a85a42" />
Tüm yarı mamüller elimizde mevcutsa ürün üretilebilir aksi takdirde eksik yarı mamül uyarısı gelir


<img width="1917" height="865" alt="image" src="https://github.com/user-attachments/assets/f98595a9-3348-4c93-81e3-fd522de816b1" />


<img width="1919" height="861" alt="image" src="https://github.com/user-attachments/assets/04faa01c-b3d6-439f-961a-423a98cafe23" />
Bu sırada ürün stok bilgisi de otomatik güncellenir.


<img width="1897" height="863" alt="image" src="https://github.com/user-attachments/assets/68f01780-42a6-4afd-8a82-b602a839fe42" />
Ürün üretildi, artık müşteriye satılabilir.


<img width="1919" height="870" alt="image" src="https://github.com/user-attachments/assets/bb9eb58f-087c-4a3b-8ae2-faa61162a50f" />


<img width="1915" height="863" alt="image" src="https://github.com/user-attachments/assets/288d92ae-434f-4b89-b8cf-22268fe815de" />
Ürün üretilip, satıldı. Sipariş tamamlandığı için, Sipariş durumu: tamamlandı olarak otomatik güncellenir.


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
