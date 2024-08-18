using FluentValidation;

namespace FluentValidationDemo.Basics
{
	public partial class Basics
	{
		public class CustomerValidator : AbstractValidator<Customer>
		{
			// The validation rules themselves should be defined in the validator class’s constructor.

			public CustomerValidator()
			{
				RuleFor(c => c.Surname).NotNull().NotEqual("test");
				RuleFor(c => c.Forename).NotNull();
			}
		}
	}
}
