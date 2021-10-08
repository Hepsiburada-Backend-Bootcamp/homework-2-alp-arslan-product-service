# Product Service

## Swagger Documentation:

https://app.swaggerhub.com/apis-docs/alprsln/product-service-api/v1

---
## Prequisites:
- Visual Studio or VScode with the necessary packages
- Docker desktop

---

## Setting up Postgresql database:

1) Download and start docker desktop 

2) Navigate to the `homework-2-alp-arslan-product-service` directory and run docker compose

```bash
docker compose up
```

3) Navigate to `ProductApi` and update the database
- (Migration is included in the repo)

```bash
dotnet ef database update
```

4) You can access the admin panel by going to `localhost:5050`. Log in and add a new server connection with values:
```yml
email: root@hepsinerede.com
password: toor

host name: postgresql
port: 5432
username: postgres
password: toor
```

5) Or you can inject a cli into the postgres container and access the database by running the command below

```bash
psql -h localhost -U postgres
```

# 2. Hafta Ödev
Restful Api Geliştirin

- Rest standartlarına uygun olmalıdır.
- solid prensiplerine uyulmalıdır.
- EntityFramework Core ve Dapper kullanılmalıdır.
- En az 3 tablo olmalı ve birbir ile ilişkili olmalılardır.
- Dependency injection kullanılmalıdır.
- Automapper veya mapster projede kullanılmalıdır.
- Serilog ile log işlemleri gerçekleştirilmelidir.
- Projede swagger implementasyonu gerçekleştirilmelidir.
- Proje docker da publish edilmelidir.

# Bonus
- Proje birden fazla db ye destek verebilmeli ve runtime da db değişikliği yapılabilmeli(design patternlerin kullanımı düşünülmelidir.)
- Mediator pattern(mediatr kütüphanesi kullanılabilir.) tercih edilebilir. 
