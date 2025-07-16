# Student Management System

A comprehensive web-based Student Management System built with ASP.NET Core 8.0, featuring role-based access control for Administrators, Teachers, and Students.

## 🌐 Live Demo

**Try it now!** You can test the application with the live demo deployed on Render:

**Demo URL**: https://student-management-system-bons.onrender.com

### Demo Credentials

#### Student
- **Email**: `ivan414@gmail.com`
- **Password**: `Password1!`
- **Access**: View grades, remarks, schedule, academic dashboard

#### Teacher
- **Email**: `stan12@gmail.com`
- **Password**: `Password123`
- **Access**: Grade management, student remarks, assigned classes

#### Administrator
- **Email**: `admin@admin.com`
- **Password**: `Password123`
- **Access**: Full system management, user creation, course management

> **Note**: This is a demo environment. Data may be reset periodically. Please do not enter any sensitive or personal information.

### Demo Features to Test
- **Admin Panel**: Create new users, manage courses and classes
- **Teacher Dashboard**: Add grades and remarks for students
- **Student Portal**: View academic performance and schedules
- **Role-based Access**: Notice different features available to each role

## 🚀 Features

### Admin Features
- **User Management**: Create, edit, and manage students, teachers, and administrators
- **Course Management**: Create and manage courses with teacher assignments
- **Class Management**: Organize students into classes with course assignments
- **Schedule Management**: Create and manage class schedules
- **Role Management**: Assign and manage user roles
- **Remarks & Grades**: Oversee student remarks and academic performance

### Teacher Features
- **Student Overview**: View assigned students and their details
- **Grade Management**: Add, edit, and delete student grades
- **Remarks System**: Add and manage student remarks by course
- **Class Management**: Manage assigned classes and courses

### Student Features
- **Academic Dashboard**: View grades, remarks, and academic performance
- **Schedule Access**: View class schedules and course information
- **Performance Tracking**: Monitor academic progress and statistics

## 🛠️ Technology Stack

- **Framework**: ASP.NET Core 8.0 MVC
- **Database**: PostgreSQL (Production) / SQL Server (Development)
- **ORM**: Entity Framework Core 8.0
- **Authentication**: ASP.NET Core Identity with Google Authentication
- **Frontend**: Bootstrap 4.5, jQuery
- **Email**: MailKit for SMTP notifications
- **Deployment**: Docker support with Render.com configuration

## 📋 Prerequisites

- .NET 8.0 SDK
- PostgreSQL (Production) or SQL Server (Development)
- Visual Studio 2022 or VS Code
- Docker (optional, for containerized deployment)

## 🚀 Getting Started

### 1. Clone the Repository
```bash
git clone https://github.com/VelkoTgr6/StudentManagementSystem.git
cd StudentManagementSystem
```

### 2. Database Configuration

The application uses a flexible database configuration system that automatically detects the environment and configures the appropriate database connection.

#### Development Environment
For local development, add a connection string to `appsettings.Development.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=StudentManagementDb;Trusted_Connection=true;MultipleActiveResultSets=true"
  }
}
```

#### Production Environment (PostgreSQL)
For production deployment, set the `DATABASE_URL` environment variable:
```bash
export DATABASE_URL="postgresql://username:password@hostname:port/database"
```

The system will automatically parse the DATABASE_URL and construct the appropriate PostgreSQL connection string with SSL requirements.

### 3. Configure User Secrets
```bash
dotnet user-secrets init
dotnet user-secrets set "EmailSettings:SmtpServer" "your-smtp-server"
dotnet user-secrets set "EmailSettings:Port" "587"
dotnet user-secrets set "EmailSettings:Username" "your-email@example.com"
dotnet user-secrets set "EmailSettings:Password" "your-password"
```

### 4. Install Dependencies
```bash
dotnet restore
```

### 5. Apply Database Migrations
```bash
dotnet ef database update
```

### 6. Run the Application
```bash
dotnet run --project StudentManagementSystem
```

The application will be available at `https://localhost:7071`

## � Live Demo

You can try the application with the live demo deployed on Render:

**Demo URL**: https://student-management-system-bons.onrender.com

### Demo Credentials

#### Student
- **Email**: `ivan414@gmail.com`
- **Password**: `Password1!`
- **Access**: View grades, remarks, schedule, academic dashboard

#### Teacher
- **Email**: `stan12@gmail.com`
- **Password**: `Password123`
- **Access**: Grade management, student remarks, assigned classes

#### Administrator
- **Email**: `admin@admin.com`
- **Password**: `Password123`
- **Access**: Full system management, user creation, course management

> **Note**: This is a demo environment. Data may be reset periodically. Please do not enter any sensitive or personal information.

### Demo Features to Test
- **Admin Panel**: Create new users, manage courses and classes
- **Teacher Dashboard**: Add grades and remarks for students
- **Student Portal**: View academic performance and schedules
- **Role-based Access**: Notice different features available to each role