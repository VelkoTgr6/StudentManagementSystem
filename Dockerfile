# -------- Build Stage --------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution and project files
COPY StudentManagementSystem.sln ./
COPY StudentManagementSystem/*.csproj ./StudentManagementSystem/
COPY StudentManagementSystem.Core/*.csproj ./StudentManagementSystem.Core/
COPY StudentManagementSystem.Infrastructure/*.csproj ./StudentManagementSystem.Infrastructure/

# Restore dependencies
RUN dotnet restore StudentManagementSystem/StudentManagementSystem.csproj

# Copy the rest of the source code
COPY . .

# Publish the app
RUN dotnet publish StudentManagementSystem/StudentManagementSystem.csproj -c Release -o /app/publish

# -------- Runtime Stage --------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Copy app
COPY --from=build /app/publish .

# Environment variables
ENV ASPNETCORE_URLS=http://+:10000
ENV ASPNETCORE_ENVIRONMENT=Production

EXPOSE 10000

# Run the app
ENTRYPOINT ["dotnet", "StudentManagementSystem.dll"]
