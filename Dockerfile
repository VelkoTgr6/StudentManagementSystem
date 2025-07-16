# -------- Build Stage --------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution and project files
COPY StudentManagementSystem.sln ./
COPY StudentManagementSystem/*.csproj ./StudentManagementSystem/
COPY StudentManagementSystem.Core/*.csproj ./StudentManagementSystem.Core/
COPY StudentManagementSystem.Infrastructure/*.csproj ./StudentManagementSystem.Infrastructure/

# Restore dependencies for the main project (this will restore all referenced projects)
RUN dotnet restore StudentManagementSystem/StudentManagementSystem.csproj

# Copy the rest of the source code
COPY . .

# Publish the app
RUN dotnet publish StudentManagementSystem/StudentManagementSystem.csproj -c Release -o /app/publish

# -------- Runtime Stage --------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

# Set environment variables for ASP.NET Core
ENV ASPNETCORE_URLS=http://+:10000
ENV ASPNETCORE_ENVIRONMENT=Production

EXPOSE 10000

ENTRYPOINT ["dotnet", "StudentManagementSystem.dll"]