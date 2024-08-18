using FluentValidation;

namespace FluentValidationDemo.ListValidators
{
	public class OrderValidator : AbstractValidator<Order>
	{
		public OrderValidator()
		{
			RuleFor(x => x.Total).GreaterThan(0);
		}
	}
}