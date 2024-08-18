using FluentValidation;

namespace FluentValidationDemo.PolymorphicValidatiors
{
	public class OrganisationValidator : AbstractValidator<Organisation>
	{
		public OrganisationValidator()
		{
			RuleFor(x => x.Name).NotNull();
			RuleFor(x => x.Email).NotNull();
			RuleFor(x => x.Headquarters).SetValidator(new AddressValidator());
		}
	}
}