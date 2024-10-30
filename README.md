# Client Management API (Backend)

Este repositorio contiene la implementacion del backend de la API del ejercicio de la prueba técnica para gestionar clientes y servicios. Esta API permite realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre los datos de clientes y servicios, utilizando ASP.NET Core y Entity Framework.

## Tabla de Contenidos

- [Características](#características)
- [Tecnologías](#tecnologías)
- [Requisitos](#requisitos)
- [Instalación](#instalación)
- [Ejecución](#ejecución)

## Características

- **CRUD de clientes/servicios**: contiene un controlador que permite agregar, listar, editar y eliminar clientes/servicios.
- **Documentación API**: permite generar documentación con Swagger de manera automática.

## Tecnologías

- ASP.NET Core
- Entity Framework Core
- SQL Server
- Swagger

## Requisitos

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet)
- SQL Server

## Instalación

**1. Clona este repositorio:**

   ```bash
   git clone https://github.com/valeryantonella/PruebaTecnicaBackend
   ```

**2. Restaurar paquetes NuGet:**

```bash
dotnet restore
```

**3. Crear la base de datos (si es necesario):**

> [!IMPORTANT]  
> Ejecuta las migraciones para crear la base de datos.

```bash
dotnet ef migrations add InitialCreate
```

```bash
dotnet ef database update
```

## Ejecución
Para iniciar la API, ejecuta:

```bash
dotnet run
```

La API estará disponible en http://localhost:7218.