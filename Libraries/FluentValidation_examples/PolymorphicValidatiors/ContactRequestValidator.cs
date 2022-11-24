using FluentValidation;

namespace FluentValidation_examples.PolymorphicValidatiors
{
	public class ContactRequestValidator : AbstractValidator<ContactRequest>
	{
		public ContactRequestValidator()
		{
			RuleFor(x => x.Contact).SetInheritanceValidator(v =>
			{
				v.Add<Organisation>(new OrganisationValidator());
				v.Add<Person>(new PersonValidator());
			});
			RuleFor(x => x.MessageToSend).NotNull();
		}
	}
}