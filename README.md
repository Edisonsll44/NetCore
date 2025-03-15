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
   
