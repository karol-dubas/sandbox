using FluentValidation;

namespace FluentValidationDemo.ReUsingValidators
{
	public class CustomerValidator : AbstractValidator<Customer>
	{
		public CustomerValidator()
		{
			RuleFor(customer => customer.Name).NotNull();
                    
			// You can then re-use the AddressValidator in the CustomerValidator definition:
			RuleFor(customer => customer.Address)
				.NotNull()
				.SetValidator(new AddressValidator());
    
			// Instead of using a child validator, you can define child rules inline, eg:
			//RuleFor(customer => customer.Address.Country).NotEqual("Poland");
    
			// If Address is null, a null check will not be performed automatically
			// so you should explicitly add a condition.
			RuleFor(customer => customer.Address.Country)
				.NotNull()
				.When(customer => customer.Address != null);
		}
	}
}