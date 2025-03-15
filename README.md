El royecto esta creado en Net core V 9.0
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

## 🔧 Configuración de Librerías

### 📌 **Swagger**
Se ha configurado **Swagger** para exponer la documentación de la API.

📄 **Configuración en `Program.cs`**
```csharp
// Agregar Swagger
builder.Services.AddOpenApi();

var app = builder.Build();

// Activar Swagger en la aplicación
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Clinic Medical Appointments API v1");
    options.RoutePrefix = "swagger";
});

// Habilitar Swagger en modo desarrollo
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
```

Para crear una migracion se debe.

- Ubicar en la carpeta raiz del proyecto
- Ejecutar el siguiente comando:
  -    dotnet ef migrations add UpdateUserEntity \                                         
    --project ClinicMedicalAppointments.Infraestructure \
    --startup-project ClinicMedicalAppointments.API



- Para actualizar la BDD ejecutar, esto desde la raiz del proyecto:
  -   dotnet ef database update \                                                         
    --project ClinicMedicalAppointments.Infraestructure \
    --startup-project ClinicMedicalAppointments.API
   
