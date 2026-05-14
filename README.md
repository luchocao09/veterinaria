# API Veterinaria

API desarrollada en C# con ASP.NET Core Web API y PostgreSQL.

Permite administrar:
- Clientes
- Mascotas
- Veterinarios

Incluye operaciones CRUD:
- Crear
- Consultar
- Modificar
- Eliminar

La base de datos se conecta mediante Entity Framework Core y los endpoints se prueban desde Swagger.

# Qué instalar

## Visual Studio
Instalar Visual Studio con la carga de trabajo:

- ASP.NET y desarrollo web

## PostgreSQL
Instalar PostgreSQL y PgAdmin.

## Paquetes NuGet

Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL
