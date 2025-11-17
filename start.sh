#!/bin/bash
set -e

# Start PostgreSQL
service postgresql start

# Create DB if missing
sudo -u postgres psql -c "CREATE DATABASE IF NOT EXISTS ${POSTGRES_DB};"

# Start ASP.NET app
exec dotnet StudentManagementSystem.dll
