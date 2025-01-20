using FluentValidation;


namespace atahualpa_ferresys.Entities.Validation
{
    public class UnitTypeValidator : AbstractValidator<UnitType>
    {
        public UnitTypeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().MinimumLength(2).MaximumLength(100).WithName("Nombre");
        }
    }
}
