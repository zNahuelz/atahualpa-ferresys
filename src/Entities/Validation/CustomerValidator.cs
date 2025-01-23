using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atahualpa_ferresys.Entities.Validation
{
    public class CustomerValidator: AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().MinimumLength(1).MaximumLength(30).WithName("Nombre");
            RuleFor(x => x.Surname).NotEmpty().NotNull().MinimumLength(1).MaximumLength(30).WithName("Apellido");
            RuleFor(x => x.Dni).NotEmpty().NotNull().Matches(@"^\d{8,9}$").WithName("DNI");
            RuleFor(x => x.Address).MaximumLength(100).WithName("Dirección");
            RuleFor(x => x.Phone).Matches(@"^[1-9]\d{8}$").WithName("Teléfono");
            RuleFor(x => x.Email).EmailAddress().MaximumLength(50).WithName("E-Mail");
        }
    }
}
