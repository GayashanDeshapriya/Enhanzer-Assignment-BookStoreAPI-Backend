# 📚 Book Management API

A simple RESTful Web API built using **ASP.NET Core (.NET 8 LTS)** for managing books.  
This API supports full CRUD operations and follows clean architecture principles using Controllers, Services, Repositories, and DTOs.

---

## 🚀 Tech Stack

- .NET 8 (LTS)
- ASP.NET Core Web API
- C#
- RESTful API Design
- In-Memory Data Storage
- DTO Pattern
- Repository & Service Pattern

---

## 📂 Project Structure

```
BookManagementAPI/
│
├── Controllers/
├── DTOs/
├── Models/
├── Repositories/
│   └── Interfaces/
├── Services/
│   └── Interfaces/
├── Program.cs
├── appsettings.json
└── BookManagementAPI.csproj
```

---

## 📌 Features

- Create a Book
- Get All Books
- Get Book by ID
- Update Book
- Delete Book
- Server-side validation using Data Annotations
- DTO-based request & response handling
- Clean layered architecture

---

## 📘 Book Model

| Property | Type |
|----------|------|
| Id | int |
| Title | string |
| Author | string |
| Isbn | string |
| PublicationDate | DateTime |

---

## 🔗 API Endpoints

### Get All Books
```
GET /api/books
```

### Get Book By ID
```
GET /api/books/{id}
```

### Create Book
```
POST /api/books
```

### Update Book
```
PUT /api/books/{id}
```

### Delete Book
```
DELETE /api/books/{id}
```

---

## 🛠 How to Run the Backend

### 1️⃣ Install .NET 8 SDK  
Download from:  
https://dotnet.microsoft.com/download

### 2️⃣ Clone the repository
```bash
git clone <your-backend-repo-url>
cd BookManagementAPI
```

### 3️⃣ Restore dependencies
```bash
dotnet restore
```

### 4️⃣ Run the project
```bash
dotnet run
```

API will run at:
```
https://localhost:5001
or
http://localhost:5000
```

---

## 🧪 Testing the API

You can test using:

- Swagger UI (if enabled)
- Postman
- The included `.http` file
- Angular frontend

---

## 🏗 Architecture Overview

This project follows a layered architecture:

Controller → Service → Repository → In-Memory Data

DTOs are used to:
- Prevent over-posting
- Protect domain models
- Control API contracts
- Improve security

---

## 🔒 Validation

- Server-side validation using Data Annotations
- ModelState validation enabled via `[ApiController]`

---

## 📌 Notes

- Data is stored in-memory (no database used as per assignment requirement).
- This project is built using .NET 8 (LTS) for long-term stability and performance.

---

## 👨‍💻 Author

Developed as part of a Software Engineer technical assignment.
