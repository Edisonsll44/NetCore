# 📘 Documentación Técnica

## 📌 Tecnologías Utilizadas
El proyecto está desarrollado en **.NET 9.0** y utiliza las siguientes librerías:

### 🛠 Librerías Instaladas

| 📦 Librería | 🔍 Descripción |
|------------|---------------|
| **Swagger** | Se utiliza para documentar la API de manera interactiva y facilitar las pruebas. |
| **MediatR** | Implementa el patrón Mediator para manejar consultas, comandos y eventos de manera desacoplada. |
| **Entity Framework Core para PostgreSQL** | Proporciona el ORM para interactuar con la base de datos PostgreSQL. |
| **FluentValidation** | Permite la validación de datos de entrada en los DTOs y modelos de dominio. |
| **Autofac** | Framework de inversión de control (IoC) y contenedor de dependencias para gestionar la inyección de dependencias. |

---

## 🛠 Gestión de Migraciones con Entity Framework Core

### 📌 **1️⃣ Crear una Migración**
Para crear una nueva migración, seguir estos pasos:

1. Ubicarse en la carpeta raíz del proyecto.
2. Ejecutar el siguiente comando:
   ```sh
   dotnet ef migrations add UpdateUserEntity \
       --project ClinicMedicalAppointments.Infraestructure \
       --startup-project ClinicMedicalAppointments.API
   ```

   ### 📌 **1️⃣ Ejecutar una Migración o actualizar la BDD**
Para crear actualizar la BDD, seguir estos pasos:

1. Ubicarse en la carpeta raíz del proyecto.
2. Ejecutar el siguiente comando:
   ```sh
    dotnet ef database update \                                                         
    --project ClinicMedicalAppointments.Infraestructure \
    --startup-project ClinicMedicalAppointments.API 
