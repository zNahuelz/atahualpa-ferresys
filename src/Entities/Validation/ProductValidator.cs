using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace atahualpa_ferresys.Entities.Validation
{
    public class ProductValidator: AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().MinimumLength(2).MaximumLength(150);
            RuleFor(x => x.Description).MaximumLength(255);
            RuleFor(x => x.BuyPrice).GreaterThanOrEqualTo(0.10);
            RuleFor(x => x.SellPrice).GreaterThanOrEqualTo(0.50);
            RuleFor(x => x.Stock).GreaterThanOrEqualTo(1);
            RuleFor(x => x.Visible).NotNull();
            RuleFor(x => x.SupplierId).NotNull().NotEmpty().GreaterThanOrEqualTo(1);
            RuleFor(x => x.UnitTypeId).NotNull().NotEmpty().GreaterThanOrEqualTo(1);
        }
    }
}
