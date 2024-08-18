using FluentValidation;

namespace FluentValidationDemo.ReUsingValidators
{
	public class AddressValidator : AbstractValidator<Address>
	{
		public AddressValidator()
		{
			RuleFor(address => address.Country).NotNull();
			RuleFor(address => address.City).NotNull();
		}
	}
}