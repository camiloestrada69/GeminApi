using FluentValidation;
using GeminApi.Domain.Dtos;

namespace GeminApi.Domain.Validator
{
    public class UsuarioValidator: AbstractValidator<UsuarioCreacionDto>
    {
        public UsuarioValidator()
        {
            RuleFor(x => x.Nombre)
                .NotEmpty()
                .WithMessage("El campo de título es obligatorio")
                .MaximumLength(255)
                .WithMessage("El campo tiene un limite de 255 caracteres");
            RuleFor(x => x.Apellido)
                .NotEmpty()
                .WithMessage("El campo de título es obligatorio")
                .MaximumLength(255)
                .WithMessage("El campo tiene un limite de 255 caracteres");
            RuleFor(x => x.FechaNacimiento)
                .NotEmpty()
                .WithMessage("El campo de título es obligatorio");
            RuleFor(x => x.Telefono)
                .NotEmpty()
                .WithMessage("El campo de título es obligatorio")
                .MaximumLength(15)
                .WithMessage("El campo tiene un limite de 255 caracteres");
            RuleFor(x => x.Telefono)
                .NotEmpty()
                .WithMessage("El campo de título es obligatorio")
                .MaximumLength(255)
                .WithMessage("El campo tiene un limite de 255 caracteres");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("El campo de título es obligatorio")
                .MaximumLength(100)
                .WithMessage("El campo tiene un limite de 255 caracteres");

        }

    }
}
