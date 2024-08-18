using FluentValidation;

namespace FluentValidationDemo.ListValidators
{
	public class PersonValidator : AbstractValidator<Person>
	{
		public PersonValidator()
		{
			// The rule will run a NotEmpty check against each item in the AddressLines collection.
			// (v. 8.5) if you want to access the index of the collection element that caused the validation failure, you can use the special {CollectionIndex} placeholder
			RuleForEach(x => x.AddressLines)
				.NotEmpty()
				.WithMessage("Address at index {CollectionIndex} is rquired");

			//RuleForEach(x => x.Orders).SetValidator(new OrderValidator());
			// Zamiast tego wyżej można użyć ChildRules
			RuleForEach(x => x.Orders)
				.ChildRules(orders =>
				{
					orders.RuleFor(x => x.Total).GreaterThan(0);
				});

			// You can optionally include or exclude certain items in the collection from being validated
			// by using the Where method. Note this must come directly after the call to RuleForEach
			RuleForEach(x => x.Orders).Where(y => y.Total == double.MaxValue);
		}
	}
}