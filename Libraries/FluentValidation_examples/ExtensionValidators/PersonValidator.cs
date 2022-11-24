using FluentValidation;

namespace FluentValidation_examples.ExtensionValidators
{
	partial class ExtensionValidators
	{
		public class PersonValidator : AbstractValidator<Person>
		{
			public PersonValidator()
			{
				RuleFor(x => x.Pets).ListMustContainFewerThan(3);
			}
		}
	}
}
