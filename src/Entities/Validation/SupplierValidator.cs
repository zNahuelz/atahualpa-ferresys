using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atahualpa_ferresys.Entities.Validation
{
    public class SupplierValidator: AbstractValidator<Supplier>
    {
        public SupplierValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().MinimumLength(2).MaximumLength(150).WithName("Nombre");
            RuleFor(x => x.Ruc).NotEmpty().NotNull().MinimumLength(11).MaximumLength(11).WithName("RUC");
            RuleFor(x => x.Address).NotEmpty().NotNull().MaximumLength(100).WithName("Dirección");
            RuleFor(x => x.Phone).NotEmpty().NotNull().MaximumLength(15).WithName("Teléfono");
            RuleFor(x => x.Email).NotEmpty().NotNull().EmailAddress().MaximumLength(50).WithName("E-Mail");
            RuleFor(x => x.Description).MaximumLength(150).WithName("Descripción");
        }
    }
}
