using ClinicMedicalAppointments.Infraestructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.AddDbContext<ClinicaVeterinariaDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("ClinicalMedical"));
});


builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
