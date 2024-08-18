using FluentValidation;

namespace FluentValidationDemo.PolymorphicValidatiors
{
	public class AddressValidator : AbstractValidator<Address>
	{
		public AddressValidator()
		{
			RuleFor(address => address.Postcode).NotNull();
			RuleFor(address => address.Country).NotNull();
			RuleFor(address => address.Town).NotNull();
			RuleFor(address => address.Line1).NotNull();
		}
	}
}