using FluentValidation;

namespace FluentValidationDemo.WhenOtherwiseValidators
{
	public class CustomerValidator : AbstractValidator<Customer>
	{
		public CustomerValidator()
		{
			//ValidatorOptions.Global.CascadeMode = CascadeMode.Stop;

			RuleFor(customer => customer.Discount)
				.GreaterThan(0)
				.When(customer => customer.IsPreferred)
				.WithMessage("The value of the discount must be greater than 0 for a regular customer");

			When(customer => customer.IsPreferred, () =>
				{
					RuleFor(customer => customer.Discount).GreaterThan(0);
					RuleFor(customer => customer.CreditCardNumber).NotNull();
				})
				.Otherwise(() =>
				{
					RuleFor(customer => customer.Discount).Equal(0);
				});

			// This will first check whether the Surname property is not null and then will check if it’s
			// not equal to the string “foo”. If the first validator(NotNull) fails, then the call to NotEqual
			// will still be invoked.This can be changed by specifying a cascade mode of Stop:
			
			RuleFor(x => x.Surname).Cascade(CascadeMode.Stop).NotNull().NotEqual("foo");
			
			// Now, if the NotNull validator fails then the NotEqual validator will not be executed.
			// This is particularly useful if you have a complex chain where each
			// validator depends on the previous validator to succeed.
		}
	}
}
