# FileProcessing_Conversion
A modular monolith-based full-stack file processing platform with ASP.NET Core Web API, Angular, SQL Server, asynchronous file processing, image/PDF conversion, and ZIP/Unzip utilities.
A full-stack file processing and conversion platform built with
ASP.NET Core Web API, Angular, and a Modular Monolith
architecture.

Bilkul. Neeche **actual `README.md` Markdown source** de raha hoon — directly GitHub repository ke `README.md` me paste kar sakte ho. Isme professional UI, badges, feature cards, architecture, project structure, workflow aur tech stack included hain.

````markdown
# 📁 FileProcess & Conversion

<p align="center">
  <img src="https://img.shields.io/badge/.NET-10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET 10"/>
  <img src="https://img.shields.io/badge/ASP.NET%20Core-Web%20API-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt="ASP.NET Core"/>
  <img src="https://img.shields.io/badge/Angular-21-DD0031?style=for-the-badge&logo=angular&logoColor=white" alt="Angular"/>
  <img src="https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" alt="SQL Server"/>
</p>

<p align="center">
  <strong>Full-Stack Image & Document Processing Platform</strong>
</p>

<p align="center">
  A modular monolith application for image processing, document conversion,
  file compression, and other file utilities.
</p>

---

## 🚀 Overview

**FileProcess & Conversion** is a full-stack application designed to provide
multiple image, document, and file-processing utilities through a modern web
interface and secure RESTful APIs.

The backend follows a **Modular Monolith architecture** with
**feature-based modules**, while shared infrastructure and Entity Framework
Core migrations are maintained separately.

The application focuses on clean module boundaries, asynchronous file
processing, centralized exception handling, and maintainable backend
architecture.

---

## ✨ Features

<table>
<tr>
<td width="50%">

### 🖼️ Image Processing

- Image Compression
- Image Resizing
- Image Cropping
- JPG Conversion
- PNG Conversion
- WebP Conversion

</td>

<td width="50%">

### 📄 Document Processing

- Image → PDF
- PDF → Image
- PDF page processing
- Document conversion utilities

</td>
</tr>

<tr>
<td width="50%">

### 📦 File Utilities

- ZIP files
- Unzip files
- Multiple file processing
- File validation
- Processed file output

</td>

<td width="50%">

### ⚙️ Backend

- RESTful APIs
- Async file processing
- Dependency Injection
- Centralized exception handling
- Feature-based modules
- Modular Monolith architecture

</td>
</tr>
</table>

---

# 🏗️ Architecture

The backend follows a **Modular Monolith + Feature-Based Module**
architecture.

```text
                         ┌──────────────────────┐
                         │      Angular UI      │
                         │    Presentation      │
                         └──────────┬───────────┘
                                    │
                               HTTP / REST
                                    │
                                    ▼
                 ┌─────────────────────────────────────┐
                 │          ASP.NET Core API            │
                 │                                     │
                 │        Modular Monolith             │
                 │                                     │
                 │  ┌───────────────────────────────┐  │
                 │  │      Image Processing         │  │
                 │  │           Module              │  │
                 │  └───────────────────────────────┘  │
                 │                                     │
                 │  ┌───────────────────────────────┐  │
                 │  │     Document Processing       │  │
                 │  │           Module              │  │
                 │  └───────────────────────────────┘  │
                 │                                     │
                 │  ┌───────────────────────────────┐  │
                 │  │       File Operations         │  │
                 │  │           Module              │  │
                 │  └───────────────────────────────┘  │
                 │                                     │
                 │  ┌───────────────────────────────┐  │
                 │  │    Shared Infrastructure      │  │
                 │  └───────────────────────────────┘  │
                 └──────────────────┬──────────────────┘
                                    │
                                    ▼
                         ┌──────────────────────┐
                         │      SQL Server      │
                         │      Database        │
                         └──────────────────────┘

                         ┌──────────────────────┐
                         │  Separate Migration  │
                         │       Assembly       │
                         └──────────────────────┘
````

---

# 🧩 Modular Monolith

Instead of building the application as one large tightly-coupled project,
features are organized into independent modules inside a single deployable
application.

```text
                    FileProcess Application
                            │
          ┌─────────────────┼─────────────────┐
          │                 │                 │
          ▼                 ▼                 ▼
   Image Processing   Document Processing   File Operations
       Module              Module              Module
          │                 │                 │
          └─────────────────┼─────────────────┘
                            │
                            ▼
                  Shared Infrastructure
                            │
                            ▼
                       SQL Server
```

### Key architectural principles

* **Modular Monolith**
* **Feature-Based Modules**
* **Separation of Concerns**
* **Dependency Injection**
* **Shared Infrastructure**
* **Dedicated Migration Assembly**
* **Asynchronous Processing**
* **Centralized Exception Handling**

---

# 📂 Project Structure

```text
FileProcess/
│
├── Client/
│   └── FileProcessWeb/
│       ├── src/
│       ├── app/
│       └── ...
│
├── Modules/
│   │
│   ├── ImageProcessing/
│   │   ├── Application/
│   │   ├── Domain/
│   │   ├── Infrastructure/
│   │   └── Web/
│   │
│   ├── DocumentProcessing/
│   │   ├── Application/
│   │   ├── Domain/
│   │   ├── Infrastructure/
│   │   └── Web/
│   │
│   └── FileOperations/
│       ├── Application/
│       ├── Domain/
│       ├── Infrastructure/
│       └── Web/
│
├── Shared/
│   └── Infrastructure/
│
├── Infrastructure/
│   └── Migration/
│
└── Server/
    └── FileProcessServer/
```

> The folder names above represent the architectural organization.
> Adjust the names if your repository uses different project names.

---

# 🔄 Application Flow

```text
┌──────────────┐
│    User      │
└──────┬───────┘
       │
       ▼
┌──────────────┐
│  Angular UI  │
└──────┬───────┘
       │
       │ HTTP Request
       ▼
┌─────────────────────┐
│ ASP.NET Core API    │
└──────────┬──────────┘
           │
           ▼
┌─────────────────────┐
│ Feature-Based       │
│ Module              │
└──────────┬──────────┘
           │
           ▼
┌─────────────────────┐
│ File Processing     │
│ / Conversion        │
└──────────┬──────────┘
           │
           ▼
┌─────────────────────┐
│ Processed File      │
└──────────┬──────────┘
           │
           ▼
┌─────────────────────┐
│ Angular UI / Client  │
└─────────────────────┘
```

---

# 🖼️ Image Processing

The application provides multiple image-processing operations.

| Operation         | Supported |
| ----------------- | :-------: |
| Compression       |     ✅     |
| Resize            |     ✅     |
| Crop              |     ✅     |
| JPG               |     ✅     |
| PNG               |     ✅     |
| WebP              |     ✅     |
| Format Conversion |     ✅     |

### Example

```text
             Original Image
                    │
                    ▼
             ┌──────────────┐
             │ Image Module │
             └──────┬───────┘
                    │
        ┌───────────┼───────────┐
        ▼           ▼           ▼
    Compress      Resize       Crop
        │           │           │
        └───────────┼───────────┘
                    │
                    ▼
             Processed Image
```

---

# 📄 Document Processing

Document-related functionality includes:

### Image → PDF

```text
Image
  │
  ▼
Upload
  │
  ▼
Document Processing Module
  │
  ▼
PDF Generation
  │
  ▼
PDF File
```

### PDF → Image

```text
PDF
 │
 ▼
Upload
 │
 ▼
Document Processing Module
 │
 ▼
PDF Page Processing
 │
 ▼
Image Output
```

---

# 📦 ZIP / Unzip

The application also provides file compression and extraction utilities.

```text
Multiple Files
      │
      ▼
 File Operations
      │
      ▼
    ZIP File
```

and

```text
   ZIP File
      │
      ▼
 File Operations
      │
      ▼
Extracted Files
```

---

# ⚡ Asynchronous File Processing

File processing can involve CPU-intensive operations and file I/O.

The backend uses asynchronous programming where appropriate to avoid
unnecessary request-thread blocking.

```csharp
public async Task<IActionResult> ProcessFileAsync(IFormFile file)
{
    // Validate request

    // Process file asynchronously

    // Return processed file
}
```

This approach helps keep the API responsive during file-processing operations.

---

# 🛡️ Exception Handling

Application-level errors and file-processing failures are handled through
centralized exception handling.

```text
              HTTP Request
                   │
                   ▼
             API Endpoint
                   │
                   ▼
             Feature Module
                   │
                   ▼
            Business Logic
                   │
          ┌────────┴────────┐
          │                 │
       Success           Exception
          │                 │
          ▼                 ▼
       Response       Global Handler
                            │
                            ▼
                    Consistent Error
                       Response
```

---

# 🗃️ Database & Migration Architecture

The application uses:

* SQL Server
* Entity Framework Core
* Separate Migration Project
* Shared Infrastructure

The EF Core migration assembly is separated from the main application.

```text
             Application
                  │
                  ▼
              DbContext
                  │
                  ▼
        ┌───────────────────┐
        │ Migration Project │
        └─────────┬─────────┘
                  │
                  ▼
             SQL Server
```

This keeps migration-related concerns isolated from the main application
runtime.

---

# 🧰 Tech Stack

## Frontend

| Technology   | Purpose                 |
| ------------ | ----------------------- |
| Angular 21   | Frontend application    |
| TypeScript   | Application programming |
| Tailwind CSS | UI styling              |

## Backend

| Technology            | Purpose                 |
| --------------------- | ----------------------- |
| C#                    | Backend programming     |
| .NET 10               | Runtime                 |
| ASP.NET Core Web API  | REST API                |
| Entity Framework Core | Data access             |
| Dependency Injection  | Dependency management   |
| Async/Await           | Asynchronous processing |

## Database & Infrastructure

| Technology                  | Purpose                        |
| --------------------------- | ------------------------------ |
| SQL Server                  | Relational database            |
| EF Core Migrations          | Database schema management     |
| Separate Migration Assembly | Migration isolation            |
| Shared Infrastructure       | Common infrastructure services |

## Architecture

```text
Modular Monolith
        +
Feature-Based Modules
        +
Shared Infrastructure
        +
Separate Migration Assembly
```

---

# 📡 API Capabilities

The backend exposes RESTful APIs for file-processing operations.

Example endpoint organization:

```text
/api/image/compress
/api/image/resize
/api/image/crop
/api/image/convert

/api/file/zip
/api/file/unzip

/api/document/image-to-pdf
/api/document/pdf-to-image
```

> Endpoint names are representative. Use the actual routes implemented in
> the repository if they differ.

---

# 🔐 API Design

The backend follows RESTful API principles and separates responsibilities
between:

```text
Controller / Endpoint
        │
        ▼
Application Layer
        │
        ▼
Feature Module
        │
        ▼
Infrastructure
        │
        ▼
Database / File System
```

---

# 🛠️ Getting Started

## Prerequisites

Make sure you have the following installed:

* [.NET 10 SDK](https://dotnet.microsoft.com/download)
* [Node.js](https://nodejs.org/)
* [Angular CLI](https://angular.dev/tools/cli)
* SQL Server / SQL Server LocalDB
* Git

---

## 1. Clone Repository

```bash
git clone <repository-url>
```

```bash
cd FileProcess
```

---

## 2. Configure Database

Update your connection string in the application configuration.

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=FileProcessing;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```

---

## 3. Apply EF Core Migrations

If the repository contains a dedicated migration project, execute the
migration using that project according to the repository configuration.

Example:

```bash
dotnet ef database update
```

---

## 4. Run Backend

```bash
dotnet run
```

---

## 5. Run Angular Application

Navigate to the frontend project:

```bash
cd Client/FileProcessWeb
```

Install dependencies:

```bash
npm install
```

Start Angular:

```bash
ng serve
```

Open:

```text
http://localhost:4200
```

---

# 🎯 Project Objectives

This project was built to demonstrate practical experience with:

* Full-stack application development
* ASP.NET Core Web API
* Angular
* C#
* Entity Framework Core
* SQL Server
* RESTful API design
* Asynchronous programming
* File and document processing
* Image conversion
* PDF processing
* ZIP / Unzip operations
* Modular Monolith architecture
* Feature-based module organization
* Shared infrastructure
* Separate EF Core migration assembly
* Centralized exception handling
* Dependency Injection

---

# 📌 Key Implementation Highlights

### Backend

* Built RESTful APIs using ASP.NET Core Web API.
* Implemented asynchronous file-processing operations.
* Added centralized exception handling.
* Organized backend functionality into feature-based modules.
* Applied Modular Monolith architecture.
* Used dependency injection for module registration and services.

### File Processing

* Implemented image compression.
* Implemented image resizing.
* Implemented image cropping.
* Added JPG, PNG, and WebP format conversion.
* Implemented ZIP and Unzip operations.
* Added Image-to-PDF conversion.
* Added PDF-to-Image conversion.

### Infrastructure

* Integrated SQL Server using Entity Framework Core.
* Separated EF Core migrations into a dedicated migration assembly.
* Created shared infrastructure for common application concerns.

---

# 📊 Architecture Summary

```text
                         FILEPROCESS
                              │
                              ▼
                       ┌──────────────┐
                       │  Angular UI  │
                       └──────┬───────┘
                              │
                              ▼
                    ┌────────────────────┐
                    │ ASP.NET Core API   │
                    └─────────┬──────────┘
                              │
              ┌───────────────┼───────────────┐
              │               │               │
              ▼               ▼               ▼
       Image Module    Document Module   File Module
              │               │               │
              └───────────────┼───────────────┘
                              │
                              ▼
                    Shared Infrastructure
                              │
                              ▼
                         SQL Server
                              ▲
                              │
                    Separate Migration
                         Assembly
```

---

# 👨‍💻 Author

**Montu Kharb**

Full Stack .NET Developer

**Technologies:**
C# • ASP.NET Core • Angular • SQL Server • Entity Framework Core

---

<p align="center">
  Built with ❤️ using ASP.NET Core & Angular
</p>
```
