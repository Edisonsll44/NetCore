using ClinicMedicalAppointments.Application.Commands.User;
using FluentValidation;

namespace ClinicMedicalAppointments.Application.Validators;

public class UserCommandValidator: AbstractValidator<CreateUserCommand>
{ 
    public UserCommandValidator()
    {
        RuleFor(t => t.Nombres)
            .NotEmpty();
        RuleFor(t => t.Apellidos)
            .NotEmpty();
        RuleFor(t => t.Clave)
            .NotEmpty();    
        RuleFor(t => t.Genero)
            .NotEmpty();    
        RuleFor(t => t.Celular)
                .NotEmpty();
        RuleFor(t => t.Correo)
            .NotEmpty()
            .EmailAddress();
        RuleFor(t => t.Identificacion)
            .NotEmpty();
        RuleFor(t => t.RolId)
            .NotEmpty();
        
    }
}