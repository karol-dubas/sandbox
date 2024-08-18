using FluentValidation;

namespace FluentValidationDemo.BuildInValidators
{
	partial class BuildInValidators
	{
		public class CustomerValidator : AbstractValidator<Customer>
		{
			public CustomerValidator()
			{
				RuleFor(x => x.Id)
					.NotEmpty()
					.NotEqual(1);

				RuleFor(x => x.Forename)
					.NotEmpty()
					.NotEqual(x => x.Surname);

				RuleFor(customer => customer.Password)
					.Equal(customer => customer.PasswordConfirmation);

				RuleFor(x => x.Address)
					.NotNull()
					.Length(1, 10); // Nie sprawdza czy jest null, trzeba dodatkowo sprawdzić

				RuleFor(x => x.Discount)
					.Must(x => x <= 1); // Własna lambda

				RuleFor(x => x.Email)
					.EmailAddress();

				RuleFor(x => x.Gender)
					.IsEnumName(typeof(Gender), caseSensitive: false);
			}
		}
	}
}
