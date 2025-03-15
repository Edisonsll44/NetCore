using Autofac;
using Autofac.Extensions.DependencyInjection;
using ClinicMedicalAppointments.Infraestructure;
using ClinicMedicalAppointments.Presentation.Configuration;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configurar DbContext con PostgreSQL
builder.Services.AddDbContext<ClinicaVeterinariaDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("ClinicalMedicalDb"));
});

// Configurar Autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.RegisterModule(new InfrastructureModule());
    containerBuilder.RegisterAssemblyTypes(typeof(Program).Assembly)
        .Where(t => t.Name.EndsWith("Controller"))
        .AsSelf();
});

// Configurar Swagger (usando AddSwaggerGen)
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Clinic Medical Appointments API",
        Version = "v1",
        Description = "API para gestionar usuarios y citas médicas.",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Soporte",
            Email = "soporte@clinicamedica.com",
            Url = new Uri("https://clinicamedica.com"),
        }
    });
});

// Agregar servicios para controladores
builder.Services.AddControllers();

// Construir la aplicación
var app = builder.Build();

// Configurar middleware para Swagger
app.UseRouting();
app.UseSwagger();  // Activa Swagger
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Clinic Medical Appointments API v1");
    options.RoutePrefix = "swagger";  // Configura el prefijo de la UI de Swagger
});

// Condición para entornos de desarrollo (solo mostrar Swagger UI en desarrollo)
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();  // Muestra la página de error detallada en desarrollo
}

app.UseAuthorization();

// Mapear controladores
app.MapControllers();

// Ejecutar la aplicación
app.Run();
