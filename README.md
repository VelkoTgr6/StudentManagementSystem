Student Management System

This is a project targeting .NET 8. The project is designed to manage student information and includes features such as authentication, email notifications, and database management.

Features
•	Student Management: Add, update, delete, and view student information.
•	Authentication: Google authentication integration.
•	Email Notifications: Send email notifications using SMTP.
•	Database Management: Uses SQL Server for data storage.

Setup Instructions
1.	Clone the repository:
2.	Set up the database: Ensure you have SQL Server installed and running. Update the connection string in secrets.json if necessary.
3.	Configure user secrets: The project uses user secrets to store sensitive information. Ensure the secrets.json file is correctly configured.
4.	Restore dependencies
5.	Run the application

Usage
•	Manage student information through the provided interface.

Dependencies
•	MailKit (4.8.0)
•	Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore (8.0.10)
•	Microsoft.AspNetCore.Identity.EntityFrameworkCore (8.0.11)
•	Microsoft.AspNetCore.Identity.UI (8.0.11)
•	Microsoft.EntityFrameworkCore.Sqlite (8.0.11)
•	Microsoft.EntityFrameworkCore.SqlServer (8.0.11)
•	Microsoft.EntityFrameworkCore.Tools (8.0.11)
•	Microsoft.VisualStudio.Web.CodeGeneration.Design (8.0.7)

Project Structure
•	StudentManagementSystem: Main Blazor project.
•	StudentManagementSystem.Core: Core project containing business logic and models.

License
This project is licensed under the MIT License. See the LICENSE file for more details.
---
This README provides an overview of the project, setup instructions, usage details, and information about dependencies and project structure.


   
