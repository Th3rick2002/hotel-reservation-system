﻿using CommonLayer.Entities;
using FluentValidation;

namespace PresentationLayer.Validations
{
    public class ValidationClient : AbstractValidator<Users>
    {
        public ValidationClient()
        {
            RuleFor(user => user.User)
                .NotEmpty().WithMessage("El campo usuario es requerido")
                .Length(5, 50).WithMessage("El campo usuario debe tener entre 5 y 50 caracteres")
                .Matches(@"^[a-zA-Z0-9_]*$").WithMessage("El campo usuario solo puede contener letras, números y guiones bajos");

            RuleFor(user => user.Password)
                .NotEmpty().WithMessage("El campo clave es requerido")
                .Length(8, 50).WithMessage("El campo clave debe tener entre 8 y 50 caracteres")
                .Matches("[A-Z]").WithMessage("La clave debe tener al menos una letra mayúscula")
                .Matches("[0-9]").WithMessage("La clave debe tener al menos un número");

            RuleFor(user => user.Name)
                .NotEmpty().WithMessage("El campo nombre es requerido")
                .Length(3, 50).WithMessage("El campo nombre debe tener entre 3 y 50 caracteres")
                .Matches(@"^[a-zA-Z\s]*$").WithMessage("El campo nombre solo puede contener letras y espacios");

            RuleFor(user => user.LastName)
                .NotEmpty().WithMessage("El campo apellido es requerido")
                .Length(3, 50).WithMessage("El campo apellido debe tener entre 3 y 50 caracteres")
                .Matches(@"^[a-zA-Z\s]*$").WithMessage("El campo apellido solo puede contener letras y espacios");

            RuleFor(user => user.Email)
                .NotEmpty().WithMessage("El campo email es requerido")
                .EmailAddress().WithMessage("El campo email no es una dirección válida");

            RuleFor(user => user.Telephone)
                .NotEmpty().WithMessage("El número de celular es requerido.")
                .GreaterThan(0).WithMessage("El número de celular debe ser positivo.");

        }
    }
}
