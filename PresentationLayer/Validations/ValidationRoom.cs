using CommonLayer.Entities;
using FluentValidation;

namespace PresentationLayer.Validations
{
    public class ValidationRoom : AbstractValidator<Room>
    {
        public ValidationRoom()
        {
            RuleFor(room => room.Type)
                .NotEmpty().WithMessage("El campo tipo es requerido")
                .Length(3, 50).WithMessage("El campo tipo debe tener entre 3 y 50 caracteres")
                .Matches(@"^[a-zA-Z\s]*$").WithMessage("El campo tipo solo puede contener letras y espacios");

            RuleFor(room => room.PriceNight)
                .NotEmpty().WithMessage("El campo precio es requerido")
                .GreaterThan(0).WithMessage("El campo precio debe ser positivo");

            RuleFor(room => room.Characteristic)
                .NotEmpty().WithMessage("El campo característica es requerido")
                .Length(3, 100).WithMessage("El campo característica debe tener entre 3 y 100 caracteres");
                

        }
    }
}
