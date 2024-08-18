using FluentValidation;

namespace FluentValidationDemo.RuleSetAndOptions
{
	public class PersonValidator : AbstractValidator<Person>
	{
		public PersonValidator()
		{
			RuleSet(RuleSets.Names, () =>
			{
				RuleFor(x => x.Forename).NotNull();
				RuleFor(x => x.Surname).NotNull();
			});
			RuleFor(x => x.Id).NotEqual(0);
		}
	}
}