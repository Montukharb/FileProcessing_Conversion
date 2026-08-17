# FileProcessing_Conversion
A modular monolith-based full-stack file processing platform with ASP.NET Core Web API, Angular, SQL Server, asynchronous file processing, image/PDF conversion, and ZIP/Unzip utilities.
A full-stack file processing and conversion platform built with
ASP.NET Core Web API, Angular, and a Modular Monolith
architecture.







✨ Overview

FileProcess & Conversion is a full-stack application for image and
document processing. It provides a set of practical file utilities
through secure RESTful APIs and a modern web interface.

The project is designed around a Modular Monolith architecture, with
functionality organized into feature-based modules while keeping
shared infrastructure and database migrations separated from the
application modules.

What it can do

🖼️ Image compression

📐 Image resizing

✂️ Image cropping

🔄 Image format conversion

📦 ZIP / Unzip operations

📄 Image → PDF conversion

🖼️ PDF → Image conversion

⚡ Asynchronous file processing

🛡️ Centralized exception handling

🔐 Secure RESTful APIs

🧩 Feature-based modular architecture

🚀 Features

Feature                             Description

🗜️ Image Compression            Reduce image size while maintaining
practical visual quality

📐 Image Resizing               Resize images using configurable
dimensions

✂️ Image Cropping               Crop images according to required
dimensions

🔄 Format Conversion            Convert between JPG, PNG, and WebP

📦 ZIP / Unzip                  Compress multiple files and extract
ZIP archives

🖼️ Image → PDF                  Convert images into PDF documents

📄 PDF → Image                  Convert PDF pages into image files

⚡ Async Processing             Process file operations
asynchronously to improve API
responsiveness

🛡️ Exception Handling           Centralized handling of application
and processing errors

🏗️ Architecture

The application follows a Modular Monolith + Feature-Based Module
approach.

┌──────────────────────────────────────────────────────────────┐
│                         Angular UI                           │
│                    Presentation Layer                        │
└─────────────────────────────┬────────────────────────────────┘
                              │ HTTP / REST
                              ▼
┌──────────────────────────────────────────────────────────────┐
│                     ASP.NET Core API                         │
│                                                              │
│   ┌──────────────────┐  ┌──────────────────┐                │
│   │ Image Processing │  │ Document Process │                │
│   │     Module       │  │      Module      │                │
│   └──────────────────┘  └──────────────────┘                │
│                                                              │
│   ┌──────────────────┐  ┌──────────────────┐                │
│   │ File Operations  │  │ Shared Services  │                │
│   │     Module       │  │ / Infrastructure │                │
│   └──────────────────┘  └──────────────────┘                │
└─────────────────────────────┬────────────────────────────────┘
                              │
                              ▼
┌──────────────────────────────────────────────────────────────┐
│                     Persistence Layer                        │
│                         SQL Server                           │
└──────────────────────────────────────────────────────────────┘

                 ┌──────────────────────────┐
                 │ Separate Migration       │
                 │ Assembly / Project       │
                 └──────────────────────────┘

Architectural principles

Modular Monolith --- one deployable application with clearly
isolated business modules.

Feature-Based Modules --- functionality is grouped by feature
rather than creating one large shared layer.

Shared Infrastructure --- common infrastructure concerns are
separated and reusable.

Separate Migration Assembly --- EF Core migrations are
maintained in a dedicated migration project.

Dependency Injection --- dependencies are registered through
module composition/extension methods.

Separation of Concerns --- API, application logic,
infrastructure, persistence, and modules have defined
responsibilities.

📂 Project Structure

FileProcess/
│
├── Client/
│   └── FileProcessWeb/
│       ├── src/
│       ├── app/
│       └── ...
│
├── Modules/
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

Note: The structure above represents the architectural
organization. Rename folders to match the exact project names in the
repository.

🔄 File Processing Flow

User
 │
 ▼
Angular UI
 │
 │ HTTP Request + File
 ▼
ASP.NET Core API
 │
 ▼
Feature Module
 │
 ├── Validate Request
 │
 ├── Process File
 │
 ├── Perform Conversion
 │
 └── Return Result
 │
 ▼
Processed File
 │
 ▼
Angular UI

🧰 Tech Stack

Frontend

Angular 21

TypeScript

HTML / CSS

Tailwind CSS

Backend

ASP.NET Core Web API

C#

.NET 10

RESTful APIs

Dependency Injection

Async / Await

Exception Handling

Data & Infrastructure

SQL Server

Entity Framework Core

EF Core Migrations

Separate Migration Assembly

Shared Infrastructure

Architecture

Modular Monolith

Feature-Based Modules

Separation of Concerns

Dependency Injection

Clean module boundaries

📡 API Capabilities

Typical API capabilities include:

POST /api/image/compress
POST /api/image/resize
POST /api/image/crop
POST /api/image/convert

POST /api/file/zip
POST /api/file/unzip

POST /api/document/image-to-pdf
POST /api/document/pdf-to-image

Endpoint names may differ from the actual implementation.

⚡ Asynchronous Processing

File operations can be expensive because they involve:

File I/O

Image decoding and encoding

PDF processing

Compression

Format conversion

The backend therefore uses asynchronous programming where appropriate to
avoid unnecessarily blocking request threads.

public async Task<IActionResult> ProcessFileAsync(IFormFile file)
{
    // Validate request
    // Process file asynchronously
    // Return processed file
}

🛡️ Error Handling

The API uses centralized exception handling so that processing errors
can be converted into consistent HTTP responses.

Request
   │
   ▼
Controller / Endpoint
   │
   ▼
Application / Module
   │
   ├── Success ──────────────► 200 / 201
   │
   └── Exception
          │
          ▼
   Global Exception Handler
          │
          ▼
   Consistent Error Response

🗃️ Database & Migrations

The application uses SQL Server with Entity Framework Core.

Database migrations are intentionally maintained in a separate
migration assembly/project rather than coupling migration execution
directly to the main API project.

Application / Modules
          │
          ▼
      DbContext
          │
          ▼
   Migration Project
          │
          ▼
      SQL Server

This keeps database migration concerns isolated from the main
application runtime.

🔧 Getting Started

Prerequisites

Make sure the following are installed:

.NET 10 SDK

Node.js

Angular CLI

SQL Server / SQL Server LocalDB

Git

Clone the repository

git clone <repository-url>
cd FileProcess

Configure the database

Update the connection string in the application's configuration:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=FileProcessing;Trusted_Connection=True;TrustServerCertificate=True"
  }
}

Apply migrations

If the repository contains a dedicated migration project, run migrations
using that project according to its configured startup/dependency
structure.

Example:

dotnet ef database update

Run the backend

dotnet run

Run the Angular application

npm install
ng serve

Then open the Angular application in your browser.

🧪 Example Use Cases

Compress an Image

Upload Image
     ↓
Select Compression Options
     ↓
API Processes Image
     ↓
Compressed Image
     ↓
Download Result

Convert JPG → WebP

JPG
 ↓
Upload
 ↓
Image Processing Module
 ↓
Format Conversion
 ↓
WebP

Image → PDF

Image
 ↓
Upload
 ↓
Document Processing Module
 ↓
PDF Generation
 ↓
PDF File

🎯 Project Goals

The project was built to demonstrate practical implementation of:

Full-stack application development

File and document processing

REST API development

Asynchronous programming

Modular Monolith architecture

Feature-based application organization

Entity Framework Core

SQL Server integration

Centralized exception handling

Separation of infrastructure and migrations

Frontend-to-backend API integration

📌 Architecture Highlights

                    FILEPROCESS
                        │
        ┌───────────────┼────────────────┐
        │               │                │
        ▼               ▼                ▼
   Angular UI      ASP.NET Core      SQL Server
                        │
                 Modular Monolith
                        │
        ┌───────────────┼────────────────┐
        ▼               ▼                ▼
   Image Module    Document Module   File Module
        │               │                │
        └───────────────┼────────────────┘
                        ▼
                Shared Infrastructure
                        │
                        ▼
              Separate Migration Project

📈 What I Implemented

Built a full-stack image and document processing application.

Implemented image compression, resizing, cropping, and format
conversion.

Added JPG, PNG, and WebP conversion support.

Implemented ZIP and Unzip file operations.

Added Image-to-PDF and PDF-to-Image processing.

Developed RESTful APIs using ASP.NET Core Web API.

Used asynchronous file processing for I/O-heavy operations.

Implemented centralized exception handling.

Organized the backend using a Modular Monolith architecture.

Structured functionality into feature-based modules.

Separated shared infrastructure from individual modules.

Maintained EF Core migrations in a dedicated migration assembly.

👨‍💻 Author

Montu Kharb

Full Stack .NET Developer
ASP.NET Core • C# • Angular • SQL Server • Entity Framework Core

⭐ If you find this project useful

Consider giving the repository a ⭐ and exploring the implementation.
