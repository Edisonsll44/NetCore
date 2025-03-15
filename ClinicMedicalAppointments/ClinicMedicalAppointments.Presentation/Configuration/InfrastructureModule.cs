using System.Reflection;
using Autofac;
using ClinicMedicalAppointments.Application.Commands.User;
using ClinicMedicalAppointments.Infraestructure.Repository;
using ClinicMedicalAppointments.Infraestructure.Repository.Generic;
using MediatR;
using Module = Autofac.Module;

namespace ClinicMedicalAppointments.Presentation.Configuration;

public class InfrastructureModule: Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly)
            .AsImplementedInterfaces();
        //Register all the Command classes (they implement IRequestHandler) in assembly holding the Commands
        
        builder.RegisterAssemblyTypes(typeof(CreateUserCommand).GetTypeInfo().Assembly)
            .AsClosedTypesOf(typeof(IRequestHandler<,>));

        builder.RegisterType<Mediator>()
            .As<IMediator>()
            .InstancePerLifetimeScope();

        
        builder.RegisterGeneric(typeof(GenericRepository<>))
            .As(typeof(IGenericRepository<>))
            .InstancePerLifetimeScope();
        
        builder.RegisterType<UserRepository>()
            .As<IUserRepository>();
    }
}