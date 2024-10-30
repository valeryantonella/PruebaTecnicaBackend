# Client Management API (Backend)

Bienvenido al repositorio del backend de la API de gestión de clientes. Esta API permite realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre los datos de clientes, utilizando ASP.NET Core y Entity Framework.

## Tabla de Contenidos

- [Características](#características)
- [Tecnologías](#tecnologías)
- [Requisitos](#requisitos)
- [Instalación](#instalación)
- [Ejecución](#ejecución)

## Características

- **CRUD de Clientes**: Permite agregar, listar, editar y eliminar clientes.
- **Autenticación y Autorización**: Soporte para usuarios y roles.
- **Manejo de Errores**: Respuestas claras en caso de errores.
- **Documentación API**: Generación automática de documentación con Swagger.

## Tecnologías

- **ASP.NET Core**: Framework para construir aplicaciones web y APIs.
- **Entity Framework Core**: ORM para trabajar con bases de datos.
- **SQL Server**: Base de datos utilizada para almacenar la información de los clientes.
- **Swagger**: Herramienta para documentar y probar APIs.

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